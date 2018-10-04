using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.GoogleCalendar;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCSync {
    public partial class Form1 : RibbonForm {
        UserCredential credential;
        CalendarService service;
        CalendarList calendarList;
        string activeCalendarId;
        bool allowEventLoad;
        public Form1() {
            InitializeComponent();
            InitSkinGallery();
            schedulerControl.Start = System.DateTime.Now;
            ricbCalendarList.SelectedIndexChanged += RicbCalendarList_SelectedIndexChanged;
            bbiSynchronize.ItemClick += BbiSynchronize_ItemClick;
            gcSyncComponent.ConflictDetected += GcSyncComponent_ConflictDetected;

        }

        private void GcSyncComponent_ConflictDetected(object sender, ConflictDetectedEventArgs e) {
            XtraMessageBox.Show("Google '" + e.Event.Summary + "' Event conflicts with the Scheduler '" +
                e.Appointment.Subject + "' Appointment." + Environment.NewLine + "Synchronizing by the Google Event.",
                "Conflict detected", MessageBoxButtons.OK);
            //uncomment the following line to sync by Scheduler Appointments instead
            //e.GoogleEventIsValid = false;
        }

        //manually trigger synchronization
        private void BbiSynchronize_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.gcSyncComponent.Sync();
        }

        //assign a selected calendar ID to the component's CalendarID property
        private void RicbCalendarList_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit edit = (ComboBoxEdit)sender;
            string selectedCalendarSummary = (string)edit.SelectedItem;
            CalendarListEntry selectedCalendar = this.calendarList.Items.FirstOrDefault(x => x.Summary == selectedCalendarSummary);
            this.activeCalendarId = selectedCalendar.Id;
            this.gcSyncComponent.CalendarId = selectedCalendar.Id;
            this.gcSyncComponent.Sync(); 
            UpdateBbiAvailability();
        }


        #region Authorization
        async protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\xml");
            try {
                this.credential = await AuthorizeToGoogle();
                this.service = new CalendarService(new BaseClientService.Initializer() {
                    HttpClientInitializer = this.credential,
                    ApplicationName = "Google Sync Sample"
                });
                this.gcSyncComponent.CalendarService = this.service;
                await UpdateCalendarListUI();
                this.allowEventLoad = true;
                UpdateBbiAvailability();
                this.gcSyncComponent.Storage = schedulerStorage;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        async Task<UserCredential> AuthorizeToGoogle() {
            using (FileStream stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read)) {
                string credPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/GoogleSchedulerSync.json");

                return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new String[] { CalendarService.Scope.Calendar },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));
            }
        }
        #endregion

        //retrieve calendars from a signed user account
        async Task UpdateCalendarListUI() {
            CalendarListResource.ListRequest listRequest = this.service.CalendarList.List();
            this.calendarList = await listRequest.ExecuteAsync();
            this.ricbCalendarList.Items.Clear();
            foreach (CalendarListEntry item in this.calendarList.Items)
                if (!ricbCalendarList.Items.Contains(item.Summary)) {
                    this.ricbCalendarList.Items.Add(item.Summary);
                }
            if (!String.IsNullOrEmpty(this.activeCalendarId)) {
                CalendarListEntry itemToSelect = this.calendarList.Items.FirstOrDefault(x => x.Id == this.activeCalendarId);
                this.gcSyncComponent.CalendarId = this.activeCalendarId;
                if (this.ricbCalendarList.Items.Contains(itemToSelect.Summary)) {
                    this.beiCalendarList.EditValue = itemToSelect.Summary;
                }
                else
                    this.activeCalendarId = String.Empty;
            }
            UpdateBbiAvailability();
        }

        //specifies whether the "Sync" button should be enabled
        void UpdateBbiAvailability() {
            this.bbiSynchronize.Enabled = !String.IsNullOrEmpty(this.activeCalendarId) && this.allowEventLoad;
        }

        void InitSkinGallery() {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
    }
}