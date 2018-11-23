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
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace GCSync
    Partial Public Class Form1
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
            Me.gcSyncComponent.Synchronize()
        End Sub

        'assign a selected calendar ID to the component's CalendarID property
        Private Sub RicbCalendarList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim edit As ComboBoxEdit = DirectCast(sender, ComboBoxEdit)
            Dim selectedCalendarSummary As String = CStr(edit.SelectedItem)
            Dim selectedCalendar As CalendarListEntry = Me.calendarList.Items.FirstOrDefault(Function(x) x.Summary = selectedCalendarSummary)
            Me.activeCalendarId = selectedCalendar.Id
            Me.gcSyncComponent.CalendarId = selectedCalendar.Id
            Me.gcSyncComponent.Synchronize()
            UpdateBbiAvailability()
        End Sub


        #Region "Authorization"
        Async Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Directory.CreateDirectory(Environment.CurrentDirectory & "\xml")
            Try
                Me.credential = Await AuthorizeToGoogle()
                Me.service = New CalendarService(New BaseClientService.Initializer() With { _
                    .HttpClientInitializer = Me.credential, _
                    .ApplicationName = "Google Sync Sample" _
                })
                Me.gcSyncComponent.CalendarService = Me.service
                Await UpdateCalendarListUI()
                Me.allowEventLoad = True
                UpdateBbiAvailability()
                Me.gcSyncComponent.Storage = schedulerStorage
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Async Function AuthorizeToGoogle() As Task(Of UserCredential)
            Using stream As New FileStream("credentials.json", FileMode.Open, FileAccess.Read)
                Dim credPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                credPath = Path.Combine(credPath, ".credentials/GoogleSchedulerSync.json")

                Return Await GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, New String() { CalendarService.Scope.Calendar }, "user", CancellationToken.None, New FileDataStore(credPath, True))
            End Using
        End Function
        #End Region

        'retrieve calendars from a signed user account
        Private Async Function UpdateCalendarListUI() As Task
            Dim listRequest As CalendarListResource.ListRequest = Me.service.CalendarList.List()
            Me.calendarList = Await listRequest.ExecuteAsync()
            Me.ricbCalendarList.Items.Clear()
            For Each item As CalendarListEntry In Me.calendarList.Items
                If Not ricbCalendarList.Items.Contains(item.Summary) Then
                    Me.ricbCalendarList.Items.Add(item.Summary)
                End If
            Next item
            If Not String.IsNullOrEmpty(Me.activeCalendarId) Then
                Dim itemToSelect As CalendarListEntry = Me.calendarList.Items.FirstOrDefault(Function(x) x.Id = Me.activeCalendarId)
                Me.gcSyncComponent.CalendarId = Me.activeCalendarId
                If Me.ricbCalendarList.Items.Contains(itemToSelect.Summary) Then
                    Me.beiCalendarList.EditValue = itemToSelect.Summary
                Else
                    Me.activeCalendarId = String.Empty
                End If
            End If
            UpdateBbiAvailability()
        End Function

        'specifies whether the "Sync" button should be enabled
        Private Sub UpdateBbiAvailability()
            Me.bbiSynchronize.Enabled = Not String.IsNullOrEmpty(Me.activeCalendarId) AndAlso Me.allowEventLoad
        End Sub

        Private Sub InitSkinGallery()
            SkinHelper.InitSkinGallery(rgbiSkins, True)
        End Sub
    End Class
End Namespace