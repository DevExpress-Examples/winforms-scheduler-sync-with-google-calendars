Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.GoogleCalendar
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Calendar.v3
Imports Google.Apis.Calendar.v3.Data
Imports Google.Apis.Services
Imports Google.Apis.Util.Store
Imports System
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace GCSync

    Public Partial Class Form1
        Inherits RibbonForm

        Private credential As UserCredential

        Private service As CalendarService

        Private calendarList As CalendarList

        Private activeCalendarId As String

        Private allowEventLoad As Boolean

        Public Sub New()
            InitializeComponent()
            InitSkinGallery()
            schedulerControl.Start = Date.Now
            AddHandler ricbCalendarList.SelectedIndexChanged, AddressOf RicbCalendarList_SelectedIndexChanged
            AddHandler bbiSynchronize.ItemClick, AddressOf BbiSynchronize_ItemClick
            AddHandler gcSyncComponent.ConflictDetected, AddressOf GcSyncComponent_ConflictDetected
        End Sub

        Private Sub GcSyncComponent_ConflictDetected(ByVal sender As Object, ByVal e As ConflictDetectedEventArgs)
            XtraMessageBox.Show("Google '" & e.Event.Summary & "' Event conflicts with the Scheduler '" & e.Appointment.Subject & "' Appointment." & Environment.NewLine & "Synchronizing by the Google Event.", "Conflict detected", MessageBoxButtons.OK)
        'uncomment the following line to sync by Scheduler Appointments instead
        'e.GoogleEventIsValid = false;
        End Sub

        'manually trigger synchronization
        Private Sub BbiSynchronize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            gcSyncComponent.Synchronize()
        End Sub

        'assign a selected calendar ID to the component's CalendarID property
        Private Sub RicbCalendarList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As ComboBoxEdit = CType(sender, ComboBoxEdit)
            Dim selectedCalendarSummary As String = CStr(edit.SelectedItem)
            Dim selectedCalendar As CalendarListEntry = calendarList.Items.FirstOrDefault(Function(x) Equals(x.Summary, selectedCalendarSummary))
            activeCalendarId = selectedCalendar.Id
            gcSyncComponent.CalendarId = selectedCalendar.Id
            gcSyncComponent.Synchronize()
            UpdateBbiAvailability()
        End Sub

#Region "Authorization"
        Async Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Directory.CreateDirectory(Environment.CurrentDirectory & "\xml")
            Try
                credential = Await AuthorizeToGoogle()
                service = New CalendarService(New BaseClientService.Initializer() With {.HttpClientInitializer = credential, .ApplicationName = "Google Sync Sample"})
                gcSyncComponent.CalendarService = service
                Await UpdateCalendarListUI()
                allowEventLoad = True
                UpdateBbiAvailability()
                gcSyncComponent.Storage = schedulerStorage
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Async Function AuthorizeToGoogle() As Task(Of UserCredential)
            Using stream As FileStream = New FileStream("credentials.json", FileMode.Open, FileAccess.Read)
                Dim credPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                credPath = Path.Combine(credPath, ".credentials/GoogleSchedulerSync.json")
                Return Await GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, New String() {CalendarService.Scope.Calendar}, "user", CancellationToken.None, New FileDataStore(credPath, True))
            End Using
        End Function

#End Region
        'retrieve calendars from a signed user account
        Private Async Function UpdateCalendarListUI() As Task
            Dim listRequest As CalendarListResource.ListRequest = service.CalendarList.List()
            calendarList = Await listRequest.ExecuteAsync()
            ricbCalendarList.Items.Clear()
            For Each item As CalendarListEntry In calendarList.Items
                If Not ricbCalendarList.Items.Contains(item.Summary) Then
                    ricbCalendarList.Items.Add(item.Summary)
                End If
            Next

            If Not String.IsNullOrEmpty(activeCalendarId) Then
                Dim itemToSelect As CalendarListEntry = calendarList.Items.FirstOrDefault(Function(x) Equals(x.Id, activeCalendarId))
                gcSyncComponent.CalendarId = activeCalendarId
                If ricbCalendarList.Items.Contains(itemToSelect.Summary) Then
                    beiCalendarList.EditValue = itemToSelect.Summary
                Else
                    activeCalendarId = String.Empty
                End If
            End If

            UpdateBbiAvailability()
        End Function

        'specifies whether the "Sync" button should be enabled
        Private Sub UpdateBbiAvailability()
            bbiSynchronize.Enabled = Not String.IsNullOrEmpty(activeCalendarId) AndAlso allowEventLoad
        End Sub

        Private Sub InitSkinGallery()
            Call SkinHelper.InitSkinGallery(rgbiSkins, True)
        End Sub
    End Class
End Namespace
