<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 15.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 12.0R)
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 3.0R)
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.pnlDashboardView = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chartRoomOverview = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvTodaysSchedule = New System.Windows.Forms.DataGridView()
        Me.pnlConflicts = New System.Windows.Forms.Panel()
        Me.lblConflictsCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.picConflicts = New System.Windows.Forms.PictureBox()
        Me.pnlOccupied = New System.Windows.Forms.Panel()
        Me.lblOccupiedCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.picOccupied = New System.Windows.Forms.PictureBox()
        Me.pnlAvailable = New System.Windows.Forms.Panel()
        Me.lblAvailableCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picAvailable = New System.Windows.Forms.PictureBox()
        Me.pnlTotalRooms = New System.Windows.Forms.Panel()
        Me.lblTotalRoomsCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picTotalRooms = New System.Windows.Forms.PictureBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblWelcomeUser = New System.Windows.Forms.Label()
        Me.pnlScheduleContainer = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnViewAll = New System.Windows.Forms.LinkLabel()
        Me.pnlChartContainer = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlScheduleView = New System.Windows.Forms.Panel()
        Me.lblTime1 = New System.Windows.Forms.Label()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.pnlCheckbox = New System.Windows.Forms.Panel()
        Me.chkMySchedule = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.pnlDropRoom = New System.Windows.Forms.Panel()
        Me.cmbRoomFilter = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlDate = New System.Windows.Forms.Panel()
        Me.cmbDayFilter = New System.Windows.Forms.ComboBox()
        Me.pnlSearchContainer = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtSearchSchedule = New System.Windows.Forms.TextBox()
        Me.pnlAddSched = New System.Windows.Forms.Panel()
        Me.btnAddSched = New System.Windows.Forms.Button()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.pnlSchedMan = New System.Windows.Forms.Panel()
        Me.pnlRoomsView = New System.Windows.Forms.Panel()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlSearchRoomContainer = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.txtSearchRoom = New System.Windows.Forms.TextBox()
        Me.pnlAddRoom = New System.Windows.Forms.Panel()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.pnlRoomManagement = New System.Windows.Forms.Panel()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.pnlAvailabilityView = New System.Windows.Forms.Panel()
        Me.lblTime3 = New System.Windows.Forms.Label()
        Me.lblDate3 = New System.Windows.Forms.Label()
        Me.dgvAvailability = New System.Windows.Forms.DataGridView()
        Me.pnlRoomType = New System.Windows.Forms.Panel()
        Me.cmbFilterRoom = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pnlDay = New System.Windows.Forms.Panel()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.txtSearchAvailability = New System.Windows.Forms.TextBox()
        Me.pnlClassroomAvail = New System.Windows.Forms.Panel()
        Me.picAvailRefresh = New System.Windows.Forms.PictureBox()
        Me.pnlConflictsView = New System.Windows.Forms.Panel()
        Me.pnlAllDates = New System.Windows.Forms.Panel()
        Me.chkAllLogs = New System.Windows.Forms.CheckBox()
        Me.pnlSearchConflicts = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearchConflicts = New System.Windows.Forms.TextBox()
        Me.pnlDatePickerLogs = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnToggleView = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlSchedConflicts = New System.Windows.Forms.Panel()
        Me.dgvConflicts = New System.Windows.Forms.DataGridView()
        Me.dgvLogs = New System.Windows.Forms.DataGridView()
        Me.pnlSwitch = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAccount = New System.Windows.Forms.ToolStripSplitButton()
        Me.ManageAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNav = New System.Windows.Forms.ToolStripSplitButton()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AvailabilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConflictsLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConflictsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.picLogout = New System.Windows.Forms.PictureBox()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Toggle1 = New prjSchedMoni.Toggle()
        Me.btnConflicts = New System.Windows.Forms.Button()
        Me.btnAvailability = New System.Windows.Forms.Button()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlUserProfileCard = New System.Windows.Forms.Panel()
        Me.pictureBoxUserManagement = New System.Windows.Forms.PictureBox()
        Me.picUserProfile = New System.Windows.Forms.PictureBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnlDashboardView.SuspendLayout()
        CType(Me.chartRoomOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTodaysSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConflicts.SuspendLayout()
        CType(Me.picConflicts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOccupied.SuspendLayout()
        CType(Me.picOccupied, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAvailable.SuspendLayout()
        CType(Me.picAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotalRooms.SuspendLayout()
        CType(Me.picTotalRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlScheduleContainer.SuspendLayout()
        Me.pnlChartContainer.SuspendLayout()
        Me.pnlScheduleView.SuspendLayout()
        Me.pnlCheckbox.SuspendLayout()
        Me.pnlDropRoom.SuspendLayout()
        Me.pnlDate.SuspendLayout()
        Me.pnlSearchContainer.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddSched.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRoomsView.SuspendLayout()
        Me.pnlSearchRoomContainer.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddRoom.SuspendLayout()
        Me.pnlRoomManagement.SuspendLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAvailabilityView.SuspendLayout()
        CType(Me.dgvAvailability, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRoomType.SuspendLayout()
        Me.pnlDay.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlClassroomAvail.SuspendLayout()
        CType(Me.picAvailRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConflictsView.SuspendLayout()
        Me.pnlAllDates.SuspendLayout()
        Me.pnlSearchConflicts.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDatePickerLogs.SuspendLayout()
        Me.pnlSchedConflicts.SuspendLayout()
        CType(Me.dgvConflicts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUserProfileCard.SuspendLayout()
        CType(Me.pictureBoxUserManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUserProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDashboardView
        '
        Me.pnlDashboardView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDashboardView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlDashboardView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDashboardView.Controls.Add(Me.lblTime)
        Me.pnlDashboardView.Controls.Add(Me.Label6)
        Me.pnlDashboardView.Controls.Add(Me.chartRoomOverview)
        Me.pnlDashboardView.Controls.Add(Me.dgvTodaysSchedule)
        Me.pnlDashboardView.Controls.Add(Me.pnlConflicts)
        Me.pnlDashboardView.Controls.Add(Me.pnlOccupied)
        Me.pnlDashboardView.Controls.Add(Me.pnlAvailable)
        Me.pnlDashboardView.Controls.Add(Me.pnlTotalRooms)
        Me.pnlDashboardView.Controls.Add(Me.lblDate)
        Me.pnlDashboardView.Controls.Add(Me.lblWelcomeUser)
        Me.pnlDashboardView.Controls.Add(Me.pnlScheduleContainer)
        Me.pnlDashboardView.Controls.Add(Me.pnlChartContainer)
        Me.pnlDashboardView.Location = New System.Drawing.Point(312, 26)
        Me.pnlDashboardView.Name = "pnlDashboardView"
        Me.pnlDashboardView.Size = New System.Drawing.Size(1608, 1025)
        Me.pnlDashboardView.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(1440, 18)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(106, 30)
        Me.lblTime.TabIndex = 26
        Me.lblTime.Text = "12:30 PM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(27, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(329, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Here's an overview of the classrooms today."
        '
        'chartRoomOverview
        '
        Me.chartRoomOverview.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chartRoomOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.chartRoomOverview.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend1"
        Me.chartRoomOverview.Legends.Add(Legend1)
        Me.chartRoomOverview.Location = New System.Drawing.Point(1208, 365)
        Me.chartRoomOverview.Name = "chartRoomOverview"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        DataPoint1.AxisLabel = "Occupied"
        DataPoint1.Color = System.Drawing.Color.Tomato
        DataPoint2.AxisLabel = "Available"
        DataPoint2.Color = System.Drawing.Color.PaleGreen
        DataPoint3.AxisLabel = "Conflict"
        DataPoint3.Color = System.Drawing.Color.Orange
        Series1.Points.Add(DataPoint1)
        Series1.Points.Add(DataPoint2)
        Series1.Points.Add(DataPoint3)
        Me.chartRoomOverview.Series.Add(Series1)
        Me.chartRoomOverview.Size = New System.Drawing.Size(380, 625)
        Me.chartRoomOverview.TabIndex = 20
        Me.chartRoomOverview.Text = "Chart1"
        '
        'dgvTodaysSchedule
        '
        Me.dgvTodaysSchedule.AllowUserToAddRows = False
        Me.dgvTodaysSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodaysSchedule.BackgroundColor = System.Drawing.Color.White
        Me.dgvTodaysSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodaysSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTodaysSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodaysSchedule.EnableHeadersVisualStyles = False
        Me.dgvTodaysSchedule.Location = New System.Drawing.Point(28, 365)
        Me.dgvTodaysSchedule.Name = "dgvTodaysSchedule"
        Me.dgvTodaysSchedule.ReadOnly = True
        Me.dgvTodaysSchedule.RowHeadersVisible = False
        Me.dgvTodaysSchedule.Size = New System.Drawing.Size(1156, 625)
        Me.dgvTodaysSchedule.TabIndex = 19
        '
        'pnlConflicts
        '
        Me.pnlConflicts.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlConflicts.Controls.Add(Me.lblConflictsCount)
        Me.pnlConflicts.Controls.Add(Me.Label7)
        Me.pnlConflicts.Controls.Add(Me.picConflicts)
        Me.pnlConflicts.Location = New System.Drawing.Point(1207, 112)
        Me.pnlConflicts.Name = "pnlConflicts"
        Me.pnlConflicts.Size = New System.Drawing.Size(380, 200)
        Me.pnlConflicts.TabIndex = 18
        '
        'lblConflictsCount
        '
        Me.lblConflictsCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConflictsCount.Location = New System.Drawing.Point(105, 154)
        Me.lblConflictsCount.Name = "lblConflictsCount"
        Me.lblConflictsCount.Size = New System.Drawing.Size(170, 45)
        Me.lblConflictsCount.TabIndex = 17
        Me.lblConflictsCount.Text = "0"
        Me.lblConflictsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(105, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Conflicts"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picConflicts
        '
        Me.picConflicts.Image = Global.prjSchedMoni.My.Resources.Resources.sync2
        Me.picConflicts.Location = New System.Drawing.Point(140, 20)
        Me.picConflicts.Name = "picConflicts"
        Me.picConflicts.Size = New System.Drawing.Size(100, 100)
        Me.picConflicts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picConflicts.TabIndex = 15
        Me.picConflicts.TabStop = False
        '
        'pnlOccupied
        '
        Me.pnlOccupied.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlOccupied.Controls.Add(Me.lblOccupiedCount)
        Me.pnlOccupied.Controls.Add(Me.Label5)
        Me.pnlOccupied.Controls.Add(Me.picOccupied)
        Me.pnlOccupied.Location = New System.Drawing.Point(813, 112)
        Me.pnlOccupied.Name = "pnlOccupied"
        Me.pnlOccupied.Size = New System.Drawing.Size(380, 200)
        Me.pnlOccupied.TabIndex = 18
        '
        'lblOccupiedCount
        '
        Me.lblOccupiedCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupiedCount.Location = New System.Drawing.Point(105, 154)
        Me.lblOccupiedCount.Name = "lblOccupiedCount"
        Me.lblOccupiedCount.Size = New System.Drawing.Size(170, 45)
        Me.lblOccupiedCount.TabIndex = 17
        Me.lblOccupiedCount.Text = "0"
        Me.lblOccupiedCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(105, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Occupied"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picOccupied
        '
        Me.picOccupied.Image = Global.prjSchedMoni.My.Resources.Resources.calendar1
        Me.picOccupied.Location = New System.Drawing.Point(140, 20)
        Me.picOccupied.Name = "picOccupied"
        Me.picOccupied.Size = New System.Drawing.Size(100, 100)
        Me.picOccupied.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOccupied.TabIndex = 15
        Me.picOccupied.TabStop = False
        '
        'pnlAvailable
        '
        Me.pnlAvailable.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlAvailable.Controls.Add(Me.lblAvailableCount)
        Me.pnlAvailable.Controls.Add(Me.Label3)
        Me.pnlAvailable.Controls.Add(Me.picAvailable)
        Me.pnlAvailable.Location = New System.Drawing.Point(419, 113)
        Me.pnlAvailable.Name = "pnlAvailable"
        Me.pnlAvailable.Size = New System.Drawing.Size(380, 200)
        Me.pnlAvailable.TabIndex = 18
        '
        'lblAvailableCount
        '
        Me.lblAvailableCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableCount.Location = New System.Drawing.Point(105, 154)
        Me.lblAvailableCount.Name = "lblAvailableCount"
        Me.lblAvailableCount.Size = New System.Drawing.Size(170, 45)
        Me.lblAvailableCount.TabIndex = 17
        Me.lblAvailableCount.Text = "0"
        Me.lblAvailableCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(105, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Available"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picAvailable
        '
        Me.picAvailable.Image = Global.prjSchedMoni.My.Resources.Resources.checked
        Me.picAvailable.Location = New System.Drawing.Point(140, 20)
        Me.picAvailable.Name = "picAvailable"
        Me.picAvailable.Size = New System.Drawing.Size(100, 100)
        Me.picAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAvailable.TabIndex = 15
        Me.picAvailable.TabStop = False
        '
        'pnlTotalRooms
        '
        Me.pnlTotalRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlTotalRooms.Controls.Add(Me.lblTotalRoomsCount)
        Me.pnlTotalRooms.Controls.Add(Me.Label1)
        Me.pnlTotalRooms.Controls.Add(Me.picTotalRooms)
        Me.pnlTotalRooms.Location = New System.Drawing.Point(25, 113)
        Me.pnlTotalRooms.Name = "pnlTotalRooms"
        Me.pnlTotalRooms.Size = New System.Drawing.Size(380, 200)
        Me.pnlTotalRooms.TabIndex = 11
        '
        'lblTotalRoomsCount
        '
        Me.lblTotalRoomsCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRoomsCount.Location = New System.Drawing.Point(105, 154)
        Me.lblTotalRoomsCount.Name = "lblTotalRoomsCount"
        Me.lblTotalRoomsCount.Size = New System.Drawing.Size(170, 45)
        Me.lblTotalRoomsCount.TabIndex = 17
        Me.lblTotalRoomsCount.Text = "0"
        Me.lblTotalRoomsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Total Rooms"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picTotalRooms
        '
        Me.picTotalRooms.Image = Global.prjSchedMoni.My.Resources.Resources.rooms
        Me.picTotalRooms.Location = New System.Drawing.Point(140, 20)
        Me.picTotalRooms.Name = "picTotalRooms"
        Me.picTotalRooms.Size = New System.Drawing.Size(100, 100)
        Me.picTotalRooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTotalRooms.TabIndex = 15
        Me.picTotalRooms.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(1439, 48)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(125, 34)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "September 15, 2026" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tuesday"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcomeUser
        '
        Me.lblWelcomeUser.AutoSize = True
        Me.lblWelcomeUser.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblWelcomeUser.Location = New System.Drawing.Point(26, 30)
        Me.lblWelcomeUser.Name = "lblWelcomeUser"
        Me.lblWelcomeUser.Size = New System.Drawing.Size(188, 32)
        Me.lblWelcomeUser.TabIndex = 9
        Me.lblWelcomeUser.Text = "Welcome Back!"
        '
        'pnlScheduleContainer
        '
        Me.pnlScheduleContainer.BackColor = System.Drawing.Color.Gray
        Me.pnlScheduleContainer.Controls.Add(Me.Label2)
        Me.pnlScheduleContainer.Controls.Add(Me.btnViewAll)
        Me.pnlScheduleContainer.Location = New System.Drawing.Point(25, 337)
        Me.pnlScheduleContainer.Name = "pnlScheduleContainer"
        Me.pnlScheduleContainer.Size = New System.Drawing.Size(1162, 672)
        Me.pnlScheduleContainer.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Today's Schedule"
        '
        'btnViewAll
        '
        Me.btnViewAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewAll.AutoSize = True
        Me.btnViewAll.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.LinkColor = System.Drawing.Color.Black
        Me.btnViewAll.Location = New System.Drawing.Point(1106, 7)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(53, 17)
        Me.btnViewAll.TabIndex = 0
        Me.btnViewAll.TabStop = True
        Me.btnViewAll.Text = "View All"
        '
        'pnlChartContainer
        '
        Me.pnlChartContainer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlChartContainer.BackColor = System.Drawing.Color.Gray
        Me.pnlChartContainer.Controls.Add(Me.Label4)
        Me.pnlChartContainer.Location = New System.Drawing.Point(1205, 337)
        Me.pnlChartContainer.Name = "pnlChartContainer"
        Me.pnlChartContainer.Size = New System.Drawing.Size(386, 672)
        Me.pnlChartContainer.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 21)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Room Status Overview"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'pnlScheduleView
        '
        Me.pnlScheduleView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlScheduleView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlScheduleView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlScheduleView.Controls.Add(Me.lblTime1)
        Me.pnlScheduleView.Controls.Add(Me.lblDate1)
        Me.pnlScheduleView.Controls.Add(Me.pnlCheckbox)
        Me.pnlScheduleView.Controls.Add(Me.Label11)
        Me.pnlScheduleView.Controls.Add(Me.pnlDropRoom)
        Me.pnlScheduleView.Controls.Add(Me.Label10)
        Me.pnlScheduleView.Controls.Add(Me.Label8)
        Me.pnlScheduleView.Controls.Add(Me.Label9)
        Me.pnlScheduleView.Controls.Add(Me.pnlDate)
        Me.pnlScheduleView.Controls.Add(Me.pnlSearchContainer)
        Me.pnlScheduleView.Controls.Add(Me.pnlAddSched)
        Me.pnlScheduleView.Controls.Add(Me.dgvSchedule)
        Me.pnlScheduleView.Controls.Add(Me.pnlSchedMan)
        Me.pnlScheduleView.Location = New System.Drawing.Point(312, 26)
        Me.pnlScheduleView.Name = "pnlScheduleView"
        Me.pnlScheduleView.Size = New System.Drawing.Size(1608, 1025)
        Me.pnlScheduleView.TabIndex = 25
        '
        'lblTime1
        '
        Me.lblTime1.AutoSize = True
        Me.lblTime1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTime1.Location = New System.Drawing.Point(1440, 18)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(106, 30)
        Me.lblTime1.TabIndex = 38
        Me.lblTime1.Text = "12:30 PM"
        Me.lblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblDate1.Location = New System.Drawing.Point(1439, 48)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(125, 34)
        Me.lblDate1.TabIndex = 37
        Me.lblDate1.Text = "September 15, 2026" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tuesday"
        Me.lblDate1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCheckbox
        '
        Me.pnlCheckbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlCheckbox.Controls.Add(Me.chkMySchedule)
        Me.pnlCheckbox.Location = New System.Drawing.Point(1224, 186)
        Me.pnlCheckbox.Name = "pnlCheckbox"
        Me.pnlCheckbox.Size = New System.Drawing.Size(175, 42)
        Me.pnlCheckbox.TabIndex = 35
        '
        'chkMySchedule
        '
        Me.chkMySchedule.AutoSize = True
        Me.chkMySchedule.BackColor = System.Drawing.Color.Transparent
        Me.chkMySchedule.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkMySchedule.Location = New System.Drawing.Point(33, 10)
        Me.chkMySchedule.Name = "chkMySchedule"
        Me.chkMySchedule.Size = New System.Drawing.Size(127, 25)
        Me.chkMySchedule.TabIndex = 37
        Me.chkMySchedule.Text = "My Schedule"
        Me.chkMySchedule.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(379, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 25)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Room:"
        '
        'pnlDropRoom
        '
        Me.pnlDropRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlDropRoom.Controls.Add(Me.cmbRoomFilter)
        Me.pnlDropRoom.Location = New System.Drawing.Point(450, 111)
        Me.pnlDropRoom.Name = "pnlDropRoom"
        Me.pnlDropRoom.Size = New System.Drawing.Size(178, 43)
        Me.pnlDropRoom.TabIndex = 32
        '
        'cmbRoomFilter
        '
        Me.cmbRoomFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cmbRoomFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRoomFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRoomFilter.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbRoomFilter.ForeColor = System.Drawing.Color.Black
        Me.cmbRoomFilter.FormattingEnabled = True
        Me.cmbRoomFilter.Location = New System.Drawing.Point(3, 8)
        Me.cmbRoomFilter.Name = "cmbRoomFilter"
        Me.cmbRoomFilter.Size = New System.Drawing.Size(172, 28)
        Me.cmbRoomFilter.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(28, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 25)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Day:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(26, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(320, 21)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Add, edit, or remove classroom schedules."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(26, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(339, 32)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Class Schedule Management"
        '
        'pnlDate
        '
        Me.pnlDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlDate.Controls.Add(Me.cmbDayFilter)
        Me.pnlDate.Location = New System.Drawing.Point(92, 111)
        Me.pnlDate.Name = "pnlDate"
        Me.pnlDate.Size = New System.Drawing.Size(256, 43)
        Me.pnlDate.TabIndex = 29
        '
        'cmbDayFilter
        '
        Me.cmbDayFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cmbDayFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDayFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDayFilter.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbDayFilter.ForeColor = System.Drawing.Color.Black
        Me.cmbDayFilter.FormattingEnabled = True
        Me.cmbDayFilter.Location = New System.Drawing.Point(8, 8)
        Me.cmbDayFilter.Name = "cmbDayFilter"
        Me.cmbDayFilter.Size = New System.Drawing.Size(235, 28)
        Me.cmbDayFilter.TabIndex = 34
        '
        'pnlSearchContainer
        '
        Me.pnlSearchContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlSearchContainer.Controls.Add(Me.PictureBox5)
        Me.pnlSearchContainer.Controls.Add(Me.txtSearchSchedule)
        Me.pnlSearchContainer.Location = New System.Drawing.Point(30, 186)
        Me.pnlSearchContainer.Name = "pnlSearchContainer"
        Me.pnlSearchContainer.Size = New System.Drawing.Size(749, 42)
        Me.pnlSearchContainer.TabIndex = 30
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.prjSchedMoni.My.Resources.Resources.loupe
        Me.PictureBox5.Location = New System.Drawing.Point(10, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'txtSearchSchedule
        '
        Me.txtSearchSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtSearchSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchSchedule.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchSchedule.Location = New System.Drawing.Point(49, 11)
        Me.txtSearchSchedule.Name = "txtSearchSchedule"
        Me.txtSearchSchedule.Size = New System.Drawing.Size(687, 22)
        Me.txtSearchSchedule.TabIndex = 0
        '
        'pnlAddSched
        '
        Me.pnlAddSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlAddSched.Controls.Add(Me.btnAddSched)
        Me.pnlAddSched.Location = New System.Drawing.Point(1408, 180)
        Me.pnlAddSched.Name = "pnlAddSched"
        Me.pnlAddSched.Size = New System.Drawing.Size(163, 52)
        Me.pnlAddSched.TabIndex = 34
        '
        'btnAddSched
        '
        Me.btnAddSched.AutoSize = True
        Me.btnAddSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnAddSched.FlatAppearance.BorderSize = 0
        Me.btnAddSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSched.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSched.Image = Global.prjSchedMoni.My.Resources.Resources.icons8_plus_241
        Me.btnAddSched.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSched.Location = New System.Drawing.Point(9, 6)
        Me.btnAddSched.Name = "btnAddSched"
        Me.btnAddSched.Size = New System.Drawing.Size(147, 41)
        Me.btnAddSched.TabIndex = 33
        Me.btnAddSched.Text = "Add Schedule"
        Me.btnAddSched.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddSched.UseVisualStyleBackColor = False
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        Me.dgvSchedule.AllowUserToResizeColumns = False
        Me.dgvSchedule.AllowUserToResizeRows = False
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSchedule.Location = New System.Drawing.Point(34, 280)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.ReadOnly = True
        Me.dgvSchedule.Size = New System.Drawing.Size(1535, 701)
        Me.dgvSchedule.TabIndex = 35
        '
        'pnlSchedMan
        '
        Me.pnlSchedMan.BackColor = System.Drawing.Color.Gray
        Me.pnlSchedMan.Location = New System.Drawing.Point(32, 244)
        Me.pnlSchedMan.Name = "pnlSchedMan"
        Me.pnlSchedMan.Size = New System.Drawing.Size(1539, 757)
        Me.pnlSchedMan.TabIndex = 36
        '
        'pnlRoomsView
        '
        Me.pnlRoomsView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlRoomsView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlRoomsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRoomsView.Controls.Add(Me.lblTime2)
        Me.pnlRoomsView.Controls.Add(Me.lblDate2)
        Me.pnlRoomsView.Controls.Add(Me.Label14)
        Me.pnlRoomsView.Controls.Add(Me.Label15)
        Me.pnlRoomsView.Controls.Add(Me.pnlSearchRoomContainer)
        Me.pnlRoomsView.Controls.Add(Me.pnlAddRoom)
        Me.pnlRoomsView.Controls.Add(Me.pnlRoomManagement)
        Me.pnlRoomsView.Location = New System.Drawing.Point(312, 26)
        Me.pnlRoomsView.Name = "pnlRoomsView"
        Me.pnlRoomsView.Size = New System.Drawing.Size(1608, 1025)
        Me.pnlRoomsView.TabIndex = 26
        '
        'lblTime2
        '
        Me.lblTime2.AutoSize = True
        Me.lblTime2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTime2.Location = New System.Drawing.Point(1440, 18)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(106, 30)
        Me.lblTime2.TabIndex = 51
        Me.lblTime2.Text = "12:30 PM"
        Me.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblDate2.Location = New System.Drawing.Point(1439, 48)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(125, 34)
        Me.lblDate2.TabIndex = 50
        Me.lblDate2.Text = "September 15, 2026" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tuesday"
        Me.lblDate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(36, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(359, 21)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "View/manage room information, capacity status"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(36, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(240, 32)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Room Management"
        '
        'pnlSearchRoomContainer
        '
        Me.pnlSearchRoomContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlSearchRoomContainer.Controls.Add(Me.PictureBox6)
        Me.pnlSearchRoomContainer.Controls.Add(Me.txtSearchRoom)
        Me.pnlSearchRoomContainer.Location = New System.Drawing.Point(40, 122)
        Me.pnlSearchRoomContainer.Name = "pnlSearchRoomContainer"
        Me.pnlSearchRoomContainer.Size = New System.Drawing.Size(725, 42)
        Me.pnlSearchRoomContainer.TabIndex = 40
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.prjSchedMoni.My.Resources.Resources.loupe
        Me.PictureBox6.Location = New System.Drawing.Point(10, 7)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 31
        Me.PictureBox6.TabStop = False
        '
        'txtSearchRoom
        '
        Me.txtSearchRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtSearchRoom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchRoom.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchRoom.Location = New System.Drawing.Point(49, 11)
        Me.txtSearchRoom.Name = "txtSearchRoom"
        Me.txtSearchRoom.Size = New System.Drawing.Size(668, 22)
        Me.txtSearchRoom.TabIndex = 0
        '
        'pnlAddRoom
        '
        Me.pnlAddRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlAddRoom.Controls.Add(Me.btnAddRoom)
        Me.pnlAddRoom.Location = New System.Drawing.Point(1417, 114)
        Me.pnlAddRoom.Name = "pnlAddRoom"
        Me.pnlAddRoom.Size = New System.Drawing.Size(163, 52)
        Me.pnlAddRoom.TabIndex = 43
        '
        'btnAddRoom
        '
        Me.btnAddRoom.AutoSize = True
        Me.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnAddRoom.FlatAppearance.BorderSize = 0
        Me.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRoom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRoom.Image = Global.prjSchedMoni.My.Resources.Resources.icons8_plus_241
        Me.btnAddRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddRoom.Location = New System.Drawing.Point(9, 6)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(147, 41)
        Me.btnAddRoom.TabIndex = 33
        Me.btnAddRoom.Text = "Add Room"
        Me.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddRoom.UseVisualStyleBackColor = False
        '
        'pnlRoomManagement
        '
        Me.pnlRoomManagement.BackColor = System.Drawing.Color.Gray
        Me.pnlRoomManagement.Controls.Add(Me.dgvRooms)
        Me.pnlRoomManagement.Location = New System.Drawing.Point(41, 180)
        Me.pnlRoomManagement.Name = "pnlRoomManagement"
        Me.pnlRoomManagement.Size = New System.Drawing.Size(1539, 829)
        Me.pnlRoomManagement.TabIndex = 49
        '
        'dgvRooms
        '
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(3, 24)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.Size = New System.Drawing.Size(1533, 786)
        Me.dgvRooms.TabIndex = 44
        '
        'pnlAvailabilityView
        '
        Me.pnlAvailabilityView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAvailabilityView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlAvailabilityView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAvailabilityView.Controls.Add(Me.lblTime3)
        Me.pnlAvailabilityView.Controls.Add(Me.lblDate3)
        Me.pnlAvailabilityView.Controls.Add(Me.dgvAvailability)
        Me.pnlAvailabilityView.Controls.Add(Me.pnlRoomType)
        Me.pnlAvailabilityView.Controls.Add(Me.Label16)
        Me.pnlAvailabilityView.Controls.Add(Me.Label17)
        Me.pnlAvailabilityView.Controls.Add(Me.pnlDay)
        Me.pnlAvailabilityView.Controls.Add(Me.pnlSearch)
        Me.pnlAvailabilityView.Controls.Add(Me.pnlClassroomAvail)
        Me.pnlAvailabilityView.Location = New System.Drawing.Point(312, 26)
        Me.pnlAvailabilityView.Name = "pnlAvailabilityView"
        Me.pnlAvailabilityView.Size = New System.Drawing.Size(1608, 1025)
        Me.pnlAvailabilityView.TabIndex = 27
        '
        'lblTime3
        '
        Me.lblTime3.AutoSize = True
        Me.lblTime3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTime3.Location = New System.Drawing.Point(1440, 18)
        Me.lblTime3.Name = "lblTime3"
        Me.lblTime3.Size = New System.Drawing.Size(106, 30)
        Me.lblTime3.TabIndex = 30
        Me.lblTime3.Text = "12:30 PM"
        Me.lblTime3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate3
        '
        Me.lblDate3.AutoSize = True
        Me.lblDate3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblDate3.Location = New System.Drawing.Point(1439, 48)
        Me.lblDate3.Name = "lblDate3"
        Me.lblDate3.Size = New System.Drawing.Size(125, 34)
        Me.lblDate3.TabIndex = 29
        Me.lblDate3.Text = "September 15, 2026" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tuesday"
        Me.lblDate3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvAvailability
        '
        Me.dgvAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvailability.Location = New System.Drawing.Point(43, 200)
        Me.dgvAvailability.Name = "dgvAvailability"
        Me.dgvAvailability.Size = New System.Drawing.Size(1519, 781)
        Me.dgvAvailability.TabIndex = 44
        '
        'pnlRoomType
        '
        Me.pnlRoomType.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlRoomType.Controls.Add(Me.cmbFilterRoom)
        Me.pnlRoomType.Location = New System.Drawing.Point(355, 109)
        Me.pnlRoomType.Name = "pnlRoomType"
        Me.pnlRoomType.Size = New System.Drawing.Size(244, 43)
        Me.pnlRoomType.TabIndex = 42
        '
        'cmbFilterRoom
        '
        Me.cmbFilterRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cmbFilterRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFilterRoom.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbFilterRoom.ForeColor = System.Drawing.Color.Black
        Me.cmbFilterRoom.FormattingEnabled = True
        Me.cmbFilterRoom.Location = New System.Drawing.Point(3, 8)
        Me.cmbFilterRoom.Name = "cmbFilterRoom"
        Me.cmbFilterRoom.Size = New System.Drawing.Size(238, 28)
        Me.cmbFilterRoom.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(36, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(212, 21)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Check status of Classrooms."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(36, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(258, 32)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Classoom Availability"
        '
        'pnlDay
        '
        Me.pnlDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlDay.Controls.Add(Me.cmbDay)
        Me.pnlDay.Location = New System.Drawing.Point(42, 109)
        Me.pnlDay.Name = "pnlDay"
        Me.pnlDay.Size = New System.Drawing.Size(293, 43)
        Me.pnlDay.TabIndex = 39
        '
        'cmbDay
        '
        Me.cmbDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDay.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbDay.ForeColor = System.Drawing.Color.Black
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(3, 8)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(287, 28)
        Me.cmbDay.TabIndex = 34
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlSearch.Controls.Add(Me.PictureBox7)
        Me.pnlSearch.Controls.Add(Me.txtSearchAvailability)
        Me.pnlSearch.Location = New System.Drawing.Point(1092, 109)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(472, 42)
        Me.pnlSearch.TabIndex = 40
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.prjSchedMoni.My.Resources.Resources.loupe
        Me.PictureBox7.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 31
        Me.PictureBox7.TabStop = False
        '
        'txtSearchAvailability
        '
        Me.txtSearchAvailability.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtSearchAvailability.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchAvailability.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAvailability.Location = New System.Drawing.Point(49, 11)
        Me.txtSearchAvailability.Name = "txtSearchAvailability"
        Me.txtSearchAvailability.Size = New System.Drawing.Size(416, 22)
        Me.txtSearchAvailability.TabIndex = 0
        '
        'pnlClassroomAvail
        '
        Me.pnlClassroomAvail.BackColor = System.Drawing.Color.Gray
        Me.pnlClassroomAvail.Controls.Add(Me.picAvailRefresh)
        Me.pnlClassroomAvail.Location = New System.Drawing.Point(40, 163)
        Me.pnlClassroomAvail.Name = "pnlClassroomAvail"
        Me.pnlClassroomAvail.Size = New System.Drawing.Size(1524, 838)
        Me.pnlClassroomAvail.TabIndex = 45
        '
        'picAvailRefresh
        '
        Me.picAvailRefresh.Image = Global.prjSchedMoni.My.Resources.Resources.icons8refresh
        Me.picAvailRefresh.Location = New System.Drawing.Point(1490, 5)
        Me.picAvailRefresh.Name = "picAvailRefresh"
        Me.picAvailRefresh.Size = New System.Drawing.Size(27, 26)
        Me.picAvailRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAvailRefresh.TabIndex = 3
        Me.picAvailRefresh.TabStop = False
        '
        'pnlConflictsView
        '
        Me.pnlConflictsView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlConflictsView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlConflictsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlConflictsView.Controls.Add(Me.pnlAllDates)
        Me.pnlConflictsView.Controls.Add(Me.pnlSearchConflicts)
        Me.pnlConflictsView.Controls.Add(Me.pnlDatePickerLogs)
        Me.pnlConflictsView.Controls.Add(Me.btnToggleView)
        Me.pnlConflictsView.Controls.Add(Me.Label12)
        Me.pnlConflictsView.Controls.Add(Me.Label13)
        Me.pnlConflictsView.Controls.Add(Me.pnlSchedConflicts)
        Me.pnlConflictsView.Controls.Add(Me.pnlSwitch)
        Me.pnlConflictsView.Location = New System.Drawing.Point(312, 27)
        Me.pnlConflictsView.Name = "pnlConflictsView"
        Me.pnlConflictsView.Size = New System.Drawing.Size(1608, 1024)
        Me.pnlConflictsView.TabIndex = 28
        '
        'pnlAllDates
        '
        Me.pnlAllDates.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlAllDates.Controls.Add(Me.chkAllLogs)
        Me.pnlAllDates.Location = New System.Drawing.Point(1118, 45)
        Me.pnlAllDates.Name = "pnlAllDates"
        Me.pnlAllDates.Size = New System.Drawing.Size(81, 43)
        Me.pnlAllDates.TabIndex = 53
        '
        'chkAllLogs
        '
        Me.chkAllLogs.AutoSize = True
        Me.chkAllLogs.BackColor = System.Drawing.Color.Transparent
        Me.chkAllLogs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAllLogs.Location = New System.Drawing.Point(3, 14)
        Me.chkAllLogs.Name = "chkAllLogs"
        Me.chkAllLogs.Size = New System.Drawing.Size(75, 19)
        Me.chkAllLogs.TabIndex = 0
        Me.chkAllLogs.Text = "All Dates"
        Me.chkAllLogs.UseVisualStyleBackColor = False
        '
        'pnlSearchConflicts
        '
        Me.pnlSearchConflicts.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlSearchConflicts.Controls.Add(Me.PictureBox1)
        Me.pnlSearchConflicts.Controls.Add(Me.txtSearchConflicts)
        Me.pnlSearchConflicts.Location = New System.Drawing.Point(719, 45)
        Me.pnlSearchConflicts.Name = "pnlSearchConflicts"
        Me.pnlSearchConflicts.Size = New System.Drawing.Size(393, 43)
        Me.pnlSearchConflicts.TabIndex = 52
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prjSchedMoni.My.Resources.Resources.loupe
        Me.PictureBox1.Location = New System.Drawing.Point(10, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'txtSearchConflicts
        '
        Me.txtSearchConflicts.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtSearchConflicts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchConflicts.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchConflicts.Location = New System.Drawing.Point(49, 11)
        Me.txtSearchConflicts.Name = "txtSearchConflicts"
        Me.txtSearchConflicts.Size = New System.Drawing.Size(333, 22)
        Me.txtSearchConflicts.TabIndex = 0
        '
        'pnlDatePickerLogs
        '
        Me.pnlDatePickerLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlDatePickerLogs.Controls.Add(Me.DateTimePicker2)
        Me.pnlDatePickerLogs.Location = New System.Drawing.Point(1205, 45)
        Me.pnlDatePickerLogs.Name = "pnlDatePickerLogs"
        Me.pnlDatePickerLogs.Size = New System.Drawing.Size(216, 43)
        Me.pnlDatePickerLogs.TabIndex = 50
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 12)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(204, 20)
        Me.DateTimePicker2.TabIndex = 34
        '
        'btnToggleView
        '
        Me.btnToggleView.AccessibleName = ""
        Me.btnToggleView.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnToggleView.FlatAppearance.BorderSize = 0
        Me.btnToggleView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleView.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleView.ForeColor = System.Drawing.Color.Black
        Me.btnToggleView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToggleView.Location = New System.Drawing.Point(1444, 43)
        Me.btnToggleView.Name = "btnToggleView"
        Me.btnToggleView.Size = New System.Drawing.Size(124, 45)
        Me.btnToggleView.TabIndex = 9
        Me.btnToggleView.Text = "Logs"
        Me.btnToggleView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnToggleView.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(36, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(320, 21)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "View/resolve scheduling conflicts and logs"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(36, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(302, 32)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Schedule Conflicts / Logs"
        '
        'pnlSchedConflicts
        '
        Me.pnlSchedConflicts.BackColor = System.Drawing.Color.Gray
        Me.pnlSchedConflicts.Controls.Add(Me.dgvConflicts)
        Me.pnlSchedConflicts.Controls.Add(Me.dgvLogs)
        Me.pnlSchedConflicts.Location = New System.Drawing.Point(38, 105)
        Me.pnlSchedConflicts.Name = "pnlSchedConflicts"
        Me.pnlSchedConflicts.Size = New System.Drawing.Size(1530, 895)
        Me.pnlSchedConflicts.TabIndex = 48
        '
        'dgvConflicts
        '
        Me.dgvConflicts.AllowUserToAddRows = False
        Me.dgvConflicts.AllowUserToDeleteRows = False
        Me.dgvConflicts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConflicts.Location = New System.Drawing.Point(2, 23)
        Me.dgvConflicts.Name = "dgvConflicts"
        Me.dgvConflicts.ReadOnly = True
        Me.dgvConflicts.Size = New System.Drawing.Size(1525, 852)
        Me.dgvConflicts.TabIndex = 47
        '
        'dgvLogs
        '
        Me.dgvLogs.AllowUserToAddRows = False
        Me.dgvLogs.AllowUserToDeleteRows = False
        Me.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogs.Location = New System.Drawing.Point(0, 23)
        Me.dgvLogs.Name = "dgvLogs"
        Me.dgvLogs.ReadOnly = True
        Me.dgvLogs.Size = New System.Drawing.Size(728, 547)
        Me.dgvLogs.TabIndex = 49
        Me.dgvLogs.Visible = False
        '
        'pnlSwitch
        '
        Me.pnlSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlSwitch.Location = New System.Drawing.Point(1427, 43)
        Me.pnlSwitch.Name = "pnlSwitch"
        Me.pnlSwitch.Size = New System.Drawing.Size(153, 45)
        Me.pnlSwitch.TabIndex = 51
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM. dd, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(8, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(237, 27)
        Me.DateTimePicker1.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.btnAccount, Me.ToolStripSeparator3, Me.btnNav, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1914, 25)
        Me.ToolStrip1.TabIndex = 29
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAccount
        '
        Me.btnAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageAccountsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.btnAccount.Image = Global.prjSchedMoni.My.Resources.Resources.profile
        Me.btnAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(32, 22)
        Me.btnAccount.Text = "ToolStripSplitButton1"
        '
        'ManageAccountsToolStripMenuItem
        '
        Me.ManageAccountsToolStripMenuItem.Name = "ManageAccountsToolStripMenuItem"
        Me.ManageAccountsToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ManageAccountsToolStripMenuItem.Text = "Manage (admin only)"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'btnNav
        '
        Me.btnNav.BackColor = System.Drawing.Color.Transparent
        Me.btnNav.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.ScheduleToolStripMenuItem, Me.RoomsToolStripMenuItem, Me.AvailabilToolStripMenuItem, Me.ConflictsLogsToolStripMenuItem})
        Me.btnNav.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNav.Image = Global.prjSchedMoni.My.Resources.Resources.nav_blue
        Me.btnNav.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNav.Name = "btnNav"
        Me.btnNav.Size = New System.Drawing.Size(98, 22)
        Me.btnNav.Text = "Shortcuts"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.MyScheduleToolStripMenuItem, Me.AllScheduleToolStripMenuItem})
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ScheduleToolStripMenuItem.Text = "Schedule"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'MyScheduleToolStripMenuItem
        '
        Me.MyScheduleToolStripMenuItem.Name = "MyScheduleToolStripMenuItem"
        Me.MyScheduleToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MyScheduleToolStripMenuItem.Text = "My Schedule"
        '
        'AllScheduleToolStripMenuItem
        '
        Me.AllScheduleToolStripMenuItem.Name = "AllScheduleToolStripMenuItem"
        Me.AllScheduleToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AllScheduleToolStripMenuItem.Text = "All Schedule"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1})
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RoomsToolStripMenuItem.Text = "Rooms"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(101, 22)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'AvailabilToolStripMenuItem
        '
        Me.AvailabilToolStripMenuItem.Name = "AvailabilToolStripMenuItem"
        Me.AvailabilToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.AvailabilToolStripMenuItem.Text = "Availability"
        '
        'ConflictsLogsToolStripMenuItem
        '
        Me.ConflictsLogsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConflictsToolStripMenuItem, Me.LogsToolStripMenuItem})
        Me.ConflictsLogsToolStripMenuItem.Name = "ConflictsLogsToolStripMenuItem"
        Me.ConflictsLogsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ConflictsLogsToolStripMenuItem.Text = "Conflicts/Logs"
        '
        'ConflictsToolStripMenuItem
        '
        Me.ConflictsToolStripMenuItem.Name = "ConflictsToolStripMenuItem"
        Me.ConflictsToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ConflictsToolStripMenuItem.Text = "Conflicts"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.LogsToolStripMenuItem.Text = "Logs"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlSidebar.BackColor = System.Drawing.Color.Transparent
        Me.pnlSidebar.BackgroundImage = Global.prjSchedMoni.My.Resources.Resources.bg_light_2
        Me.pnlSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSidebar.Controls.Add(Me.picLogout)
        Me.pnlSidebar.Controls.Add(Me.lblLogout)
        Me.pnlSidebar.Controls.Add(Me.Label18)
        Me.pnlSidebar.Controls.Add(Me.Toggle1)
        Me.pnlSidebar.Controls.Add(Me.btnConflicts)
        Me.pnlSidebar.Controls.Add(Me.btnAvailability)
        Me.pnlSidebar.Controls.Add(Me.btnRooms)
        Me.pnlSidebar.Controls.Add(Me.btnSchedule)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.pnlUserProfileCard)
        Me.pnlSidebar.Controls.Add(Me.ShapeContainer2)
        Me.pnlSidebar.Location = New System.Drawing.Point(-1, 26)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(315, 1025)
        Me.pnlSidebar.TabIndex = 0
        '
        'picLogout
        '
        Me.picLogout.Image = Global.prjSchedMoni.My.Resources.Resources.power_button
        Me.picLogout.Location = New System.Drawing.Point(109, 864)
        Me.picLogout.Name = "picLogout"
        Me.picLogout.Size = New System.Drawing.Size(25, 25)
        Me.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogout.TabIndex = 3
        Me.picLogout.TabStop = False
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblLogout.Location = New System.Drawing.Point(140, 866)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(64, 21)
        Me.lblLogout.TabIndex = 26
        Me.lblLogout.Text = "Logout"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(122, 957)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 21)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "☀️ / 🌙"
        '
        'Toggle1
        '
        Me.Toggle1.BackColor = System.Drawing.Color.Transparent
        Me.Toggle1.Checked = False
        Me.Toggle1.Location = New System.Drawing.Point(125, 922)
        Me.Toggle1.Name = "Toggle1"
        Me.Toggle1.Size = New System.Drawing.Size(63, 32)
        Me.Toggle1.TabIndex = 46
        '
        'btnConflicts
        '
        Me.btnConflicts.AccessibleName = ""
        Me.btnConflicts.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConflicts.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnConflicts.FlatAppearance.BorderSize = 0
        Me.btnConflicts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConflicts.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConflicts.ForeColor = System.Drawing.Color.Black
        Me.btnConflicts.Image = Global.prjSchedMoni.My.Resources.Resources.icons8_new_contact_24
        Me.btnConflicts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConflicts.Location = New System.Drawing.Point(15, 471)
        Me.btnConflicts.Name = "btnConflicts"
        Me.btnConflicts.Size = New System.Drawing.Size(280, 70)
        Me.btnConflicts.TabIndex = 7
        Me.btnConflicts.Text = "  Conflicts / Logs"
        Me.btnConflicts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConflicts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConflicts.UseVisualStyleBackColor = False
        '
        'btnAvailability
        '
        Me.btnAvailability.AccessibleName = ""
        Me.btnAvailability.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAvailability.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnAvailability.FlatAppearance.BorderSize = 0
        Me.btnAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvailability.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailability.ForeColor = System.Drawing.Color.Black
        Me.btnAvailability.Image = Global.prjSchedMoni.My.Resources.Resources.icons8_event_24
        Me.btnAvailability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvailability.Location = New System.Drawing.Point(15, 395)
        Me.btnAvailability.Name = "btnAvailability"
        Me.btnAvailability.Size = New System.Drawing.Size(280, 70)
        Me.btnAvailability.TabIndex = 6
        Me.btnAvailability.Text = "  Availability"
        Me.btnAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvailability.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAvailability.UseVisualStyleBackColor = False
        '
        'btnRooms
        '
        Me.btnRooms.AccessibleName = ""
        Me.btnRooms.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnRooms.FlatAppearance.BorderSize = 0
        Me.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRooms.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.ForeColor = System.Drawing.Color.Black
        Me.btnRooms.Image = Global.prjSchedMoni.My.Resources.Resources.icons8_room_24
        Me.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRooms.Location = New System.Drawing.Point(15, 319)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(280, 70)
        Me.btnRooms.TabIndex = 4
        Me.btnRooms.Text = "  Rooms"
        Me.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRooms.UseVisualStyleBackColor = False
        '
        'btnSchedule
        '
        Me.btnSchedule.AccessibleName = ""
        Me.btnSchedule.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnSchedule.FlatAppearance.BorderSize = 0
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.ForeColor = System.Drawing.Color.Black
        Me.btnSchedule.Image = Global.prjSchedMoni.My.Resources.Resources.icons8_clock_24
        Me.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchedule.Location = New System.Drawing.Point(15, 243)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(280, 70)
        Me.btnSchedule.TabIndex = 3
        Me.btnSchedule.Text = "  Schedule"
        Me.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.AccessibleName = ""
        Me.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.Black
        Me.btnDashboard.Image = Global.prjSchedMoni.My.Resources.Resources.icons8_dashboard_24
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(15, 167)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(280, 70)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "  Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlUserProfileCard
        '
        Me.pnlUserProfileCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlUserProfileCard.Controls.Add(Me.pictureBoxUserManagement)
        Me.pnlUserProfileCard.Controls.Add(Me.picUserProfile)
        Me.pnlUserProfileCard.Controls.Add(Me.lblUserName)
        Me.pnlUserProfileCard.Location = New System.Drawing.Point(15, 12)
        Me.pnlUserProfileCard.Name = "pnlUserProfileCard"
        Me.pnlUserProfileCard.Size = New System.Drawing.Size(280, 73)
        Me.pnlUserProfileCard.TabIndex = 5
        '
        'pictureBoxUserManagement
        '
        Me.pictureBoxUserManagement.Image = Global.prjSchedMoni.My.Resources.Resources.settings
        Me.pictureBoxUserManagement.Location = New System.Drawing.Point(255, 49)
        Me.pictureBoxUserManagement.Name = "pictureBoxUserManagement"
        Me.pictureBoxUserManagement.Size = New System.Drawing.Size(15, 15)
        Me.pictureBoxUserManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxUserManagement.TabIndex = 2
        Me.pictureBoxUserManagement.TabStop = False
        '
        'picUserProfile
        '
        Me.picUserProfile.Image = Global.prjSchedMoni.My.Resources.Resources.account1
        Me.picUserProfile.Location = New System.Drawing.Point(4, 19)
        Me.picUserProfile.Name = "picUserProfile"
        Me.picUserProfile.Size = New System.Drawing.Size(35, 35)
        Me.picUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUserProfile.TabIndex = 0
        Me.picUserProfile.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(45, 29)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(123, 17)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "John Bricks Amora"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(313, 1023)
        Me.ShapeContainer2.TabIndex = 50
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 20
        Me.LineShape1.X2 = 292
        Me.LineShape1.Y1 = 848
        Me.LineShape1.Y2 = 848
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1914, 1051)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pnlDashboardView)
        Me.Controls.Add(Me.pnlScheduleView)
        Me.Controls.Add(Me.pnlRoomsView)
        Me.Controls.Add(Me.pnlAvailabilityView)
        Me.Controls.Add(Me.pnlConflictsView)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Class Scheduling & Availability Monitoring (CSTA)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlDashboardView.ResumeLayout(False)
        Me.pnlDashboardView.PerformLayout()
        CType(Me.chartRoomOverview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTodaysSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConflicts.ResumeLayout(False)
        CType(Me.picConflicts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOccupied.ResumeLayout(False)
        CType(Me.picOccupied, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAvailable.ResumeLayout(False)
        CType(Me.picAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotalRooms.ResumeLayout(False)
        CType(Me.picTotalRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlScheduleContainer.ResumeLayout(False)
        Me.pnlScheduleContainer.PerformLayout()
        Me.pnlChartContainer.ResumeLayout(False)
        Me.pnlChartContainer.PerformLayout()
        Me.pnlScheduleView.ResumeLayout(False)
        Me.pnlScheduleView.PerformLayout()
        Me.pnlCheckbox.ResumeLayout(False)
        Me.pnlCheckbox.PerformLayout()
        Me.pnlDropRoom.ResumeLayout(False)
        Me.pnlDate.ResumeLayout(False)
        Me.pnlSearchContainer.ResumeLayout(False)
        Me.pnlSearchContainer.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddSched.ResumeLayout(False)
        Me.pnlAddSched.PerformLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRoomsView.ResumeLayout(False)
        Me.pnlRoomsView.PerformLayout()
        Me.pnlSearchRoomContainer.ResumeLayout(False)
        Me.pnlSearchRoomContainer.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddRoom.ResumeLayout(False)
        Me.pnlAddRoom.PerformLayout()
        Me.pnlRoomManagement.ResumeLayout(False)
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAvailabilityView.ResumeLayout(False)
        Me.pnlAvailabilityView.PerformLayout()
        CType(Me.dgvAvailability, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRoomType.ResumeLayout(False)
        Me.pnlDay.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlClassroomAvail.ResumeLayout(False)
        CType(Me.picAvailRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConflictsView.ResumeLayout(False)
        Me.pnlConflictsView.PerformLayout()
        Me.pnlAllDates.ResumeLayout(False)
        Me.pnlAllDates.PerformLayout()
        Me.pnlSearchConflicts.ResumeLayout(False)
        Me.pnlSearchConflicts.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDatePickerLogs.ResumeLayout(False)
        Me.pnlSchedConflicts.ResumeLayout(False)
        CType(Me.dgvConflicts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        CType(Me.picLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUserProfileCard.ResumeLayout(False)
        Me.pnlUserProfileCard.PerformLayout()
        CType(Me.pictureBoxUserManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUserProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlDashboardView As System.Windows.Forms.Panel
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents btnSchedule As System.Windows.Forms.Button
    Friend WithEvents btnRooms As System.Windows.Forms.Button
    Friend WithEvents pnlUserProfileCard As System.Windows.Forms.Panel
    Friend WithEvents btnConflicts As System.Windows.Forms.Button
    Friend WithEvents btnAvailability As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblWelcomeUser As System.Windows.Forms.Label
    Friend WithEvents pnlTotalRooms As System.Windows.Forms.Panel
    Friend WithEvents picTotalRooms As System.Windows.Forms.PictureBox
    Friend WithEvents pnlConflicts As System.Windows.Forms.Panel
    Friend WithEvents lblConflictsCount As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents picConflicts As System.Windows.Forms.PictureBox
    Friend WithEvents pnlOccupied As System.Windows.Forms.Panel
    Friend WithEvents lblOccupiedCount As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents picOccupied As System.Windows.Forms.PictureBox
    Friend WithEvents pnlAvailable As System.Windows.Forms.Panel
    Friend WithEvents lblAvailableCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picAvailable As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalRoomsCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chartRoomOverview As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents dgvTodaysSchedule As System.Windows.Forms.DataGridView
    Friend WithEvents pnlScheduleContainer As System.Windows.Forms.Panel
    Friend WithEvents btnViewAll As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlChartContainer As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pnlScheduleView As System.Windows.Forms.Panel
    Friend WithEvents pnlAvailabilityView As System.Windows.Forms.Panel
    Friend WithEvents pnlConflictsView As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents pnlDate As System.Windows.Forms.Panel
    Friend WithEvents txtSearchSchedule As System.Windows.Forms.TextBox
    Friend WithEvents pnlSearchContainer As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pnlDropRoom As System.Windows.Forms.Panel
    Friend WithEvents cmbRoomFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddSched As System.Windows.Forms.Button
    Friend WithEvents pnlAddSched As System.Windows.Forms.Panel
    Friend WithEvents dgvSchedule As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbDayFilter As System.Windows.Forms.ComboBox
    Friend WithEvents dgvRooms As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents pnlSearchRoomContainer As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchRoom As System.Windows.Forms.TextBox
    Friend WithEvents pnlAddRoom As System.Windows.Forms.Panel
    Friend WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents dgvAvailability As System.Windows.Forms.DataGridView
    Friend WithEvents pnlRoomType As System.Windows.Forms.Panel
    Friend WithEvents cmbFilterRoom As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents pnlDay As System.Windows.Forms.Panel
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchAvailability As System.Windows.Forms.TextBox
    Friend WithEvents dgvConflicts As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pnlSchedConflicts As System.Windows.Forms.Panel
    Friend WithEvents pnlRoomManagement As System.Windows.Forms.Panel
    Friend WithEvents pnlSchedMan As System.Windows.Forms.Panel
    Friend WithEvents pnlClassroomAvail As System.Windows.Forms.Panel
    Public WithEvents pnlRoomsView As System.Windows.Forms.Panel
    Friend WithEvents pictureBoxUserManagement As System.Windows.Forms.PictureBox
    Friend WithEvents picAvailRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCheckbox As System.Windows.Forms.Panel
    Friend WithEvents chkMySchedule As System.Windows.Forms.CheckBox
    Friend WithEvents btnToggleView As System.Windows.Forms.Button
    Friend WithEvents dgvLogs As System.Windows.Forms.DataGridView
    Friend WithEvents Toggle1 As prjSchedMoni.Toggle
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents picLogout As System.Windows.Forms.PictureBox
    Friend WithEvents lblLogout As System.Windows.Forms.Label
    Friend WithEvents picUserProfile As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblTime1 As System.Windows.Forms.Label
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents lblTime2 As System.Windows.Forms.Label
    Friend WithEvents lblDate2 As System.Windows.Forms.Label
    Friend WithEvents lblTime3 As System.Windows.Forms.Label
    Friend WithEvents lblDate3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents pnlDatePickerLogs As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlSearchConflicts As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchConflicts As System.Windows.Forms.TextBox
    Friend WithEvents pnlSwitch As System.Windows.Forms.Panel
    Friend WithEvents pnlAllDates As System.Windows.Forms.Panel
    Friend WithEvents chkAllLogs As System.Windows.Forms.CheckBox
    Friend WithEvents btnNav As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AvailabilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConflictsLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MyScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConflictsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAccount As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ManageAccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
