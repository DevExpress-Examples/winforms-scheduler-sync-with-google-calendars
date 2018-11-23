Namespace GCSync
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler3 As New DevExpress.XtraScheduler.TimeRuler()
            Me.splitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
            Me.navBarControl = New DevExpress.XtraNavBar.NavBarControl()
            Me.mailGroup = New DevExpress.XtraNavBar.NavBarGroup()
            Me.inboxItem = New DevExpress.XtraNavBar.NavBarItem()
            Me.outboxItem = New DevExpress.XtraNavBar.NavBarItem()
            Me.draftsItem = New DevExpress.XtraNavBar.NavBarItem()
            Me.trashItem = New DevExpress.XtraNavBar.NavBarItem()
            Me.organizerGroup = New DevExpress.XtraNavBar.NavBarGroup()
            Me.calendarItem = New DevExpress.XtraNavBar.NavBarItem()
            Me.tasksItem = New DevExpress.XtraNavBar.NavBarItem()
            Me.navbarImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
            Me.navbarImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
            Me.schedulerSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            Me.dateNavigator = New DevExpress.XtraScheduler.DateNavigator()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.appMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
            Me.popupControlContainer2 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.buttonEdit = New DevExpress.XtraEditors.ButtonEdit()
            Me.iExit = New DevExpress.XtraBars.BarButtonItem()
            Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.someLabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.someLabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.ribbonImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
            Me.iHelp = New DevExpress.XtraBars.BarButtonItem()
            Me.iAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.siStatus = New DevExpress.XtraBars.BarStaticItem()
            Me.siInfo = New DevExpress.XtraBars.BarStaticItem()
            Me.rgbiSkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.editAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
            Me.editOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
            Me.editSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
            Me.deleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
            Me.deleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
            Me.deleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
            Me.splitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
            Me.changeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
            Me.changeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
            Me.toggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
            Me.changeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
            Me.repositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
            Me.switchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
            Me.switchToWorkWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem()
            Me.switchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
            Me.switchToFullWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem()
            Me.switchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
            Me.switchToTimelineViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem()
            Me.switchToGanttViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToGanttViewItem()
            Me.switchToAgendaViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem()
            Me.switchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
            Me.changeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.switchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
            Me.switchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
            Me.switchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
            Me.switchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
            Me.changeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
            Me.newAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
            Me.newRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
            Me.navigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
            Me.navigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
            Me.gotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
            Me.viewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
            Me.viewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
            Me.groupByNoneItem1 = New DevExpress.XtraScheduler.UI.GroupByNoneItem()
            Me.groupByDateItem1 = New DevExpress.XtraScheduler.UI.GroupByDateItem()
            Me.groupByResourceItem1 = New DevExpress.XtraScheduler.UI.GroupByResourceItem()
            Me.openScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
            Me.saveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
            Me.printPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
            Me.printItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
            Me.printPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
            Me.beiCalendarList = New DevExpress.XtraBars.BarEditItem()
            Me.ricbCalendarList = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.bbiSynchronize = New DevExpress.XtraBars.BarButtonItem()
            Me.skinPaletteRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
            Me.ribbonImageCollectionLarge = New DevExpress.Utils.ImageCollection(Me.components)
            Me.calendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
            Me.appointmentRibbonPage1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPage()
            Me.actionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup()
            Me.optionsRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup()
            Me.fileRibbonPage1 = New DevExpress.XtraScheduler.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.CommonRibbonPageGroup()
            Me.printRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.PrintRibbonPageGroup()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraScheduler.UI.HomeRibbonPage()
            Me.appointmentRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup()
            Me.navigatorRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup()
            Me.arrangeRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup()
            Me.groupByRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup()
            Me.viewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
            Me.activeViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
            Me.timeScaleRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup()
            Me.layoutRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup()
            Me.ribbonPageSkins = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.skinsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.helpRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.helpRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.schedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController(Me.components)
            Me.gcSyncComponent = New DevExpress.XtraScheduler.GoogleCalendar.DXGoogleCalendarSync(Me.components)
            CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl.SuspendLayout()
            CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerSplitContainerControl.SuspendLayout()
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateNavigator.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.appMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer2.SuspendLayout()
            CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ricbCalendarList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' splitContainerControl
            ' 
            Me.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl.Location = New System.Drawing.Point(0, 162)
            Me.splitContainerControl.Name = "splitContainerControl"
            Me.splitContainerControl.Padding = New System.Windows.Forms.Padding(6)
            Me.splitContainerControl.Panel1.Controls.Add(Me.navBarControl)
            Me.splitContainerControl.Panel1.Text = "Panel1"
            Me.splitContainerControl.Panel2.Controls.Add(Me.schedulerSplitContainerControl)
            Me.splitContainerControl.Panel2.Text = "Panel2"
            Me.splitContainerControl.Size = New System.Drawing.Size(1100, 512)
            Me.splitContainerControl.SplitterPosition = 165
            Me.splitContainerControl.TabIndex = 0
            Me.splitContainerControl.Text = "splitContainerControl1"
            ' 
            ' navBarControl
            ' 
            Me.navBarControl.ActiveGroup = Me.mailGroup
            Me.navBarControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navBarControl.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.mailGroup, Me.organizerGroup})
            Me.navBarControl.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.inboxItem, Me.outboxItem, Me.draftsItem, Me.trashItem, Me.calendarItem, Me.tasksItem})
            Me.navBarControl.LargeImages = Me.navbarImageCollectionLarge
            Me.navBarControl.Location = New System.Drawing.Point(0, 0)
            Me.navBarControl.Name = "navBarControl"
            Me.navBarControl.OptionsNavPane.ExpandedWidth = 165
            Me.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
            Me.navBarControl.Size = New System.Drawing.Size(165, 500)
            Me.navBarControl.SmallImages = Me.navbarImageCollection
            Me.navBarControl.StoreDefaultPaintStyleName = True
            Me.navBarControl.TabIndex = 1
            Me.navBarControl.Text = "navBarControl1"
            ' 
            ' mailGroup
            ' 
            Me.mailGroup.Caption = "Mail"
            Me.mailGroup.Expanded = True
            Me.mailGroup.ImageOptions.LargeImageIndex = 0
            Me.mailGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.inboxItem), _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.outboxItem), _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.draftsItem), _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.trashItem) _
            })
            Me.mailGroup.Name = "mailGroup"
            ' 
            ' inboxItem
            ' 
            Me.inboxItem.Caption = "Inbox"
            Me.inboxItem.ImageOptions.SmallImageIndex = 0
            Me.inboxItem.Name = "inboxItem"
            ' 
            ' outboxItem
            ' 
            Me.outboxItem.Caption = "Outbox"
            Me.outboxItem.ImageOptions.SmallImageIndex = 1
            Me.outboxItem.Name = "outboxItem"
            ' 
            ' draftsItem
            ' 
            Me.draftsItem.Caption = "Drafts"
            Me.draftsItem.ImageOptions.SmallImageIndex = 2
            Me.draftsItem.Name = "draftsItem"
            ' 
            ' trashItem
            ' 
            Me.trashItem.Caption = "Trash"
            Me.trashItem.ImageOptions.SmallImageIndex = 3
            Me.trashItem.Name = "trashItem"
            ' 
            ' organizerGroup
            ' 
            Me.organizerGroup.Caption = "Organizer"
            Me.organizerGroup.ImageOptions.LargeImageIndex = 1
            Me.organizerGroup.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.calendarItem), _
                New DevExpress.XtraNavBar.NavBarItemLink(Me.tasksItem) _
            })
            Me.organizerGroup.Name = "organizerGroup"
            ' 
            ' calendarItem
            ' 
            Me.calendarItem.Caption = "Calendar"
            Me.calendarItem.ImageOptions.SmallImageIndex = 4
            Me.calendarItem.Name = "calendarItem"
            ' 
            ' tasksItem
            ' 
            Me.tasksItem.Caption = "Tasks"
            Me.tasksItem.ImageOptions.SmallImageIndex = 5
            Me.tasksItem.Name = "tasksItem"
            ' 
            ' navbarImageCollectionLarge
            ' 
            Me.navbarImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
            Me.navbarImageCollectionLarge.ImageStream = (CType(resources.GetObject("navbarImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.navbarImageCollectionLarge.TransparentColor = System.Drawing.Color.Transparent
            Me.navbarImageCollectionLarge.Images.SetKeyName(0, "Mail_32x32.png")
            Me.navbarImageCollectionLarge.Images.SetKeyName(1, "Organizer_32x32.png")
            ' 
            ' navbarImageCollection
            ' 
            Me.navbarImageCollection.ImageStream = (CType(resources.GetObject("navbarImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.navbarImageCollection.TransparentColor = System.Drawing.Color.Transparent
            Me.navbarImageCollection.Images.SetKeyName(0, "Inbox_16x16.png")
            Me.navbarImageCollection.Images.SetKeyName(1, "Outbox_16x16.png")
            Me.navbarImageCollection.Images.SetKeyName(2, "Drafts_16x16.png")
            Me.navbarImageCollection.Images.SetKeyName(3, "Trash_16x16.png")
            Me.navbarImageCollection.Images.SetKeyName(4, "Calendar_16x16.png")
            Me.navbarImageCollection.Images.SetKeyName(5, "Tasks_16x16.png")
            ' 
            ' schedulerSplitContainerControl
            ' 
            Me.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.schedulerSplitContainerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl"
            Me.schedulerSplitContainerControl.Panel1.Controls.Add(Me.schedulerControl)
            Me.schedulerSplitContainerControl.Panel1.Text = "Panel1"
            Me.schedulerSplitContainerControl.Panel2.Controls.Add(Me.dateNavigator)
            Me.schedulerSplitContainerControl.Panel2.Text = "Panel2"
            Me.schedulerSplitContainerControl.Size = New System.Drawing.Size(913, 500)
            Me.schedulerSplitContainerControl.SplitterPosition = 225
            Me.schedulerSplitContainerControl.TabIndex = 2
            Me.schedulerSplitContainerControl.Text = "splitContainerControl1"
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month
            Me.schedulerControl.DataStorage = Me.schedulerStorage
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(678, 500)
            Me.schedulerControl.Start = New Date(2018, 9, 23, 0, 0, 0, 0)
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.FullWeekView.Enabled = True
            Me.schedulerControl.Views.FullWeekView.TimeRulers.Add(timeRuler2)
            Me.schedulerControl.Views.WeekView.Enabled = False
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler3)
            ' 
            ' dateNavigator
            ' 
            Me.dateNavigator.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateNavigator.DateTime = New Date(2018, 9, 27, 0, 0, 0, 0)
            Me.dateNavigator.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateNavigator.EditValue = New Date(2018, 9, 27, 0, 0, 0, 0)
            Me.dateNavigator.FirstDayOfWeek = System.DayOfWeek.Sunday
            Me.dateNavigator.Location = New System.Drawing.Point(0, 0)
            Me.dateNavigator.Name = "dateNavigator"
            Me.dateNavigator.SchedulerControl = Me.schedulerControl
            Me.dateNavigator.Size = New System.Drawing.Size(225, 500)
            Me.dateNavigator.TabIndex = 1
            ' 
            ' ribbonControl
            ' 
            Me.ribbonControl.ApplicationButtonDropDownControl = Me.appMenu
            Me.ribbonControl.ApplicationButtonText = Nothing
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Images = Me.ribbonImageCollection
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.iExit, Me.iHelp, Me.iAbout, Me.siStatus, Me.siInfo, Me.rgbiSkins, Me.editAppointmentQueryItem1, Me.editOccurrenceUICommandItem1, Me.editSeriesUICommandItem1, Me.deleteAppointmentsItem1, Me.deleteOccurrenceItem1, Me.deleteSeriesItem1, Me.splitAppointmentItem1, Me.changeAppointmentStatusItem1, Me.changeAppointmentLabelItem1, Me.toggleRecurrenceItem1, Me.changeAppointmentReminderItem1, Me.switchToDayViewItem1, Me.switchToWorkWeekViewItem1, Me.switchToWeekViewItem1, Me.switchToFullWeekViewItem1, Me.switchToMonthViewItem1, Me.switchToTimelineViewItem1, Me.switchToGanttViewItem1, Me.switchToAgendaViewItem1, Me.switchTimeScalesItem1, Me.changeScaleWidthItem1, Me.switchTimeScalesCaptionItem1, Me.switchCompressWeekendItem1, Me.switchShowWorkTimeOnlyItem1, Me.switchCellsAutoHeightItem1, Me.changeSnapToCellsUIItem1, Me.newAppointmentItem1, Me.newRecurringAppointmentItem1, Me.navigateViewBackwardItem1, Me.navigateViewForwardItem1, Me.gotoTodayItem1, Me.viewZoomInItem1, Me.viewZoomOutItem1, Me.groupByNoneItem1, Me.groupByDateItem1, Me.groupByResourceItem1, Me.openScheduleItem1, Me.saveScheduleItem1, Me.printPreviewItem1, Me.printItem1, Me.printPageSetupItem1, Me.beiCalendarList, Me.bbiSynchronize, Me.skinPaletteRibbonGalleryBarItem1})
            Me.ribbonControl.LargeImages = Me.ribbonImageCollectionLarge
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 108
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.calendarToolsRibbonPageCategory1})
            Me.ribbonControl.PageHeaderItemLinks.Add(Me.iAbout)
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage1, Me.viewRibbonPage1, Me.ribbonPageSkins, Me.helpRibbonPage})
            Me.ribbonControl.QuickToolbarItemLinks.Add(Me.iHelp)
            Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemDuration1, Me.repositoryItemSpinEdit1, Me.ricbCalendarList})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.ribbonControl.Size = New System.Drawing.Size(1100, 162)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            ' 
            ' appMenu
            ' 
            Me.appMenu.BottomPaneControlContainer = Me.popupControlContainer2
            Me.appMenu.ItemLinks.Add(Me.iExit)
            Me.appMenu.Name = "appMenu"
            Me.appMenu.Ribbon = Me.ribbonControl
            Me.appMenu.RightPaneControlContainer = Me.popupControlContainer1
            Me.appMenu.ShowRightPane = True
            ' 
            ' popupControlContainer2
            ' 
            Me.popupControlContainer2.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.popupControlContainer2.Appearance.Options.UseBackColor = True
            Me.popupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer2.Controls.Add(Me.buttonEdit)
            Me.popupControlContainer2.Location = New System.Drawing.Point(238, 289)
            Me.popupControlContainer2.Name = "popupControlContainer2"
            Me.popupControlContainer2.Ribbon = Me.ribbonControl
            Me.popupControlContainer2.Size = New System.Drawing.Size(118, 28)
            Me.popupControlContainer2.TabIndex = 3
            Me.popupControlContainer2.Visible = False
            ' 
            ' buttonEdit
            ' 
            Me.buttonEdit.EditValue = "Some Text"
            Me.buttonEdit.Location = New System.Drawing.Point(3, 5)
            Me.buttonEdit.MenuManager = Me.ribbonControl
            Me.buttonEdit.Name = "buttonEdit"
            Me.buttonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.buttonEdit.Size = New System.Drawing.Size(100, 20)
            Me.buttonEdit.TabIndex = 0
            ' 
            ' iExit
            ' 
            Me.iExit.Caption = "Exit"
            Me.iExit.Description = "Closes this program after prompting you to save unsaved data."
            Me.iExit.Hint = "Closes this program after prompting you to save unsaved data"
            Me.iExit.Id = 20
            Me.iExit.ImageOptions.ImageIndex = 6
            Me.iExit.ImageOptions.LargeImageIndex = 6
            Me.iExit.Name = "iExit"
            ' 
            ' popupControlContainer1
            ' 
            Me.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.popupControlContainer1.Appearance.Options.UseBackColor = True
            Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Controls.Add(Me.someLabelControl2)
            Me.popupControlContainer1.Controls.Add(Me.someLabelControl1)
            Me.popupControlContainer1.Location = New System.Drawing.Point(111, 197)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Ribbon = Me.ribbonControl
            Me.popupControlContainer1.Size = New System.Drawing.Size(76, 70)
            Me.popupControlContainer1.TabIndex = 2
            Me.popupControlContainer1.Visible = False
            ' 
            ' someLabelControl2
            ' 
            Me.someLabelControl2.Location = New System.Drawing.Point(3, 57)
            Me.someLabelControl2.Name = "someLabelControl2"
            Me.someLabelControl2.Size = New System.Drawing.Size(49, 13)
            Me.someLabelControl2.TabIndex = 0
            Me.someLabelControl2.Text = "Some Info"
            ' 
            ' someLabelControl1
            ' 
            Me.someLabelControl1.Location = New System.Drawing.Point(3, 3)
            Me.someLabelControl1.Name = "someLabelControl1"
            Me.someLabelControl1.Size = New System.Drawing.Size(49, 13)
            Me.someLabelControl1.TabIndex = 0
            Me.someLabelControl1.Text = "Some Info"
            ' 
            ' ribbonImageCollection
            ' 
            Me.ribbonImageCollection.ImageStream = (CType(resources.GetObject("ribbonImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.ribbonImageCollection.Images.SetKeyName(0, "Ribbon_Exit_16x16.png")
            Me.ribbonImageCollection.Images.SetKeyName(1, "Ribbon_Content_16x16.png")
            Me.ribbonImageCollection.Images.SetKeyName(2, "Ribbon_Info_16x16.png")
            ' 
            ' iHelp
            ' 
            Me.iHelp.Caption = "Help"
            Me.iHelp.Description = "Start the program help system."
            Me.iHelp.Hint = "Start the program help system"
            Me.iHelp.Id = 22
            Me.iHelp.ImageOptions.ImageIndex = 7
            Me.iHelp.ImageOptions.LargeImageIndex = 7
            Me.iHelp.Name = "iHelp"
            ' 
            ' iAbout
            ' 
            Me.iAbout.Caption = "About"
            Me.iAbout.Description = "Displays general program information."
            Me.iAbout.Hint = "Displays general program information"
            Me.iAbout.Id = 24
            Me.iAbout.ImageOptions.ImageIndex = 8
            Me.iAbout.ImageOptions.LargeImageIndex = 8
            Me.iAbout.Name = "iAbout"
            ' 
            ' siStatus
            ' 
            Me.siStatus.Caption = "Some Status Info"
            Me.siStatus.Id = 31
            Me.siStatus.Name = "siStatus"
            ' 
            ' siInfo
            ' 
            Me.siInfo.Caption = "Some Info"
            Me.siInfo.Id = 32
            Me.siInfo.Name = "siInfo"
            ' 
            ' rgbiSkins
            ' 
            Me.rgbiSkins.Caption = "Skins"
            ' 
            ' 
            ' 
            Me.rgbiSkins.Gallery.AllowHoverImages = True
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.rgbiSkins.Gallery.ColumnCount = 4
            Me.rgbiSkins.Gallery.FixedHoverImageSize = False
            Me.rgbiSkins.Gallery.ImageSize = New System.Drawing.Size(32, 17)
            Me.rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
            Me.rgbiSkins.Gallery.RowCount = 4
            Me.rgbiSkins.Id = 60
            Me.rgbiSkins.Name = "rgbiSkins"
            ' 
            ' editAppointmentQueryItem1
            ' 
            Me.editAppointmentQueryItem1.Id = 62
            Me.editAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.editOccurrenceUICommandItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.editSeriesUICommandItem1) _
            })
            Me.editAppointmentQueryItem1.Name = "editAppointmentQueryItem1"
            Me.editAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' editOccurrenceUICommandItem1
            ' 
            Me.editOccurrenceUICommandItem1.Id = 63
            Me.editOccurrenceUICommandItem1.Name = "editOccurrenceUICommandItem1"
            ' 
            ' editSeriesUICommandItem1
            ' 
            Me.editSeriesUICommandItem1.Id = 64
            Me.editSeriesUICommandItem1.Name = "editSeriesUICommandItem1"
            ' 
            ' deleteAppointmentsItem1
            ' 
            Me.deleteAppointmentsItem1.Id = 65
            Me.deleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteOccurrenceItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteSeriesItem1) _
            })
            Me.deleteAppointmentsItem1.Name = "deleteAppointmentsItem1"
            Me.deleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
            ' 
            ' deleteOccurrenceItem1
            ' 
            Me.deleteOccurrenceItem1.Id = 66
            Me.deleteOccurrenceItem1.Name = "deleteOccurrenceItem1"
            ' 
            ' deleteSeriesItem1
            ' 
            Me.deleteSeriesItem1.Id = 67
            Me.deleteSeriesItem1.Name = "deleteSeriesItem1"
            ' 
            ' splitAppointmentItem1
            ' 
            Me.splitAppointmentItem1.Id = 68
            Me.splitAppointmentItem1.Name = "splitAppointmentItem1"
            ' 
            ' changeAppointmentStatusItem1
            ' 
            Me.changeAppointmentStatusItem1.Id = 69
            Me.changeAppointmentStatusItem1.Name = "changeAppointmentStatusItem1"
            ' 
            ' changeAppointmentLabelItem1
            ' 
            Me.changeAppointmentLabelItem1.Id = 70
            Me.changeAppointmentLabelItem1.Name = "changeAppointmentLabelItem1"
            ' 
            ' toggleRecurrenceItem1
            ' 
            Me.toggleRecurrenceItem1.Id = 71
            Me.toggleRecurrenceItem1.Name = "toggleRecurrenceItem1"
            ' 
            ' changeAppointmentReminderItem1
            ' 
            Me.changeAppointmentReminderItem1.Edit = Me.repositoryItemDuration1
            Me.changeAppointmentReminderItem1.Id = 72
            Me.changeAppointmentReminderItem1.Name = "changeAppointmentReminderItem1"
            ' 
            ' repositoryItemDuration1
            ' 
            Me.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
            Me.repositoryItemDuration1.AutoHeight = False
            Me.repositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDuration1.DisabledStateText = Nothing
            Me.repositoryItemDuration1.Name = "repositoryItemDuration1"
            Me.repositoryItemDuration1.NullValuePromptShowForEmptyValue = True
            Me.repositoryItemDuration1.ShowEmptyItem = True
            Me.repositoryItemDuration1.ValidateOnEnterKey = True
            ' 
            ' switchToDayViewItem1
            ' 
            Me.switchToDayViewItem1.Id = 73
            Me.switchToDayViewItem1.Name = "switchToDayViewItem1"
            ' 
            ' switchToWorkWeekViewItem1
            ' 
            Me.switchToWorkWeekViewItem1.Id = 74
            Me.switchToWorkWeekViewItem1.Name = "switchToWorkWeekViewItem1"
            ' 
            ' switchToWeekViewItem1
            ' 
            Me.switchToWeekViewItem1.Id = 75
            Me.switchToWeekViewItem1.Name = "switchToWeekViewItem1"
            ' 
            ' switchToFullWeekViewItem1
            ' 
            Me.switchToFullWeekViewItem1.Id = 76
            Me.switchToFullWeekViewItem1.Name = "switchToFullWeekViewItem1"
            ' 
            ' switchToMonthViewItem1
            ' 
            Me.switchToMonthViewItem1.Id = 77
            Me.switchToMonthViewItem1.Name = "switchToMonthViewItem1"
            ' 
            ' switchToTimelineViewItem1
            ' 
            Me.switchToTimelineViewItem1.Id = 78
            Me.switchToTimelineViewItem1.Name = "switchToTimelineViewItem1"
            ' 
            ' switchToGanttViewItem1
            ' 
            Me.switchToGanttViewItem1.Id = 79
            Me.switchToGanttViewItem1.Name = "switchToGanttViewItem1"
            ' 
            ' switchToAgendaViewItem1
            ' 
            Me.switchToAgendaViewItem1.Id = 80
            Me.switchToAgendaViewItem1.Name = "switchToAgendaViewItem1"
            ' 
            ' switchTimeScalesItem1
            ' 
            Me.switchTimeScalesItem1.Id = 81
            Me.switchTimeScalesItem1.Name = "switchTimeScalesItem1"
            ' 
            ' changeScaleWidthItem1
            ' 
            Me.changeScaleWidthItem1.Edit = Me.repositoryItemSpinEdit1
            Me.changeScaleWidthItem1.Id = 82
            Me.changeScaleWidthItem1.Name = "changeScaleWidthItem1"
            Me.changeScaleWidthItem1.UseCommandCaption = True
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 200, 0, 0, 0})
            Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() { 10, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' switchTimeScalesCaptionItem1
            ' 
            Me.switchTimeScalesCaptionItem1.Id = 83
            Me.switchTimeScalesCaptionItem1.Name = "switchTimeScalesCaptionItem1"
            ' 
            ' switchCompressWeekendItem1
            ' 
            Me.switchCompressWeekendItem1.Id = 84
            Me.switchCompressWeekendItem1.Name = "switchCompressWeekendItem1"
            ' 
            ' switchShowWorkTimeOnlyItem1
            ' 
            Me.switchShowWorkTimeOnlyItem1.Id = 85
            Me.switchShowWorkTimeOnlyItem1.Name = "switchShowWorkTimeOnlyItem1"
            ' 
            ' switchCellsAutoHeightItem1
            ' 
            Me.switchCellsAutoHeightItem1.Id = 86
            Me.switchCellsAutoHeightItem1.Name = "switchCellsAutoHeightItem1"
            ' 
            ' changeSnapToCellsUIItem1
            ' 
            Me.changeSnapToCellsUIItem1.Id = 87
            Me.changeSnapToCellsUIItem1.Name = "changeSnapToCellsUIItem1"
            ' 
            ' newAppointmentItem1
            ' 
            Me.newAppointmentItem1.Id = 88
            Me.newAppointmentItem1.Name = "newAppointmentItem1"
            ' 
            ' newRecurringAppointmentItem1
            ' 
            Me.newRecurringAppointmentItem1.Id = 89
            Me.newRecurringAppointmentItem1.Name = "newRecurringAppointmentItem1"
            ' 
            ' navigateViewBackwardItem1
            ' 
            Me.navigateViewBackwardItem1.Id = 90
            Me.navigateViewBackwardItem1.Name = "navigateViewBackwardItem1"
            ' 
            ' navigateViewForwardItem1
            ' 
            Me.navigateViewForwardItem1.Id = 91
            Me.navigateViewForwardItem1.Name = "navigateViewForwardItem1"
            ' 
            ' gotoTodayItem1
            ' 
            Me.gotoTodayItem1.Id = 92
            Me.gotoTodayItem1.Name = "gotoTodayItem1"
            ' 
            ' viewZoomInItem1
            ' 
            Me.viewZoomInItem1.Id = 93
            Me.viewZoomInItem1.Name = "viewZoomInItem1"
            ' 
            ' viewZoomOutItem1
            ' 
            Me.viewZoomOutItem1.Id = 94
            Me.viewZoomOutItem1.Name = "viewZoomOutItem1"
            ' 
            ' groupByNoneItem1
            ' 
            Me.groupByNoneItem1.Id = 95
            Me.groupByNoneItem1.Name = "groupByNoneItem1"
            ' 
            ' groupByDateItem1
            ' 
            Me.groupByDateItem1.Id = 96
            Me.groupByDateItem1.Name = "groupByDateItem1"
            ' 
            ' groupByResourceItem1
            ' 
            Me.groupByResourceItem1.Id = 97
            Me.groupByResourceItem1.Name = "groupByResourceItem1"
            ' 
            ' openScheduleItem1
            ' 
            Me.openScheduleItem1.Id = 98
            Me.openScheduleItem1.Name = "openScheduleItem1"
            ' 
            ' saveScheduleItem1
            ' 
            Me.saveScheduleItem1.Id = 99
            Me.saveScheduleItem1.Name = "saveScheduleItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 100
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 101
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPageSetupItem1
            ' 
            Me.printPageSetupItem1.Id = 102
            Me.printPageSetupItem1.Name = "printPageSetupItem1"
            ' 
            ' beiCalendarList
            ' 
            Me.beiCalendarList.Caption = "Calendar"
            Me.beiCalendarList.Edit = Me.ricbCalendarList
            Me.beiCalendarList.EditWidth = 100
            Me.beiCalendarList.Id = 104
            Me.beiCalendarList.Name = "beiCalendarList"
            ' 
            ' ricbCalendarList
            ' 
            Me.ricbCalendarList.AutoHeight = False
            Me.ricbCalendarList.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ricbCalendarList.Name = "ricbCalendarList"
            ' 
            ' bbiSynchronize
            ' 
            Me.bbiSynchronize.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.bbiSynchronize.Caption = "Sync"
            Me.bbiSynchronize.Id = 105
            Me.bbiSynchronize.ImageOptions.SvgImage = (CType(resources.GetObject("bbiSynchronize.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage))
            Me.bbiSynchronize.Name = "bbiSynchronize"
            Me.bbiSynchronize.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' skinPaletteRibbonGalleryBarItem1
            ' 
            Me.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1"
            Me.skinPaletteRibbonGalleryBarItem1.Id = 106
            Me.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1"
            ' 
            ' ribbonImageCollectionLarge
            ' 
            Me.ribbonImageCollectionLarge.ImageSize = New System.Drawing.Size(32, 32)
            Me.ribbonImageCollectionLarge.ImageStream = (CType(resources.GetObject("ribbonImageCollectionLarge.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_Exit_32x32.png")
            Me.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Content_32x32.png")
            Me.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Info_32x32.png")
            ' 
            ' calendarToolsRibbonPageCategory1
            ' 
            Me.calendarToolsRibbonPageCategory1.Control = Me.schedulerControl
            Me.calendarToolsRibbonPageCategory1.Name = "calendarToolsRibbonPageCategory1"
            Me.calendarToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.appointmentRibbonPage1})
            Me.calendarToolsRibbonPageCategory1.Visible = False
            ' 
            ' appointmentRibbonPage1
            ' 
            Me.appointmentRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.actionsRibbonPageGroup1, Me.optionsRibbonPageGroup1})
            Me.appointmentRibbonPage1.Name = "appointmentRibbonPage1"
            Me.appointmentRibbonPage1.Visible = False
            ' 
            ' actionsRibbonPageGroup1
            ' 
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.editAppointmentQueryItem1)
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.deleteAppointmentsItem1)
            Me.actionsRibbonPageGroup1.ItemLinks.Add(Me.splitAppointmentItem1)
            Me.actionsRibbonPageGroup1.Name = "actionsRibbonPageGroup1"
            ' 
            ' optionsRibbonPageGroup1
            ' 
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentStatusItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentLabelItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.toggleRecurrenceItem1)
            Me.optionsRibbonPageGroup1.ItemLinks.Add(Me.changeAppointmentReminderItem1)
            Me.optionsRibbonPageGroup1.Name = "optionsRibbonPageGroup1"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.printRibbonPageGroup1, Me.ribbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.openScheduleItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.saveScheduleItem1)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' printRibbonPageGroup1
            ' 
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPreviewItem1)
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printItem1)
            Me.printRibbonPageGroup1.ItemLinks.Add(Me.printPageSetupItem1)
            Me.printRibbonPageGroup1.Name = "printRibbonPageGroup1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.beiCalendarList)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiSynchronize)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Google Calendar"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.appointmentRibbonPageGroup1, Me.navigatorRibbonPageGroup1, Me.arrangeRibbonPageGroup1, Me.groupByRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            ' 
            ' appointmentRibbonPageGroup1
            ' 
            Me.appointmentRibbonPageGroup1.ItemLinks.Add(Me.newAppointmentItem1)
            Me.appointmentRibbonPageGroup1.ItemLinks.Add(Me.newRecurringAppointmentItem1)
            Me.appointmentRibbonPageGroup1.Name = "appointmentRibbonPageGroup1"
            ' 
            ' navigatorRibbonPageGroup1
            ' 
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.navigateViewBackwardItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.navigateViewForwardItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.gotoTodayItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.viewZoomInItem1)
            Me.navigatorRibbonPageGroup1.ItemLinks.Add(Me.viewZoomOutItem1)
            Me.navigatorRibbonPageGroup1.Name = "navigatorRibbonPageGroup1"
            ' 
            ' arrangeRibbonPageGroup1
            ' 
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToDayViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToWorkWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToFullWeekViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToGanttViewItem1)
            Me.arrangeRibbonPageGroup1.ItemLinks.Add(Me.switchToAgendaViewItem1)
            Me.arrangeRibbonPageGroup1.Name = "arrangeRibbonPageGroup1"
            ' 
            ' groupByRibbonPageGroup1
            ' 
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByNoneItem1)
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByDateItem1)
            Me.groupByRibbonPageGroup1.ItemLinks.Add(Me.groupByResourceItem1)
            Me.groupByRibbonPageGroup1.Name = "groupByRibbonPageGroup1"
            ' 
            ' viewRibbonPage1
            ' 
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.activeViewRibbonPageGroup1, Me.timeScaleRibbonPageGroup1, Me.layoutRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            ' 
            ' activeViewRibbonPageGroup1
            ' 
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToDayViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWorkWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToFullWeekViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToMonthViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToTimelineViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToGanttViewItem1)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.switchToAgendaViewItem1)
            Me.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1"
            ' 
            ' timeScaleRibbonPageGroup1
            ' 
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesItem1)
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.changeScaleWidthItem1)
            Me.timeScaleRibbonPageGroup1.ItemLinks.Add(Me.switchTimeScalesCaptionItem1)
            Me.timeScaleRibbonPageGroup1.Name = "timeScaleRibbonPageGroup1"
            ' 
            ' layoutRibbonPageGroup1
            ' 
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCompressWeekendItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.switchCellsAutoHeightItem1)
            Me.layoutRibbonPageGroup1.ItemLinks.Add(Me.changeSnapToCellsUIItem1)
            Me.layoutRibbonPageGroup1.Name = "layoutRibbonPageGroup1"
            ' 
            ' ribbonPageSkins
            ' 
            Me.ribbonPageSkins.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.skinsRibbonPageGroup, Me.ribbonPageGroup2})
            Me.ribbonPageSkins.Name = "ribbonPageSkins"
            Me.ribbonPageSkins.Text = "Skins"
            ' 
            ' skinsRibbonPageGroup
            ' 
            Me.skinsRibbonPageGroup.ItemLinks.Add(Me.rgbiSkins)
            Me.skinsRibbonPageGroup.Name = "skinsRibbonPageGroup"
            Me.skinsRibbonPageGroup.ShowCaptionButton = False
            Me.skinsRibbonPageGroup.Text = "Skins"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.ItemLinks.Add(Me.skinPaletteRibbonGalleryBarItem1)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "ribbonPageGroup2"
            ' 
            ' helpRibbonPage
            ' 
            Me.helpRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.helpRibbonPageGroup})
            Me.helpRibbonPage.Name = "helpRibbonPage"
            Me.helpRibbonPage.Text = "Help"
            ' 
            ' helpRibbonPageGroup
            ' 
            Me.helpRibbonPageGroup.ItemLinks.Add(Me.iHelp)
            Me.helpRibbonPageGroup.ItemLinks.Add(Me.iAbout)
            Me.helpRibbonPageGroup.Name = "helpRibbonPageGroup"
            Me.helpRibbonPageGroup.Text = "Help"
            ' 
            ' ribbonStatusBar
            ' 
            Me.ribbonStatusBar.ItemLinks.Add(Me.siStatus)
            Me.ribbonStatusBar.ItemLinks.Add(Me.siInfo)
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 674)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(1100, 26)
            ' 
            ' schedulerBarController1
            ' 
            Me.schedulerBarController1.BarItems.Add(Me.editAppointmentQueryItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editOccurrenceUICommandItem1)
            Me.schedulerBarController1.BarItems.Add(Me.editSeriesUICommandItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteAppointmentsItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteOccurrenceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.deleteSeriesItem1)
            Me.schedulerBarController1.BarItems.Add(Me.splitAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentStatusItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentLabelItem1)
            Me.schedulerBarController1.BarItems.Add(Me.toggleRecurrenceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeAppointmentReminderItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToDayViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWorkWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToFullWeekViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToMonthViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToTimelineViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToGanttViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchToAgendaViewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeScaleWidthItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchTimeScalesCaptionItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchCompressWeekendItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchShowWorkTimeOnlyItem1)
            Me.schedulerBarController1.BarItems.Add(Me.switchCellsAutoHeightItem1)
            Me.schedulerBarController1.BarItems.Add(Me.changeSnapToCellsUIItem1)
            Me.schedulerBarController1.BarItems.Add(Me.newAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.newRecurringAppointmentItem1)
            Me.schedulerBarController1.BarItems.Add(Me.navigateViewBackwardItem1)
            Me.schedulerBarController1.BarItems.Add(Me.navigateViewForwardItem1)
            Me.schedulerBarController1.BarItems.Add(Me.gotoTodayItem1)
            Me.schedulerBarController1.BarItems.Add(Me.viewZoomInItem1)
            Me.schedulerBarController1.BarItems.Add(Me.viewZoomOutItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByNoneItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByDateItem1)
            Me.schedulerBarController1.BarItems.Add(Me.groupByResourceItem1)
            Me.schedulerBarController1.BarItems.Add(Me.openScheduleItem1)
            Me.schedulerBarController1.BarItems.Add(Me.saveScheduleItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printItem1)
            Me.schedulerBarController1.BarItems.Add(Me.printPageSetupItem1)
            Me.schedulerBarController1.Control = Me.schedulerControl
            ' 
            ' gcSyncComponent
            ' 
            Me.gcSyncComponent.CalendarId = Nothing
            Me.gcSyncComponent.CalendarService = Nothing
            Me.gcSyncComponent.StateTrackingMode = DevExpress.XtraScheduler.GoogleCalendar.StateTrackingMode.Manual
            Me.gcSyncComponent.Storage = Nothing
            ' 
            ' Form1
            ' 
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1100, 700)
            Me.Controls.Add(Me.splitContainerControl)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.popupControlContainer2)
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.Controls.Add(Me.ribbonControl)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl
            Me.StatusBar = Me.ribbonStatusBar
            Me.Text = "Form1"
            CType(Me.splitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl.ResumeLayout(False)
            CType(Me.navBarControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navbarImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.navbarImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerSplitContainerControl.ResumeLayout(False)
            CType(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateNavigator.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateNavigator, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.appMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupControlContainer2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer2.ResumeLayout(False)
            CType(Me.buttonEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            Me.popupControlContainer1.PerformLayout()
            CType(Me.ribbonImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ricbCalendarList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ribbonImageCollectionLarge, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private splitContainerControl As DevExpress.XtraEditors.SplitContainerControl
        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
        Private iExit As DevExpress.XtraBars.BarButtonItem
        Private iHelp As DevExpress.XtraBars.BarButtonItem
        Private iAbout As DevExpress.XtraBars.BarButtonItem
        Private siStatus As DevExpress.XtraBars.BarStaticItem
        Private siInfo As DevExpress.XtraBars.BarStaticItem
        Private rgbiSkins As DevExpress.XtraBars.RibbonGalleryBarItem
        Private ribbonPageSkins As DevExpress.XtraBars.Ribbon.RibbonPage
        Private skinsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private helpRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
        Private helpRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private appMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
        Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
        Private someLabelControl2 As DevExpress.XtraEditors.LabelControl
        Private someLabelControl1 As DevExpress.XtraEditors.LabelControl
        Private popupControlContainer2 As DevExpress.XtraBars.PopupControlContainer
        Private buttonEdit As DevExpress.XtraEditors.ButtonEdit
        Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Private ribbonImageCollection As DevExpress.Utils.ImageCollection
        Private ribbonImageCollectionLarge As DevExpress.Utils.ImageCollection
        Private navBarControl As DevExpress.XtraNavBar.NavBarControl
        Private mailGroup As DevExpress.XtraNavBar.NavBarGroup
        Private organizerGroup As DevExpress.XtraNavBar.NavBarGroup
        Private inboxItem As DevExpress.XtraNavBar.NavBarItem
        Private outboxItem As DevExpress.XtraNavBar.NavBarItem
        Private draftsItem As DevExpress.XtraNavBar.NavBarItem
        Private trashItem As DevExpress.XtraNavBar.NavBarItem
        Private calendarItem As DevExpress.XtraNavBar.NavBarItem
        Private tasksItem As DevExpress.XtraNavBar.NavBarItem
        Private navbarImageCollection As DevExpress.Utils.ImageCollection
        Private navbarImageCollectionLarge As DevExpress.Utils.ImageCollection
        Private schedulerSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl
        Private dateNavigator As DevExpress.XtraScheduler.DateNavigator
        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerDataStorage
        Private editAppointmentQueryItem1 As DevExpress.XtraScheduler.UI.EditAppointmentQueryItem
        Private editOccurrenceUICommandItem1 As DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem
        Private editSeriesUICommandItem1 As DevExpress.XtraScheduler.UI.EditSeriesUICommandItem
        Private deleteAppointmentsItem1 As DevExpress.XtraScheduler.UI.DeleteAppointmentsItem
        Private deleteOccurrenceItem1 As DevExpress.XtraScheduler.UI.DeleteOccurrenceItem
        Private deleteSeriesItem1 As DevExpress.XtraScheduler.UI.DeleteSeriesItem
        Private splitAppointmentItem1 As DevExpress.XtraScheduler.UI.SplitAppointmentItem
        Private changeAppointmentStatusItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem
        Private changeAppointmentLabelItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem
        Private toggleRecurrenceItem1 As DevExpress.XtraScheduler.UI.ToggleRecurrenceItem
        Private changeAppointmentReminderItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem
        Private repositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration
        Private switchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem
        Private switchToWorkWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem
        Private switchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem
        Private switchToFullWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem
        Private switchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem
        Private switchToTimelineViewItem1 As DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem
        Private switchToGanttViewItem1 As DevExpress.XtraScheduler.UI.SwitchToGanttViewItem
        Private switchToAgendaViewItem1 As DevExpress.XtraScheduler.UI.SwitchToAgendaViewItem
        Private switchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem
        Private changeScaleWidthItem1 As DevExpress.XtraScheduler.UI.ChangeScaleWidthItem
        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Private switchTimeScalesCaptionItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem
        Private switchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem
        Private switchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem
        Private switchCellsAutoHeightItem1 As DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem
        Private changeSnapToCellsUIItem1 As DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem
        Private newAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem
        Private newRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem
        Private navigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem
        Private navigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem
        Private gotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem
        Private viewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem
        Private viewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem
        Private groupByNoneItem1 As DevExpress.XtraScheduler.UI.GroupByNoneItem
        Private groupByDateItem1 As DevExpress.XtraScheduler.UI.GroupByDateItem
        Private groupByResourceItem1 As DevExpress.XtraScheduler.UI.GroupByResourceItem
        Private openScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem
        Private saveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem
        Private printPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem
        Private printItem1 As DevExpress.XtraScheduler.UI.PrintItem
        Private printPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem
        Private calendarToolsRibbonPageCategory1 As DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory
        Private appointmentRibbonPage1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPage
        Private actionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActionsRibbonPageGroup
        Private optionsRibbonPageGroup1 As DevExpress.XtraScheduler.UI.OptionsRibbonPageGroup
        Private fileRibbonPage1 As DevExpress.XtraScheduler.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraScheduler.UI.CommonRibbonPageGroup
        Private printRibbonPageGroup1 As DevExpress.XtraScheduler.UI.PrintRibbonPageGroup
        Private homeRibbonPage1 As DevExpress.XtraScheduler.UI.HomeRibbonPage
        Private appointmentRibbonPageGroup1 As DevExpress.XtraScheduler.UI.AppointmentRibbonPageGroup
        Private navigatorRibbonPageGroup1 As DevExpress.XtraScheduler.UI.NavigatorRibbonPageGroup
        Private arrangeRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ArrangeRibbonPageGroup
        Private groupByRibbonPageGroup1 As DevExpress.XtraScheduler.UI.GroupByRibbonPageGroup
        Private viewRibbonPage1 As DevExpress.XtraScheduler.UI.ViewRibbonPage
        Private activeViewRibbonPageGroup1 As DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup
        Private timeScaleRibbonPageGroup1 As DevExpress.XtraScheduler.UI.TimeScaleRibbonPageGroup
        Private layoutRibbonPageGroup1 As DevExpress.XtraScheduler.UI.LayoutRibbonPageGroup
        Private schedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
        Private beiCalendarList As DevExpress.XtraBars.BarEditItem
        Private ricbCalendarList As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private bbiSynchronize As DevExpress.XtraBars.BarButtonItem
        Private skinPaletteRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private gcSyncComponent As DevExpress.XtraScheduler.GoogleCalendar.DXGoogleCalendarSync
    End Class
End Namespace
