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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint7 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 15.0R)
        Dim DataPoint8 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 12.0R)
        Dim DataPoint9 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 3.0R)
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.pnlDashboardView = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chartRoomOverview = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvTodaysSchedule = New System.Windows.Forms.DataGridView()
        Me.pnlConflicts = New System.Windows.Forms.Panel()
        Me.lblConflictsCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlOccupied = New System.Windows.Forms.Panel()
        Me.lblOccupiedCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlAvailable = New System.Windows.Forms.Panel()
        Me.lblAvailableCount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlTotalRooms = New System.Windows.Forms.Panel()
        Me.lblTotalRoomsCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblWelcomeUser = New System.Windows.Forms.Label()
        Me.pnlScheduleContainer = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnViewAll = New System.Windows.Forms.LinkLabel()
        Me.pnlChartContainer = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlScheduleView = New System.Windows.Forms.Panel()
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
        Me.txtSearchSchedule = New System.Windows.Forms.TextBox()
        Me.pnlAddSched = New System.Windows.Forms.Panel()
        Me.dgvSchedule = New System.Windows.Forms.DataGridView()
        Me.pnlSchedMan = New System.Windows.Forms.Panel()
        Me.pnlRoomsView = New System.Windows.Forms.Panel()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pnlSearchRoomContainer = New System.Windows.Forms.Panel()
        Me.txtSearchRoom = New System.Windows.Forms.TextBox()
        Me.pnlAddRoom = New System.Windows.Forms.Panel()
        Me.pnlRoomManagement = New System.Windows.Forms.Panel()
        Me.pnlAvailabilityView = New System.Windows.Forms.Panel()
        Me.dgvAvailability = New System.Windows.Forms.DataGridView()
        Me.pnlRoomType = New System.Windows.Forms.Panel()
        Me.cmbFilterRoom = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.pnlDay = New System.Windows.Forms.Panel()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.txtSearchAvailability = New System.Windows.Forms.TextBox()
        Me.pnlClassroomAvail = New System.Windows.Forms.Panel()
        Me.pnlConflictsView = New System.Windows.Forms.Panel()
        Me.btnToggleView = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlSchedConflicts = New System.Windows.Forms.Panel()
        Me.dgvConflicts = New System.Windows.Forms.DataGridView()
        Me.dgvLogs = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnAddSched = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.picAvailRefresh = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pnlNormal = New System.Windows.Forms.Panel()
        Me.btnNormalMode = New System.Windows.Forms.Button()
        Me.btnConflicts = New System.Windows.Forms.Button()
        Me.btnAvailability = New System.Windows.Forms.Button()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlUserProfileCard = New System.Windows.Forms.Panel()
        Me.pictureBoxUserManagement = New System.Windows.Forms.PictureBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Toggle1 = New prjSchedMoni.Toggle()
        Me.lblLogout = New System.Windows.Forms.Label()
        Me.picUserProfile = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.pnlDashboardView.SuspendLayout()
        CType(Me.chartRoomOverview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTodaysSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlConflicts.SuspendLayout()
        Me.pnlOccupied.SuspendLayout()
        Me.pnlAvailable.SuspendLayout()
        Me.pnlTotalRooms.SuspendLayout()
        Me.pnlScheduleContainer.SuspendLayout()
        Me.pnlChartContainer.SuspendLayout()
        Me.pnlScheduleView.SuspendLayout()
        Me.pnlCheckbox.SuspendLayout()
        Me.pnlDropRoom.SuspendLayout()
        Me.pnlDate.SuspendLayout()
        Me.pnlSearchContainer.SuspendLayout()
        Me.pnlAddSched.SuspendLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRoomsView.SuspendLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearchRoomContainer.SuspendLayout()
        Me.pnlAddRoom.SuspendLayout()
        Me.pnlAvailabilityView.SuspendLayout()
        CType(Me.dgvAvailability, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRoomType.SuspendLayout()
        Me.pnlDay.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlClassroomAvail.SuspendLayout()
        Me.pnlConflictsView.SuspendLayout()
        Me.pnlSchedConflicts.SuspendLayout()
        CType(Me.dgvConflicts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAvailRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlNormal.SuspendLayout()
        Me.pnlUserProfileCard.SuspendLayout()
        CType(Me.pictureBoxUserManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUserProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDashboardView
        '
        Me.pnlDashboardView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlDashboardView.Controls.Add(Me.Label6)
        Me.pnlDashboardView.Controls.Add(Me.chartRoomOverview)
        Me.pnlDashboardView.Controls.Add(Me.dgvTodaysSchedule)
        Me.pnlDashboardView.Controls.Add(Me.pnlConflicts)
        Me.pnlDashboardView.Controls.Add(Me.pnlOccupied)
        Me.pnlDashboardView.Controls.Add(Me.pnlAvailable)
        Me.pnlDashboardView.Controls.Add(Me.pnlTotalRooms)
        Me.pnlDashboardView.Controls.Add(Me.lblDateTime)
        Me.pnlDashboardView.Controls.Add(Me.lblWelcomeUser)
        Me.pnlDashboardView.Controls.Add(Me.pnlScheduleContainer)
        Me.pnlDashboardView.Controls.Add(Me.pnlChartContainer)
        Me.pnlDashboardView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboardView.Location = New System.Drawing.Point(220, 0)
        Me.pnlDashboardView.Name = "pnlDashboardView"
        Me.pnlDashboardView.Size = New System.Drawing.Size(804, 720)
        Me.pnlDashboardView.TabIndex = 1
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
        Me.chartRoomOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        ChartArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        Me.chartRoomOverview.ChartAreas.Add(ChartArea3)
        Legend3.Alignment = System.Drawing.StringAlignment.Center
        Legend3.BackColor = System.Drawing.Color.Transparent
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend3.Name = "Legend1"
        Me.chartRoomOverview.Legends.Add(Legend3)
        Me.chartRoomOverview.Location = New System.Drawing.Point(520, 329)
        Me.chartRoomOverview.Name = "chartRoomOverview"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series3.IsValueShownAsLabel = True
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        DataPoint7.AxisLabel = "Occupied"
        DataPoint7.Color = System.Drawing.Color.Tomato
        DataPoint8.AxisLabel = "Available"
        DataPoint8.Color = System.Drawing.Color.PaleGreen
        DataPoint9.AxisLabel = "Conflict"
        DataPoint9.Color = System.Drawing.Color.Orange
        Series3.Points.Add(DataPoint7)
        Series3.Points.Add(DataPoint8)
        Series3.Points.Add(DataPoint9)
        Me.chartRoomOverview.Series.Add(Series3)
        Me.chartRoomOverview.Size = New System.Drawing.Size(270, 310)
        Me.chartRoomOverview.TabIndex = 20
        Me.chartRoomOverview.Text = "Chart1"
        '
        'dgvTodaysSchedule
        '
        Me.dgvTodaysSchedule.AllowUserToAddRows = False
        Me.dgvTodaysSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodaysSchedule.BackgroundColor = System.Drawing.Color.White
        Me.dgvTodaysSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodaysSchedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTodaysSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodaysSchedule.EnableHeadersVisualStyles = False
        Me.dgvTodaysSchedule.Location = New System.Drawing.Point(25, 329)
        Me.dgvTodaysSchedule.Name = "dgvTodaysSchedule"
        Me.dgvTodaysSchedule.ReadOnly = True
        Me.dgvTodaysSchedule.RowHeadersVisible = False
        Me.dgvTodaysSchedule.Size = New System.Drawing.Size(470, 310)
        Me.dgvTodaysSchedule.TabIndex = 19
        '
        'pnlConflicts
        '
        Me.pnlConflicts.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlConflicts.Controls.Add(Me.lblConflictsCount)
        Me.pnlConflicts.Controls.Add(Me.Label7)
        Me.pnlConflicts.Controls.Add(Me.PictureBox4)
        Me.pnlConflicts.Location = New System.Drawing.Point(610, 113)
        Me.pnlConflicts.Name = "pnlConflicts"
        Me.pnlConflicts.Size = New System.Drawing.Size(180, 160)
        Me.pnlConflicts.TabIndex = 18
        '
        'lblConflictsCount
        '
        Me.lblConflictsCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConflictsCount.Location = New System.Drawing.Point(5, 105)
        Me.lblConflictsCount.Name = "lblConflictsCount"
        Me.lblConflictsCount.Size = New System.Drawing.Size(170, 45)
        Me.lblConflictsCount.TabIndex = 17
        Me.lblConflictsCount.Text = "0"
        Me.lblConflictsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Conflicts"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlOccupied
        '
        Me.pnlOccupied.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlOccupied.Controls.Add(Me.lblOccupiedCount)
        Me.pnlOccupied.Controls.Add(Me.Label5)
        Me.pnlOccupied.Controls.Add(Me.PictureBox3)
        Me.pnlOccupied.Location = New System.Drawing.Point(415, 113)
        Me.pnlOccupied.Name = "pnlOccupied"
        Me.pnlOccupied.Size = New System.Drawing.Size(180, 160)
        Me.pnlOccupied.TabIndex = 18
        '
        'lblOccupiedCount
        '
        Me.lblOccupiedCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupiedCount.Location = New System.Drawing.Point(5, 105)
        Me.lblOccupiedCount.Name = "lblOccupiedCount"
        Me.lblOccupiedCount.Size = New System.Drawing.Size(170, 45)
        Me.lblOccupiedCount.TabIndex = 17
        Me.lblOccupiedCount.Text = "0"
        Me.lblOccupiedCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Occupied"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlAvailable
        '
        Me.pnlAvailable.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlAvailable.Controls.Add(Me.lblAvailableCount)
        Me.pnlAvailable.Controls.Add(Me.Label3)
        Me.pnlAvailable.Controls.Add(Me.PictureBox2)
        Me.pnlAvailable.Location = New System.Drawing.Point(220, 113)
        Me.pnlAvailable.Name = "pnlAvailable"
        Me.pnlAvailable.Size = New System.Drawing.Size(180, 160)
        Me.pnlAvailable.TabIndex = 18
        '
        'lblAvailableCount
        '
        Me.lblAvailableCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableCount.Location = New System.Drawing.Point(5, 105)
        Me.lblAvailableCount.Name = "lblAvailableCount"
        Me.lblAvailableCount.Size = New System.Drawing.Size(170, 45)
        Me.lblAvailableCount.TabIndex = 17
        Me.lblAvailableCount.Text = "0"
        Me.lblAvailableCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Available"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlTotalRooms
        '
        Me.pnlTotalRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlTotalRooms.Controls.Add(Me.lblTotalRoomsCount)
        Me.pnlTotalRooms.Controls.Add(Me.Label1)
        Me.pnlTotalRooms.Controls.Add(Me.PictureBox1)
        Me.pnlTotalRooms.Location = New System.Drawing.Point(25, 113)
        Me.pnlTotalRooms.Name = "pnlTotalRooms"
        Me.pnlTotalRooms.Size = New System.Drawing.Size(180, 160)
        Me.pnlTotalRooms.TabIndex = 11
        '
        'lblTotalRoomsCount
        '
        Me.lblTotalRoomsCount.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRoomsCount.Location = New System.Drawing.Point(5, 105)
        Me.lblTotalRoomsCount.Name = "lblTotalRoomsCount"
        Me.lblTotalRoomsCount.Size = New System.Drawing.Size(170, 45)
        Me.lblTotalRoomsCount.TabIndex = 17
        Me.lblTotalRoomsCount.Text = "0"
        Me.lblTotalRoomsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Total Rooms"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblDateTime.Location = New System.Drawing.Point(639, 42)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(125, 34)
        Me.lblDateTime.TabIndex = 10
        Me.lblDateTime.Text = "September 15, 2026" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tuesday"
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
        Me.pnlScheduleContainer.Location = New System.Drawing.Point(25, 295)
        Me.pnlScheduleContainer.Name = "pnlScheduleContainer"
        Me.pnlScheduleContainer.Size = New System.Drawing.Size(470, 359)
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
        Me.btnViewAll.AutoSize = True
        Me.btnViewAll.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAll.LinkColor = System.Drawing.Color.Black
        Me.btnViewAll.Location = New System.Drawing.Point(400, 8)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(53, 17)
        Me.btnViewAll.TabIndex = 0
        Me.btnViewAll.TabStop = True
        Me.btnViewAll.Text = "View All"
        '
        'pnlChartContainer
        '
        Me.pnlChartContainer.BackColor = System.Drawing.Color.Gray
        Me.pnlChartContainer.Controls.Add(Me.Label4)
        Me.pnlChartContainer.Location = New System.Drawing.Point(520, 295)
        Me.pnlChartContainer.Name = "pnlChartContainer"
        Me.pnlChartContainer.Size = New System.Drawing.Size(270, 359)
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
        Me.pnlScheduleView.BackColor = System.Drawing.Color.WhiteSmoke
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
        Me.pnlScheduleView.Location = New System.Drawing.Point(220, 0)
        Me.pnlScheduleView.Name = "pnlScheduleView"
        Me.pnlScheduleView.Size = New System.Drawing.Size(804, 717)
        Me.pnlScheduleView.TabIndex = 25
        '
        'pnlCheckbox
        '
        Me.pnlCheckbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlCheckbox.Controls.Add(Me.chkMySchedule)
        Me.pnlCheckbox.Location = New System.Drawing.Point(417, 186)
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
        Me.pnlSearchContainer.Location = New System.Drawing.Point(35, 186)
        Me.pnlSearchContainer.Name = "pnlSearchContainer"
        Me.pnlSearchContainer.Size = New System.Drawing.Size(379, 42)
        Me.pnlSearchContainer.TabIndex = 30
        '
        'txtSearchSchedule
        '
        Me.txtSearchSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtSearchSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchSchedule.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchSchedule.Location = New System.Drawing.Point(49, 11)
        Me.txtSearchSchedule.Name = "txtSearchSchedule"
        Me.txtSearchSchedule.Size = New System.Drawing.Size(325, 22)
        Me.txtSearchSchedule.TabIndex = 0
        '
        'pnlAddSched
        '
        Me.pnlAddSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlAddSched.Controls.Add(Me.btnAddSched)
        Me.pnlAddSched.Location = New System.Drawing.Point(596, 186)
        Me.pnlAddSched.Name = "pnlAddSched"
        Me.pnlAddSched.Size = New System.Drawing.Size(163, 52)
        Me.pnlAddSched.TabIndex = 34
        '
        'dgvSchedule
        '
        Me.dgvSchedule.AllowUserToAddRows = False
        Me.dgvSchedule.AllowUserToDeleteRows = False
        Me.dgvSchedule.AllowUserToResizeColumns = False
        Me.dgvSchedule.AllowUserToResizeRows = False
        Me.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSchedule.Location = New System.Drawing.Point(31, 266)
        Me.dgvSchedule.Name = "dgvSchedule"
        Me.dgvSchedule.ReadOnly = True
        Me.dgvSchedule.Size = New System.Drawing.Size(728, 409)
        Me.dgvSchedule.TabIndex = 35
        '
        'pnlSchedMan
        '
        Me.pnlSchedMan.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlSchedMan.Location = New System.Drawing.Point(32, 244)
        Me.pnlSchedMan.Name = "pnlSchedMan"
        Me.pnlSchedMan.Size = New System.Drawing.Size(727, 452)
        Me.pnlSchedMan.TabIndex = 36
        '
        'pnlRoomsView
        '
        Me.pnlRoomsView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlRoomsView.Controls.Add(Me.dgvRooms)
        Me.pnlRoomsView.Controls.Add(Me.Label14)
        Me.pnlRoomsView.Controls.Add(Me.Label15)
        Me.pnlRoomsView.Controls.Add(Me.pnlSearchRoomContainer)
        Me.pnlRoomsView.Controls.Add(Me.pnlAddRoom)
        Me.pnlRoomsView.Controls.Add(Me.pnlRoomManagement)
        Me.pnlRoomsView.Location = New System.Drawing.Point(220, 0)
        Me.pnlRoomsView.Name = "pnlRoomsView"
        Me.pnlRoomsView.Size = New System.Drawing.Size(804, 717)
        Me.pnlRoomsView.TabIndex = 26
        '
        'dgvRooms
        '
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(41, 200)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.Size = New System.Drawing.Size(728, 491)
        Me.dgvRooms.TabIndex = 44
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
        Me.pnlSearchRoomContainer.Size = New System.Drawing.Size(404, 42)
        Me.pnlSearchRoomContainer.TabIndex = 40
        '
        'txtSearchRoom
        '
        Me.txtSearchRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtSearchRoom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchRoom.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchRoom.Location = New System.Drawing.Point(49, 11)
        Me.txtSearchRoom.Name = "txtSearchRoom"
        Me.txtSearchRoom.Size = New System.Drawing.Size(339, 22)
        Me.txtSearchRoom.TabIndex = 0
        '
        'pnlAddRoom
        '
        Me.pnlAddRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlAddRoom.Controls.Add(Me.btnAddRoom)
        Me.pnlAddRoom.Location = New System.Drawing.Point(606, 122)
        Me.pnlAddRoom.Name = "pnlAddRoom"
        Me.pnlAddRoom.Size = New System.Drawing.Size(163, 52)
        Me.pnlAddRoom.TabIndex = 43
        '
        'pnlRoomManagement
        '
        Me.pnlRoomManagement.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlRoomManagement.Location = New System.Drawing.Point(41, 180)
        Me.pnlRoomManagement.Name = "pnlRoomManagement"
        Me.pnlRoomManagement.Size = New System.Drawing.Size(728, 528)
        Me.pnlRoomManagement.TabIndex = 49
        '
        'pnlAvailabilityView
        '
        Me.pnlAvailabilityView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlAvailabilityView.Controls.Add(Me.dgvAvailability)
        Me.pnlAvailabilityView.Controls.Add(Me.pnlRoomType)
        Me.pnlAvailabilityView.Controls.Add(Me.Label16)
        Me.pnlAvailabilityView.Controls.Add(Me.Label17)
        Me.pnlAvailabilityView.Controls.Add(Me.pnlDay)
        Me.pnlAvailabilityView.Controls.Add(Me.pnlSearch)
        Me.pnlAvailabilityView.Controls.Add(Me.pnlClassroomAvail)
        Me.pnlAvailabilityView.Location = New System.Drawing.Point(220, 0)
        Me.pnlAvailabilityView.Name = "pnlAvailabilityView"
        Me.pnlAvailabilityView.Size = New System.Drawing.Size(804, 717)
        Me.pnlAvailabilityView.TabIndex = 27
        '
        'dgvAvailability
        '
        Me.dgvAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAvailability.Location = New System.Drawing.Point(41, 200)
        Me.dgvAvailability.Name = "dgvAvailability"
        Me.dgvAvailability.Size = New System.Drawing.Size(728, 463)
        Me.dgvAvailability.TabIndex = 44
        '
        'pnlRoomType
        '
        Me.pnlRoomType.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlRoomType.Controls.Add(Me.cmbFilterRoom)
        Me.pnlRoomType.Location = New System.Drawing.Point(254, 122)
        Me.pnlRoomType.Name = "pnlRoomType"
        Me.pnlRoomType.Size = New System.Drawing.Size(187, 43)
        Me.pnlRoomType.TabIndex = 42
        '
        'cmbFilterRoom
        '
        Me.cmbFilterRoom.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cmbFilterRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFilterRoom.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbFilterRoom.ForeColor = System.Drawing.Color.Black
        Me.cmbFilterRoom.FormattingEnabled = True
        Me.cmbFilterRoom.Location = New System.Drawing.Point(3, 8)
        Me.cmbFilterRoom.Name = "cmbFilterRoom"
        Me.cmbFilterRoom.Size = New System.Drawing.Size(181, 28)
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
        Me.pnlDay.Location = New System.Drawing.Point(42, 122)
        Me.pnlDay.Name = "pnlDay"
        Me.pnlDay.Size = New System.Drawing.Size(206, 43)
        Me.pnlDay.TabIndex = 39
        '
        'cmbDay
        '
        Me.cmbDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.cmbDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDay.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmbDay.ForeColor = System.Drawing.Color.Black
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(3, 8)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(200, 28)
        Me.cmbDay.TabIndex = 34
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlSearch.Controls.Add(Me.PictureBox7)
        Me.pnlSearch.Controls.Add(Me.txtSearchAvailability)
        Me.pnlSearch.Location = New System.Drawing.Point(453, 122)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(316, 42)
        Me.pnlSearch.TabIndex = 40
        '
        'txtSearchAvailability
        '
        Me.txtSearchAvailability.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtSearchAvailability.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchAvailability.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchAvailability.Location = New System.Drawing.Point(49, 11)
        Me.txtSearchAvailability.Name = "txtSearchAvailability"
        Me.txtSearchAvailability.Size = New System.Drawing.Size(250, 22)
        Me.txtSearchAvailability.TabIndex = 0
        '
        'pnlClassroomAvail
        '
        Me.pnlClassroomAvail.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlClassroomAvail.Controls.Add(Me.picAvailRefresh)
        Me.pnlClassroomAvail.Location = New System.Drawing.Point(40, 175)
        Me.pnlClassroomAvail.Name = "pnlClassroomAvail"
        Me.pnlClassroomAvail.Size = New System.Drawing.Size(729, 516)
        Me.pnlClassroomAvail.TabIndex = 45
        '
        'pnlConflictsView
        '
        Me.pnlConflictsView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlConflictsView.Controls.Add(Me.btnToggleView)
        Me.pnlConflictsView.Controls.Add(Me.Label12)
        Me.pnlConflictsView.Controls.Add(Me.Label13)
        Me.pnlConflictsView.Controls.Add(Me.pnlSchedConflicts)
        Me.pnlConflictsView.Location = New System.Drawing.Point(220, 0)
        Me.pnlConflictsView.Name = "pnlConflictsView"
        Me.pnlConflictsView.Size = New System.Drawing.Size(804, 717)
        Me.pnlConflictsView.TabIndex = 28
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
        Me.btnToggleView.Location = New System.Drawing.Point(642, 42)
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
        Me.Label12.Size = New System.Drawing.Size(254, 21)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "View/resolve scheduling conflicts"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(36, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(224, 32)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Schedule Conflicts"
        '
        'pnlSchedConflicts
        '
        Me.pnlSchedConflicts.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlSchedConflicts.Controls.Add(Me.dgvConflicts)
        Me.pnlSchedConflicts.Controls.Add(Me.dgvLogs)
        Me.pnlSchedConflicts.Location = New System.Drawing.Point(38, 105)
        Me.pnlSchedConflicts.Name = "pnlSchedConflicts"
        Me.pnlSchedConflicts.Size = New System.Drawing.Size(728, 591)
        Me.pnlSchedConflicts.TabIndex = 48
        '
        'dgvConflicts
        '
        Me.dgvConflicts.AllowUserToAddRows = False
        Me.dgvConflicts.AllowUserToDeleteRows = False
        Me.dgvConflicts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConflicts.Location = New System.Drawing.Point(0, 20)
        Me.dgvConflicts.Name = "dgvConflicts"
        Me.dgvConflicts.ReadOnly = True
        Me.dgvConflicts.Size = New System.Drawing.Size(728, 550)
        Me.dgvConflicts.TabIndex = 47
        '
        'dgvLogs
        '
        Me.dgvLogs.AllowUserToAddRows = False
        Me.dgvLogs.AllowUserToDeleteRows = False
        Me.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogs.Location = New System.Drawing.Point(0, 20)
        Me.dgvLogs.Name = "dgvLogs"
        Me.dgvLogs.ReadOnly = True
        Me.dgvLogs.Size = New System.Drawing.Size(728, 550)
        Me.dgvLogs.TabIndex = 49
        Me.dgvLogs.Visible = False
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
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.prjSchedMoni.My.Resources.Resources.Conflicts1
        Me.PictureBox4.Location = New System.Drawing.Point(65, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 45)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.prjSchedMoni.My.Resources.Resources.occuu
        Me.PictureBox3.Location = New System.Drawing.Point(65, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 45)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(65, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prjSchedMoni.My.Resources.Resources.totalrooms1
        Me.PictureBox1.Location = New System.Drawing.Point(65, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
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
        'picAvailRefresh
        '
        Me.picAvailRefresh.Image = Global.prjSchedMoni.My.Resources.Resources.icons8refresh
        Me.picAvailRefresh.Location = New System.Drawing.Point(705, 3)
        Me.picAvailRefresh.Name = "picAvailRefresh"
        Me.picAvailRefresh.Size = New System.Drawing.Size(20, 20)
        Me.picAvailRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAvailRefresh.TabIndex = 3
        Me.picAvailRefresh.TabStop = False
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
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.Transparent
        Me.pnlSidebar.BackgroundImage = CType(resources.GetObject("pnlSidebar.BackgroundImage"), System.Drawing.Image)
        Me.pnlSidebar.Controls.Add(Me.PictureBox8)
        Me.pnlSidebar.Controls.Add(Me.lblLogout)
        Me.pnlSidebar.Controls.Add(Me.Label19)
        Me.pnlSidebar.Controls.Add(Me.Label18)
        Me.pnlSidebar.Controls.Add(Me.pnlNormal)
        Me.pnlSidebar.Controls.Add(Me.Toggle1)
        Me.pnlSidebar.Controls.Add(Me.btnConflicts)
        Me.pnlSidebar.Controls.Add(Me.btnAvailability)
        Me.pnlSidebar.Controls.Add(Me.btnRooms)
        Me.pnlSidebar.Controls.Add(Me.btnSchedule)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.pnlUserProfileCard)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 720)
        Me.pnlSidebar.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(123, 678)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "Normal"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(54, 678)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "☀️ / 🌙"
        '
        'pnlNormal
        '
        Me.pnlNormal.BackColor = System.Drawing.Color.LightGray
        Me.pnlNormal.Controls.Add(Me.btnNormalMode)
        Me.pnlNormal.Location = New System.Drawing.Point(112, 651)
        Me.pnlNormal.Name = "pnlNormal"
        Me.pnlNormal.Size = New System.Drawing.Size(67, 24)
        Me.pnlNormal.TabIndex = 47
        '
        'btnNormalMode
        '
        Me.btnNormalMode.BackColor = System.Drawing.Color.Transparent
        Me.btnNormalMode.FlatAppearance.BorderSize = 0
        Me.btnNormalMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNormalMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNormalMode.Image = Global.prjSchedMoni.My.Resources.Resources.normal
        Me.btnNormalMode.Location = New System.Drawing.Point(5, 0)
        Me.btnNormalMode.Name = "btnNormalMode"
        Me.btnNormalMode.Size = New System.Drawing.Size(54, 24)
        Me.btnNormalMode.TabIndex = 47
        Me.btnNormalMode.UseVisualStyleBackColor = False
        '
        'btnConflicts
        '
        Me.btnConflicts.AccessibleName = ""
        Me.btnConflicts.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnConflicts.FlatAppearance.BorderSize = 0
        Me.btnConflicts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConflicts.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConflicts.ForeColor = System.Drawing.Color.Black
        Me.btnConflicts.Image = CType(resources.GetObject("btnConflicts.Image"), System.Drawing.Image)
        Me.btnConflicts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConflicts.Location = New System.Drawing.Point(15, 400)
        Me.btnConflicts.Name = "btnConflicts"
        Me.btnConflicts.Size = New System.Drawing.Size(190, 45)
        Me.btnConflicts.TabIndex = 7
        Me.btnConflicts.Text = "  Conflicts / Logs"
        Me.btnConflicts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConflicts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConflicts.UseVisualStyleBackColor = False
        '
        'btnAvailability
        '
        Me.btnAvailability.AccessibleName = ""
        Me.btnAvailability.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnAvailability.FlatAppearance.BorderSize = 0
        Me.btnAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvailability.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailability.ForeColor = System.Drawing.Color.Black
        Me.btnAvailability.Image = Global.prjSchedMoni.My.Resources.Resources.event1
        Me.btnAvailability.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvailability.Location = New System.Drawing.Point(15, 345)
        Me.btnAvailability.Name = "btnAvailability"
        Me.btnAvailability.Size = New System.Drawing.Size(190, 45)
        Me.btnAvailability.TabIndex = 6
        Me.btnAvailability.Text = "  Availability"
        Me.btnAvailability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAvailability.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAvailability.UseVisualStyleBackColor = False
        '
        'btnRooms
        '
        Me.btnRooms.AccessibleName = ""
        Me.btnRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnRooms.FlatAppearance.BorderSize = 0
        Me.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRooms.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.ForeColor = System.Drawing.Color.Black
        Me.btnRooms.Image = CType(resources.GetObject("btnRooms.Image"), System.Drawing.Image)
        Me.btnRooms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRooms.Location = New System.Drawing.Point(15, 290)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(190, 45)
        Me.btnRooms.TabIndex = 4
        Me.btnRooms.Text = "  Rooms"
        Me.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRooms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRooms.UseVisualStyleBackColor = False
        '
        'btnSchedule
        '
        Me.btnSchedule.AccessibleName = ""
        Me.btnSchedule.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnSchedule.FlatAppearance.BorderSize = 0
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSchedule.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.ForeColor = System.Drawing.Color.Black
        Me.btnSchedule.Image = CType(resources.GetObject("btnSchedule.Image"), System.Drawing.Image)
        Me.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchedule.Location = New System.Drawing.Point(15, 235)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(190, 45)
        Me.btnSchedule.TabIndex = 3
        Me.btnSchedule.Text = "  Schedule"
        Me.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSchedule.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.AccessibleName = ""
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.Black
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(15, 180)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(190, 45)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "  Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'pnlUserProfileCard
        '
        Me.pnlUserProfileCard.Controls.Add(Me.pictureBoxUserManagement)
        Me.pnlUserProfileCard.Controls.Add(Me.picUserProfile)
        Me.pnlUserProfileCard.Controls.Add(Me.lblUserName)
        Me.pnlUserProfileCard.Location = New System.Drawing.Point(15, 60)
        Me.pnlUserProfileCard.Name = "pnlUserProfileCard"
        Me.pnlUserProfileCard.Size = New System.Drawing.Size(190, 60)
        Me.pnlUserProfileCard.TabIndex = 5
        '
        'pictureBoxUserManagement
        '
        Me.pictureBoxUserManagement.Image = Global.prjSchedMoni.My.Resources.Resources.settings
        Me.pictureBoxUserManagement.Location = New System.Drawing.Point(172, 42)
        Me.pictureBoxUserManagement.Name = "pictureBoxUserManagement"
        Me.pictureBoxUserManagement.Size = New System.Drawing.Size(15, 15)
        Me.pictureBoxUserManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxUserManagement.TabIndex = 2
        Me.pictureBoxUserManagement.TabStop = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblUserName.Location = New System.Drawing.Point(43, 22)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(123, 17)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "John Bricks Amora"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Toggle1
        '
        Me.Toggle1.BackColor = System.Drawing.Color.Transparent
        Me.Toggle1.Checked = False
        Me.Toggle1.Location = New System.Drawing.Point(54, 651)
        Me.Toggle1.Name = "Toggle1"
        Me.Toggle1.Size = New System.Drawing.Size(41, 24)
        Me.Toggle1.TabIndex = 46
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblLogout.Location = New System.Drawing.Point(89, 604)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(64, 21)
        Me.lblLogout.TabIndex = 26
        Me.lblLogout.Text = "Logout"
        '
        'picUserProfile
        '
        Me.picUserProfile.Image = Global.prjSchedMoni.My.Resources.Resources.account1
        Me.picUserProfile.Location = New System.Drawing.Point(4, 14)
        Me.picUserProfile.Name = "picUserProfile"
        Me.picUserProfile.Size = New System.Drawing.Size(35, 35)
        Me.picUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUserProfile.TabIndex = 0
        Me.picUserProfile.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.prjSchedMoni.My.Resources.Resources.power_button
        Me.PictureBox8.Location = New System.Drawing.Point(61, 604)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 3
        Me.PictureBox8.TabStop = False
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.Controls.Add(Me.pnlDashboardView)
        Me.Controls.Add(Me.pnlConflictsView)
        Me.Controls.Add(Me.pnlScheduleView)
        Me.Controls.Add(Me.pnlAvailabilityView)
        Me.Controls.Add(Me.pnlRoomsView)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashboardForm"
        Me.pnlDashboardView.ResumeLayout(False)
        Me.pnlDashboardView.PerformLayout()
        CType(Me.chartRoomOverview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTodaysSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlConflicts.ResumeLayout(False)
        Me.pnlOccupied.ResumeLayout(False)
        Me.pnlAvailable.ResumeLayout(False)
        Me.pnlTotalRooms.ResumeLayout(False)
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
        Me.pnlAddSched.ResumeLayout(False)
        Me.pnlAddSched.PerformLayout()
        CType(Me.dgvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRoomsView.ResumeLayout(False)
        Me.pnlRoomsView.PerformLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearchRoomContainer.ResumeLayout(False)
        Me.pnlSearchRoomContainer.PerformLayout()
        Me.pnlAddRoom.ResumeLayout(False)
        Me.pnlAddRoom.PerformLayout()
        Me.pnlAvailabilityView.ResumeLayout(False)
        Me.pnlAvailabilityView.PerformLayout()
        CType(Me.dgvAvailability, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRoomType.ResumeLayout(False)
        Me.pnlDay.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlClassroomAvail.ResumeLayout(False)
        Me.pnlConflictsView.ResumeLayout(False)
        Me.pnlConflictsView.PerformLayout()
        Me.pnlSchedConflicts.ResumeLayout(False)
        CType(Me.dgvConflicts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAvailRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlNormal.ResumeLayout(False)
        Me.pnlUserProfileCard.ResumeLayout(False)
        Me.pnlUserProfileCard.PerformLayout()
        CType(Me.pictureBoxUserManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUserProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents lblDateTime As System.Windows.Forms.Label
    Friend WithEvents lblWelcomeUser As System.Windows.Forms.Label
    Friend WithEvents pnlTotalRooms As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlConflicts As System.Windows.Forms.Panel
    Friend WithEvents lblConflictsCount As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlOccupied As System.Windows.Forms.Panel
    Friend WithEvents lblOccupiedCount As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlAvailable As System.Windows.Forms.Panel
    Friend WithEvents lblAvailableCount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
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
    Friend WithEvents btnNormalMode As System.Windows.Forms.Button
    Friend WithEvents pnlNormal As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents lblLogout As System.Windows.Forms.Label
    Friend WithEvents picUserProfile As System.Windows.Forms.PictureBox
End Class
