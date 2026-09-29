Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting

Public Class DashboardForm

    Private OriginalColors As New Dictionary(Of Control, Color)
    Private OriginalForeColor As New Dictionary(Of Control, Color)

    Private Sub SaveOriginalColors(ByVal parent As Control)
        For Each ctrl As Control In parent.Controls
            If Not OriginalColors.ContainsKey(ctrl) Then
                OriginalColors.Add(ctrl, ctrl.BackColor)
                OriginalForeColor.Add(ctrl, ctrl.ForeColor)
            End If
            If ctrl.HasChildren Then
                SaveOriginalColors(ctrl)
            End If
        Next
    End Sub

    Private Sub DashboardForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        dgvTodaysSchedule.AutoGenerateColumns = True
        dgvTodaysSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        FormatScheduleGrid()

        LoadDashboardMetrics()
        LoadTodaysSchedule()

        LoadRoomDropdown()
        LoadDayDropdown()
        LoadScheduleFromDatabase()
        LoadRoomsData()
        LoadAvailabilityData()
        LoadConflictsData()
        LoadRoomChart()

        SetupPlaceholders()

        ApplyAllRoundedCorners()
        UpdateDateTimeDisplay()

        SetupNavButtons()
        LoadUserProfile()
        ShowView(pnlDashboardView)
        HighlightActiveButton(btnDashboard)

        Dim currentUserRole As String = If(GlobalSession.UserRole Is Nothing, "", GlobalSession.UserRole.Trim())
        Dim isAdmin As Boolean = currentUserRole.IndexOf("Admin", StringComparison.OrdinalIgnoreCase) >= 0
        pictureBoxUserManagement.Visible = isAdmin

        If Not isAdmin AndAlso btnConflicts IsNot Nothing Then
            btnConflicts.Text = "🔒 Conflicts / Logs"
        End If

        SaveOriginalColors(Me)
        
    End Sub

    Private Sub SetupPlaceholders()
        If String.IsNullOrEmpty(txtSearchSchedule.Text) Then
            txtSearchSchedule.Text = "Search..."
            txtSearchSchedule.ForeColor = Color.Gray
        End If
        AddHandler txtSearchSchedule.Enter, AddressOf SearchTextBox_Enter
        AddHandler txtSearchSchedule.Leave, AddressOf SearchTextBox_Leave

        If String.IsNullOrEmpty(txtSearchRoom.Text) Then
            txtSearchRoom.Text = "Search..."
            txtSearchRoom.ForeColor = Color.Gray
        End If
        AddHandler txtSearchRoom.Enter, AddressOf SearchTextBox_Enter
        AddHandler txtSearchRoom.Leave, AddressOf SearchTextBox_Leave

        If String.IsNullOrEmpty(txtSearchAvailability.Text) Then
            txtSearchAvailability.Text = "Search..."
            txtSearchAvailability.ForeColor = Color.Gray
        End If
        AddHandler txtSearchAvailability.Enter, AddressOf SearchTextBox_Enter
        AddHandler txtSearchAvailability.Leave, AddressOf SearchTextBox_Leave
    End Sub

    Private Sub SearchTextBox_Enter(ByVal sender As Object, ByVal e As EventArgs)
        Dim txt As TextBox = CType(sender, TextBox)
        If txt.Text = "Search..." Then
            txt.Text = ""
            txt.ForeColor = If(Toggle1 IsNot Nothing AndAlso Toggle1.Checked, Color.White, Color.Black)
        End If
    End Sub

    Private Sub SearchTextBox_Leave(ByVal sender As Object, ByVal e As EventArgs)
        Dim txt As TextBox = CType(sender, TextBox)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.Text = "Search..."
            txt.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub LoadRoomDropdown()
        Try
            Dim query As String = "SELECT room_id, room_name FROM tbl_classrooms ORDER BY room_name ASC"
            Using cmd As New MySqlCommand(query, conn)
                Dim dataAdapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                dataAdapter.Fill(dt)

                Dim dr As DataRow = dt.NewRow()
                dr("room_id") = 0
                dr("room_name") = "All Rooms"
                dt.Rows.InsertAt(dr, 0)

                cmbRoomFilter.DataSource = dt
                cmbRoomFilter.DisplayMember = "room_name"
                cmbRoomFilter.ValueMember = "room_id"
                cmbRoomFilter.SelectedIndex = 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading rooms filter: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadDayDropdown()
        If cmbDayFilter IsNot Nothing AndAlso cmbDayFilter.Items.Count = 0 Then
            cmbDayFilter.Items.Add("All Days")
            cmbDayFilter.Items.Add("Monday")
            cmbDayFilter.Items.Add("Tuesday")
            cmbDayFilter.Items.Add("Wednesday")
            cmbDayFilter.Items.Add("Thursday")
            cmbDayFilter.Items.Add("Friday")
            cmbDayFilter.Items.Add("Saturday")
            cmbDayFilter.Items.Add("Sunday")
            cmbDayFilter.SelectedIndex = 0
        End If
    End Sub

    Private Sub LoadScheduleFromDatabase()
        Try
            Dim query As String = "SELECT s.schedule_id AS 'ID', " & _
                                  "s.day_of_week AS 'Day', " & _
                                  "CONCAT(TIME_FORMAT(s.time_start, '%l:%i'), ' - ', TIME_FORMAT(s.time_end, '%l:%i%p')) AS 'Time', " & _
                                  "c.room_name AS 'Room/Lab', " & _
                                  "s.subject_code AS 'Subject', " & _
                                  "u.full_name AS 'Instructor', " & _
                                  "CASE " & _
                                  "   WHEN (s.day_of_week = DAYNAME(CURDATE()) AND CURTIME() > s.time_end) OR " & _
                                  "        (FIELD(s.day_of_week, 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday') < FIELD(DAYNAME(CURDATE()), 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday')) THEN 'Dismissed' " & _
                                  "   WHEN s.day_of_week = DAYNAME(CURDATE()) AND CURTIME() BETWEEN s.time_start AND s.time_end THEN 'On going' " & _
                                  "   ELSE 'Scheduled' " & _
                                  "END AS 'Status', " & _
                                  "s.instructor_id AS 'InstructorID' " & _
                                  "FROM tbl_schedules s " & _
                                  "JOIN tbl_classrooms c ON s.room_id = c.room_id " & _
                                  "JOIN tbl_users u ON s.instructor_id = u.user_id " & _
                                  "WHERE 1=1"

            If chkMySchedule IsNot Nothing AndAlso chkMySchedule.Checked Then
                query &= " AND s.instructor_id = @myUserId"
            End If

            If cmbRoomFilter IsNot Nothing AndAlso cmbRoomFilter.SelectedValue IsNot Nothing Then
                Dim selectedVal As Integer = 0
                If Integer.TryParse(cmbRoomFilter.SelectedValue.ToString(), selectedVal) AndAlso selectedVal > 0 Then
                    query &= " AND s.room_id = @filterRoom"
                End If
            End If

            Dim applyDayFilter As Boolean = False
            Dim selectedDayText As String = ""
            If cmbDayFilter IsNot Nothing AndAlso cmbDayFilter.SelectedItem IsNot Nothing Then
                selectedDayText = cmbDayFilter.SelectedItem.ToString()
                If selectedDayText <> "All Days" Then
                    applyDayFilter = True
                End If
            End If

            If applyDayFilter Then
                query &= " AND s.day_of_week = @filterDay"
            End If

            If txtSearchSchedule IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtSearchSchedule.Text) AndAlso txtSearchSchedule.Text <> "Search..." Then
                query &= " AND (s.subject_code LIKE @search OR u.full_name LIKE @search)"
            End If

            query &= " ORDER BY FIELD(s.day_of_week, 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'), s.time_start ASC"

            Using cmd As New MySqlCommand(query, conn)
                If chkMySchedule IsNot Nothing AndAlso chkMySchedule.Checked Then
                    cmd.Parameters.AddWithValue("@myUserId", GlobalSession.UserId)
                End If

                If cmbRoomFilter IsNot Nothing AndAlso cmbRoomFilter.SelectedValue IsNot Nothing Then
                    Dim selectedVal As Integer = 0
                    If Integer.TryParse(cmbRoomFilter.SelectedValue.ToString(), selectedVal) AndAlso selectedVal > 0 Then
                        cmd.Parameters.AddWithValue("@filterRoom", selectedVal)
                    End If
                End If

                If applyDayFilter Then
                    cmd.Parameters.AddWithValue("@filterDay", selectedDayText)
                End If

                If txtSearchSchedule IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtSearchSchedule.Text) AndAlso txtSearchSchedule.Text <> "Search..." Then
                    cmd.Parameters.AddWithValue("@search", "%" & txtSearchSchedule.Text.Trim() & "%")
                End If

                Dim dataAdapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                dataAdapter.Fill(dt)

                dgvSchedule.DataSource = dt

                If Not dgvSchedule.Columns.Contains("Edit") Then
                    OptionsEditColumn()
                End If

                If Not dgvSchedule.Columns.Contains("Delete") Then
                    OptionsDeleteColumn()
                End If

                For Each row As DataGridViewRow In dgvSchedule.Rows
                    row.Cells("Edit").Value = My.Resources.edit_icon
                    row.Cells("Delete").Value = My.Resources.delete_icon
                Next

                Dim isDarkTheme As Boolean = Toggle1 IsNot Nothing AndAlso Toggle1.Checked
                Dim gridBg As Color = If(isDarkTheme, Color.FromArgb(45, 45, 45), Color.White)
                Dim gridAltBg As Color = If(isDarkTheme, Color.FromArgb(35, 35, 35), Color.FromArgb(248, 249, 250))
                Dim gridText As Color = If(isDarkTheme, Color.White, Color.FromArgb(50, 50, 50))
                Dim gridLine As Color = If(isDarkTheme, Color.FromArgb(60, 60, 60), Color.FromArgb(235, 238, 241))
                Dim gridHeaderBg As Color = If(isDarkTheme, Color.FromArgb(50, 50, 50), Color.FromArgb(240, 242, 245))

                With dgvSchedule
                    .BorderStyle = BorderStyle.None
                    .AlternatingRowsDefaultCellStyle.BackColor = gridAltBg
                    .AlternatingRowsDefaultCellStyle.ForeColor = gridText
                    .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                    .DefaultCellStyle.SelectionBackColor = If(isDarkTheme, Color.FromArgb(60, 60, 60), Color.FromArgb(225, 228, 232))
                    .DefaultCellStyle.SelectionForeColor = gridText
                    .BackgroundColor = gridBg
                    .GridColor = gridLine
                    .RowHeadersVisible = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .MultiSelect = False
                    .ReadOnly = True
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .AllowUserToResizeRows = False
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .EnableHeadersVisualStyles = False
                    .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                    .ColumnHeadersHeight = 28
                    .ColumnHeadersDefaultCellStyle.BackColor = gridHeaderBg
                    .ColumnHeadersDefaultCellStyle.ForeColor = gridText
                    .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
                    .RowTemplate.Height = 25
                    .DefaultCellStyle.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular)
                    .DefaultCellStyle.ForeColor = gridText
                    .DefaultCellStyle.BackColor = gridBg
                    .DefaultCellStyle.Padding = New Padding(1, 0, 1, 0)

                    If .Columns.Contains("ID") Then .Columns("ID").Visible = False
                    If .Columns.Contains("InstructorID") Then .Columns("InstructorID").Visible = False

                    If .Columns.Contains("Day") Then .Columns("Day").FillWeight = 70
                    If .Columns.Contains("Time") Then .Columns("Time").FillWeight = 95
                    If .Columns.Contains("Room/Lab") Then .Columns("Room/Lab").FillWeight = 65
                    If .Columns.Contains("Subject") Then .Columns("Subject").FillWeight = 65
                    If .Columns.Contains("Instructor") Then .Columns("Instructor").FillWeight = 100
                    If .Columns.Contains("Status") Then
                        .Columns("Status").FillWeight = 70
                        .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If

                    If .Columns.Contains("Edit") Then
                        .Columns("Edit").FillWeight = 32
                        .Columns("Edit").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        .Columns("Edit").Width = 32
                    End If

                    If .Columns.Contains("Delete") Then
                        .Columns("Delete").FillWeight = 35
                        .Columns("Delete").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        .Columns("Delete").Width = 35
                        .Columns("Delete").MinimumWidth = 35
                    End If
                End With

                For Each col As DataGridViewColumn In dgvSchedule.Columns
                    col.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                dgvSchedule.ClearSelection()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading schedules from database: " & ex.Message)
        End Try
    End Sub

    Private Sub chkMySchedule_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkMySchedule.CheckedChanged
        LoadScheduleFromDatabase()
    End Sub

    Private Sub OptionsEditColumn()
        Dim imgEdit As New DataGridViewImageColumn()
        imgEdit.Name = "Edit"
        imgEdit.HeaderText = "Edit"
        imgEdit.ImageLayout = DataGridViewImageCellLayout.Normal
        imgEdit.Width = 35
        dgvSchedule.Columns.Add(imgEdit)
    End Sub

    Private Sub OptionsDeleteColumn()
        Dim imgDelete As New DataGridViewImageColumn()
        imgDelete.Name = "Delete"
        imgDelete.HeaderText = "Delete"
        imgDelete.ImageLayout = DataGridViewImageCellLayout.Normal
        imgDelete.Width = 35
        dgvSchedule.Columns.Add(imgDelete)
    End Sub

    Private Sub dgvSchedule_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvSchedule.CellPainting
        If e.RowIndex >= 0 AndAlso dgvSchedule.Columns(e.ColumnIndex).Name = "Status" Then
            Dim isSelected As Boolean = (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected
            Dim cellBackColor As Color = If(isSelected, dgvSchedule.DefaultCellStyle.SelectionBackColor, e.CellStyle.BackColor)

            Using bgBrush As New SolidBrush(cellBackColor)
                e.Graphics.FillRectangle(bgBrush, e.CellBounds)
            End Using

            e.Paint(e.CellBounds, DataGridViewPaintParts.Border)

            Dim val As String = Convert.ToString(e.Value)
            If Not String.IsNullOrEmpty(val) Then
                Dim backColor As Color = Color.White
                Dim foreColor As Color = Color.Black

                If val.Equals("Dismissed", StringComparison.OrdinalIgnoreCase) Then
                    backColor = Color.FromArgb(220, 224, 230)
                    foreColor = Color.FromArgb(90, 95, 105)
                ElseIf val.Equals("On going", StringComparison.OrdinalIgnoreCase) Then
                    backColor = Color.FromArgb(209, 226, 255)
                    foreColor = Color.FromArgb(20, 80, 160)
                ElseIf val.Equals("Scheduled", StringComparison.OrdinalIgnoreCase) Then
                    backColor = Color.FromArgb(255, 243, 205)
                    foreColor = Color.FromArgb(140, 95, 0)
                End If

                Dim rect As Rectangle = e.CellBounds
                rect.Inflate(-3, -4)

                Using path As New System.Drawing.Drawing2D.GraphicsPath()
                    Dim radius As Integer = 4
                    path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
                    path.AddArc(rect.Right - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90)
                    path.AddArc(rect.Right - (radius * 2), rect.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90)
                    path.AddArc(rect.X, rect.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90)
                    path.CloseFigure()

                    Using brush As New SolidBrush(backColor)
                        e.Graphics.FillPath(brush, path)
                    End Using
                End Using

                Using sf As New StringFormat()
                    sf.Alignment = StringAlignment.Center
                    sf.LineAlignment = StringAlignment.Center
                    Using boldFont As New Font("Segoe UI", 7.5F, FontStyle.Bold)
                        Using textBrush As New SolidBrush(foreColor)
                            e.Graphics.DrawString(val, boldFont, textBrush, rect, sf)
                        End Using
                    End Using
                End Using
            End If

            e.Handled = True
        End If
    End Sub

    Public Sub LoadRoomsData()
        Try
            Dim query As String = "SELECT room_id AS 'ID', room_name AS 'Room Name', room_type AS 'Room Type', capacity AS 'Capacity', status AS 'Status' FROM tbl_classrooms WHERE 1=1"

            If txtSearchRoom IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtSearchRoom.Text) AndAlso txtSearchRoom.Text <> "Search..." Then
                query &= " AND room_name LIKE @search"
            End If

            query &= " ORDER BY room_name ASC"

            Using cmd As New MySqlCommand(query, conn)
                If txtSearchRoom IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtSearchRoom.Text) AndAlso txtSearchRoom.Text <> "Search..." Then
                    cmd.Parameters.AddWithValue("@search", "%" & txtSearchRoom.Text.Trim() & "%")
                End If

                Dim dataAdapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                dataAdapter.Fill(dt)

                dgvRooms.DataSource = dt

                If Not dgvRooms.Columns.Contains("EditRoom") Then
                    Dim imgEdit As New DataGridViewImageColumn()
                    imgEdit.Name = "EditRoom"
                    imgEdit.HeaderText = "Edit"
                    imgEdit.ImageLayout = DataGridViewImageCellLayout.Normal
                    dgvRooms.Columns.Add(imgEdit)
                End If

                If Not dgvRooms.Columns.Contains("DeleteRoom") Then
                    Dim imgDelete As New DataGridViewImageColumn()
                    imgDelete.Name = "DeleteRoom"
                    imgDelete.HeaderText = "Delete"
                    imgDelete.ImageLayout = DataGridViewImageCellLayout.Normal
                    dgvRooms.Columns.Add(imgDelete)
                End If

                For Each row As DataGridViewRow In dgvRooms.Rows
                    row.Cells("EditRoom").Value = My.Resources.edit_icon
                    row.Cells("DeleteRoom").Value = My.Resources.delete_icon
                Next

                Dim isDarkTheme As Boolean = Toggle1 IsNot Nothing AndAlso Toggle1.Checked
                Dim gridBg As Color = If(isDarkTheme, Color.FromArgb(45, 45, 45), Color.White)
                Dim gridAltBg As Color = If(isDarkTheme, Color.FromArgb(35, 35, 35), Color.FromArgb(248, 249, 250))
                Dim gridText As Color = If(isDarkTheme, Color.White, Color.FromArgb(50, 50, 50))
                Dim gridLine As Color = If(isDarkTheme, Color.FromArgb(60, 60, 60), Color.FromArgb(235, 238, 241))
                Dim gridHeaderBg As Color = If(isDarkTheme, Color.FromArgb(50, 50, 50), Color.FromArgb(240, 242, 245))

                With dgvRooms
                    .BorderStyle = BorderStyle.None
                    .AlternatingRowsDefaultCellStyle.BackColor = gridAltBg
                    .AlternatingRowsDefaultCellStyle.ForeColor = gridText
                    .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                    .DefaultCellStyle.SelectionBackColor = If(isDarkTheme, Color.FromArgb(60, 60, 60), Color.FromArgb(225, 228, 232))
                    .DefaultCellStyle.SelectionForeColor = gridText
                    .BackgroundColor = gridBg
                    .GridColor = gridLine
                    .RowHeadersVisible = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .MultiSelect = False
                    .ReadOnly = True
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .AllowUserToResizeRows = False
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .EnableHeadersVisualStyles = False
                    .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                    .ColumnHeadersHeight = 42
                    .ColumnHeadersDefaultCellStyle.BackColor = gridHeaderBg
                    .ColumnHeadersDefaultCellStyle.ForeColor = gridText
                    .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
                    .RowTemplate.Height = 38
                    .DefaultCellStyle.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular)
                    .DefaultCellStyle.ForeColor = gridText
                    .DefaultCellStyle.BackColor = gridBg
                    .DefaultCellStyle.Padding = New Padding(2, 0, 2, 0)

                    If .Columns.Contains("ID") Then
                        .Columns("ID").Visible = False
                    End If

                    If .Columns.Contains("Room Name") Then .Columns("Room Name").FillWeight = 110
                    If .Columns.Contains("Room Type") Then .Columns("Room Type").FillWeight = 110
                    If .Columns.Contains("Capacity") Then .Columns("Capacity").FillWeight = 60
                    If .Columns.Contains("Status") Then .Columns("Status").FillWeight = 75

                    If .Columns.Contains("Capacity") Then
                        .Columns("Capacity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("Capacity").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If

                    If .Columns.Contains("Status") Then
                        .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If

                    If .Columns.Contains("EditRoom") Then
                        .Columns("EditRoom").FillWeight = 50
                        .Columns("EditRoom").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        .Columns("EditRoom").Width = 50
                    End If
                    If .Columns.Contains("DeleteRoom") Then
                        .Columns("DeleteRoom").FillWeight = 50
                        .Columns("DeleteRoom").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        .Columns("DeleteRoom").Width = 50
                        .Columns("DeleteRoom").MinimumWidth = 50
                    End If
                End With

                For Each col As DataGridViewColumn In dgvRooms.Columns
                    col.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                dgvRooms.ClearSelection()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading rooms data: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbDayFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDayFilter.SelectedIndexChanged
        LoadScheduleFromDatabase()
    End Sub

    Private Sub dgvSchedule_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvSchedule.CellClick
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = dgvSchedule.Columns("Edit").Index OrElse e.ColumnIndex = dgvSchedule.Columns("Delete").Index Then
            Dim scheduleId As Integer = Convert.ToInt32(dgvSchedule.Rows(e.RowIndex).Cells("ID").Value)

            Dim instructorId As Integer = 0
            Try
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim checkQuery As String = "SELECT instructor_id FROM tbl_schedules WHERE schedule_id = @id"
                Using cmdCheck As New MySqlCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@id", scheduleId)
                    Dim result = cmdCheck.ExecuteScalar()
                    If result IsNot Nothing Then
                        instructorId = Convert.ToInt32(result)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                Return
            End Try

            Dim currentUserRole As String = If(GlobalSession.UserRole Is Nothing, "", GlobalSession.UserRole.Trim())
            Dim currentUserId As Integer = GlobalSession.UserId

            Dim isAdmin As Boolean = currentUserRole.IndexOf("Admin", StringComparison.OrdinalIgnoreCase) >= 0
            Dim isOwner As Boolean = (instructorId = currentUserId)

            If Not (isAdmin OrElse isOwner) Then
                MessageBox.Show("You do not have permission to modify or delete this schedule.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If e.ColumnIndex = dgvSchedule.Columns("Edit").Index Then
                Dim editForm As New AddEditScheduleForm()
                editForm.ScheduleId = scheduleId
                If editForm.ShowDialog() = DialogResult.OK Then
                    LoadScheduleFromDatabase()
                    LoadTodaysSchedule()
                    LoadDashboardMetrics()
                    LoadRoomChart()
                    LoadAvailabilityData()
                    LoadConflictsData()
                End If
            ElseIf e.ColumnIndex = dgvSchedule.Columns("Delete").Index Then
                If MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        If conn.State <> ConnectionState.Open Then
                            conn.Open()
                        End If

                        Dim query As String = "DELETE FROM tbl_schedules WHERE schedule_id = @id"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@id", scheduleId)
                            cmd.ExecuteNonQuery()
                        End Using

                        LoadScheduleFromDatabase()
                        LoadTodaysSchedule()
                        LoadDashboardMetrics()
                        LoadRoomChart()
                        LoadAvailabilityData()
                        LoadConflictsData()

                        InsertLog("Delete Schedule", "Deleted schedule ID " & scheduleId)
                    Catch ex As Exception
                        MessageBox.Show("Error deleting schedule: " & ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnAddSched_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddSched.Click
        Dim addForm As New AddEditScheduleForm()
        If addForm.ShowDialog() = DialogResult.OK Then
            LoadScheduleFromDatabase()
            LoadTodaysSchedule()
            LoadDashboardMetrics()
            LoadRoomChart()
            LoadAvailabilityData()
            LoadConflictsData()
        End If
    End Sub

    Private Sub cmbRoomFilter_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbRoomFilter.SelectedIndexChanged
        LoadScheduleFromDatabase()
    End Sub

    Private Sub txtSearchSchedule_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearchSchedule.TextChanged
        LoadScheduleFromDatabase()
    End Sub

    Private Sub txtSearchRoom_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearchRoom.TextChanged
        LoadRoomsData()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        UpdateDateTimeDisplay()
    End Sub

    Private Sub UpdateDateTimeDisplay()
        lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy") & Environment.NewLine & DateTime.Now.ToString("dddd")
    End Sub

    Private Sub ShowView(ByVal targetPanel As Panel)
        pnlDashboardView.Visible = False
        pnlScheduleView.Visible = False
        pnlRoomsView.Visible = False
        pnlAvailabilityView.Visible = False
        pnlConflictsView.Visible = False

        targetPanel.Visible = True
        targetPanel.BringToFront()
    End Sub

    Private Sub SetupNavButtons()
        Dim navButtons As Button() = New Button() {btnDashboard, btnSchedule, btnRooms, btnAvailability, btnConflicts}
        For Each btn As Button In navButtons
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 210, 210)
        Next
    End Sub

    Private Sub HighlightActiveButton(ByVal activeButton As Button)
        Dim navButtons As Button() = New Button() {btnDashboard, btnSchedule, btnRooms, btnAvailability, btnConflicts}

        For Each btn As Button In navButtons
            If btn Is activeButton Then
                btn.BackColor = Color.FromArgb(190, 190, 190)
            Else
                btn.BackColor = Color.Transparent
            End If
        Next
    End Sub

    Private Sub btnDashboard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDashboard.Click
        ShowView(pnlDashboardView)
        HighlightActiveButton(btnDashboard)
        LoadDashboardMetrics()
        LoadTodaysSchedule()
        LoadRoomChart()
    End Sub

    Private Sub btnSchedule_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSchedule.Click
        ShowView(pnlScheduleView)
        HighlightActiveButton(btnSchedule)
        LoadScheduleFromDatabase()
    End Sub

    Private Sub btnRooms_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRooms.Click
        ShowView(pnlRoomsView)
        HighlightActiveButton(btnRooms)
        LoadRoomsData()
    End Sub

    Private Sub btnAvailability_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAvailability.Click
        ShowView(pnlAvailabilityView)
        HighlightActiveButton(btnAvailability)
        LoadAvailabilityData()
    End Sub

    Private Sub btnConflicts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConflicts.Click
        Dim currentUserRole As String = If(GlobalSession.UserRole Is Nothing, "", GlobalSession.UserRole.Trim())
        Dim isAdmin As Boolean = currentUserRole.IndexOf("Admin", StringComparison.OrdinalIgnoreCase) >= 0

        If Not isAdmin Then
            MessageBox.Show("No access for this panel. This section is restricted to administrators only.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ShowView(pnlConflictsView)
        HighlightActiveButton(btnConflicts)
        LoadConflictsData()
    End Sub

    Private Sub LoadDashboardMetrics()
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim queryTotal As String = "SELECT COUNT(*) FROM tbl_classrooms"
            Dim cmdTotal As New MySqlCommand(queryTotal, conn)
            Dim totalRooms As Integer = Convert.ToInt32(cmdTotal.ExecuteScalar())
            lblTotalRoomsCount.Text = totalRooms.ToString()

            Dim currentDay As String = DateTime.Now.ToString("dddd")
            Dim currentTime As String = DateTime.Now.ToString("HH:mm:ss")

            Dim queryConflicts As String = "SELECT COUNT(DISTINCT s1.room_id) FROM tbl_schedules s1 JOIN tbl_schedules s2 ON s1.room_id = s2.room_id AND s1.day_of_week = s2.day_of_week AND s1.schedule_id <> s2.schedule_id AND s1.time_start < s2.time_end AND s1.time_end > s2.time_start WHERE s1.day_of_week = @day"
            Using cmdConflicts As New MySqlCommand(queryConflicts, conn)
                cmdConflicts.Parameters.AddWithValue("@day", currentDay)
                Dim conflictsCount As Integer = Convert.ToInt32(cmdConflicts.ExecuteScalar())
                lblConflictsCount.Text = conflictsCount.ToString()
            End Using

            Dim queryOccupied As String = "SELECT COUNT(DISTINCT room_id) FROM tbl_schedules WHERE day_of_week = @day AND @time BETWEEN time_start AND time_end AND room_id NOT IN (SELECT DISTINCT s1.room_id FROM tbl_schedules s1 JOIN tbl_schedules s2 ON s1.room_id = s2.room_id AND s1.day_of_week = s2.day_of_week AND s1.schedule_id <> s2.schedule_id AND s1.time_start < s2.time_end AND s1.time_end > s2.time_start WHERE s1.day_of_week = @day)"
            Using cmdOccupied As New MySqlCommand(queryOccupied, conn)
                cmdOccupied.Parameters.AddWithValue("@day", currentDay)
                cmdOccupied.Parameters.AddWithValue("@time", currentTime)
                Dim occupiedRooms As Integer = Convert.ToInt32(cmdOccupied.ExecuteScalar())
                lblOccupiedCount.Text = occupiedRooms.ToString()
            End Using

            Dim confCnt As Integer = Convert.ToInt32(lblConflictsCount.Text)
            Dim occCnt As Integer = Convert.ToInt32(lblOccupiedCount.Text)

            Dim availableRooms As Integer = totalRooms - (occCnt + confCnt)
            If availableRooms < 0 Then availableRooms = 0
            lblAvailableCount.Text = availableRooms.ToString()

            If chartRoomOverview.Series.IndexOf("RoomStatus") >= 0 Then
                chartRoomOverview.Series("RoomStatus").Points.Clear()
                chartRoomOverview.Series("RoomStatus").Points.AddXY("Occupied", occCnt)
                chartRoomOverview.Series("RoomStatus").Points.AddXY("Available", availableRooms)
                chartRoomOverview.Series("RoomStatus").Points.AddXY("Conflict", confCnt)
            End If

        Catch ex As Exception
            MessageBox.Show("Dashboard Load Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTodaysSchedule()
        Try
            Dim todayName As String = DateTime.Now.ToString("dddd")

            Dim query As String = "SELECT CONCAT(LOWER(TIME_FORMAT(s.time_start, '%l:%i')), ' - ', LOWER(TIME_FORMAT(s.time_end, '%l:%i%p'))) AS 'Time', " & _
                                  "c.room_name AS 'Room/Lab', " & _
                                  "s.subject_code AS 'Subject', " & _
                                  "u.full_name AS 'Instructor', " & _
                                  "CASE " & _
                                  "   WHEN CURTIME() > s.time_end THEN 'Dismissed' " & _
                                  "   WHEN CURTIME() BETWEEN s.time_start AND s.time_end THEN 'On going' " & _
                                  "   ELSE 'Scheduled' " & _
                                  "END AS 'Status' " & _
                                  "FROM tbl_schedules s " & _
                                  "JOIN tbl_classrooms c ON s.room_id = c.room_id " & _
                                  "JOIN tbl_users u ON s.instructor_id = u.user_id " & _
                                  "WHERE s.day_of_week = @today " & _
                                  "ORDER BY s.time_start ASC"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@today", todayName)
                Dim dataAdapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                dataAdapter.Fill(dt)

                dgvTodaysSchedule.DataSource = dt

                If dgvTodaysSchedule.Columns.Count >= 5 Then
                    dgvTodaysSchedule.Columns("Time").FillWeight = 25
                    dgvTodaysSchedule.Columns("Room/Lab").FillWeight = 16
                    dgvTodaysSchedule.Columns("Subject").FillWeight = 16
                    dgvTodaysSchedule.Columns("Instructor").FillWeight = 28
                    dgvTodaysSchedule.Columns("Status").FillWeight = 15
                    dgvTodaysSchedule.Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgvTodaysSchedule.Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End If

                For Each col As DataGridViewColumn In dgvTodaysSchedule.Columns
                    col.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                dgvTodaysSchedule.ClearSelection()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading schedule: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvTodaysSchedule_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvTodaysSchedule.CellPainting
        If e.RowIndex >= 0 AndAlso dgvTodaysSchedule.Columns(e.ColumnIndex).Name = "Status" Then
            Dim cellBackColor As Color = e.CellStyle.BackColor
            If (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected Then
                cellBackColor = dgvTodaysSchedule.DefaultCellStyle.SelectionBackColor
            ElseIf e.RowIndex Mod 2 = 1 AndAlso dgvTodaysSchedule.AlternatingRowsDefaultCellStyle.BackColor.IsEmpty = False Then
                cellBackColor = dgvTodaysSchedule.AlternatingRowsDefaultCellStyle.BackColor
            End If

            Using bgBrush As New SolidBrush(cellBackColor)
                e.Graphics.FillRectangle(bgBrush, e.CellBounds)
            End Using

            e.Paint(e.CellBounds, DataGridViewPaintParts.Border)

            Dim val As String = Convert.ToString(e.Value)
            If Not String.IsNullOrEmpty(val) Then
                Dim backColor As Color = Color.White
                Dim foreColor As Color = Color.Black

                If val.Equals("Dismissed", StringComparison.OrdinalIgnoreCase) Then
                    backColor = Color.FromArgb(220, 224, 230)
                    foreColor = Color.FromArgb(90, 95, 105)
                ElseIf val.Equals("On going", StringComparison.OrdinalIgnoreCase) Then
                    backColor = Color.FromArgb(209, 226, 255)
                    foreColor = Color.FromArgb(20, 80, 160)
                ElseIf val.Equals("Scheduled", StringComparison.OrdinalIgnoreCase) Then
                    backColor = Color.FromArgb(255, 243, 205)
                    foreColor = Color.FromArgb(140, 95, 0)
                End If

                Dim rect As Rectangle = e.CellBounds
                rect.Inflate(-4, -5)

                Using path As New System.Drawing.Drawing2D.GraphicsPath()
                    Dim radius As Integer = 5
                    path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
                    path.AddArc(rect.Right - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90)
                    path.AddArc(rect.Right - (radius * 2), rect.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90)
                    path.AddArc(rect.X, rect.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90)
                    path.CloseFigure()

                    Using brush As New SolidBrush(backColor)
                        e.Graphics.FillPath(brush, path)
                    End Using
                End Using

                Using sf As New StringFormat()
                    sf.Alignment = StringAlignment.Center
                    sf.LineAlignment = StringAlignment.Center
                    Using boldFont As New Font("Segoe UI", 7.5F, FontStyle.Bold)
                        Using textBrush As New SolidBrush(foreColor)
                            e.Graphics.DrawString(val, boldFont, textBrush, rect, sf)
                        End Using
                    End Using
                End Using
            End If

            e.Handled = True
        End If
    End Sub

    Private Sub pnlUserProfileCard_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles pnlUserProfileCard.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim isDark As Boolean = Toggle1 IsNot Nothing AndAlso Toggle1.Checked
        Dim penColor As Color = If(isDark, Color.FromArgb(80, 80, 80), Color.FromArgb(170, 170, 170))

        Using pen As New Pen(penColor, 1.5F)
            Dim rect As New Rectangle(0, 0, pnlUserProfileCard.Width - 1, pnlUserProfileCard.Height - 1)
            Dim radius As Integer = 25

            Dim path As New GraphicsPath()
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90)
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90)
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90)
            path.CloseAllFigures()

            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub

    Private Sub LoadRoomChart()
        Try
            chartRoomOverview.Series.Clear()
            chartRoomOverview.Legends.Clear()
            chartRoomOverview.Titles.Clear()

            Dim isDark As Boolean = Toggle1 IsNot Nothing AndAlso Toggle1.Checked
            Dim chartBg As Color = If(isDark, Color.FromArgb(45, 45, 45), Color.FromArgb(240, 240, 240))
            Dim legendFore As Color = If(isDark, Color.White, Color.Black)

            chartRoomOverview.BackColor = chartBg
            If chartRoomOverview.ChartAreas.Count > 0 Then
                chartRoomOverview.ChartAreas(0).BackColor = Color.Transparent
            End If

            Dim legend As New Legend("Default")
            legend.Docking = Docking.Right
            legend.Alignment = StringAlignment.Center
            legend.LegendStyle = LegendStyle.Column
            legend.BackColor = Color.Transparent
            legend.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
            legend.ForeColor = legendFore
            legend.InterlacedRows = False
            chartRoomOverview.Legends.Add(legend)

            Dim series As New Series("RoomStatus")
            series.ChartType = SeriesChartType.Doughnut
            series("DoughnutRadius") = "58"
            series("PieLabelStyle") = "Disabled"
            series.IsValueShownAsLabel = False

            Dim occupied As Integer = 0
            Dim available As Integer = 0
            Dim conflicts As Integer = 0

            Integer.TryParse(lblOccupiedCount.Text, occupied)
            Integer.TryParse(lblAvailableCount.Text, available)
            Integer.TryParse(lblConflictsCount.Text, conflicts)

            series.Points.AddXY("Occupied", occupied)
            series.Points.AddXY("Available", available)
            series.Points.AddXY("Conflict", conflicts)

            series.Points(0).Color = Color.FromArgb(202, 60, 52)
            series.Points(1).Color = Color.FromArgb(93, 150, 112)
            series.Points(2).Color = Color.FromArgb(210, 175, 45)

            chartRoomOverview.Series.Add(series)

            RemoveHandler chartRoomOverview.PostPaint, AddressOf Chart_PostPaint
            AddHandler chartRoomOverview.PostPaint, AddressOf Chart_PostPaint

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Chart_PostPaint(ByVal sender As Object, ByVal e As ChartPaintEventArgs)
        If TypeOf sender Is ChartArea Then Exit Sub

        Dim totalRooms As Integer = 0
        Dim occupied As Integer = 0
        Dim available As Integer = 0
        Dim conflicts As Integer = 0

        Integer.TryParse(lblOccupiedCount.Text, occupied)
        Integer.TryParse(lblAvailableCount.Text, available)
        Integer.TryParse(lblConflictsCount.Text, conflicts)
        totalRooms = occupied + available + conflicts

        If chartRoomOverview.ChartAreas.Count > 0 Then
            Dim ca As ChartArea = chartRoomOverview.ChartAreas(0)
            Dim rect As RectangleF = e.ChartGraphics.GetAbsoluteRectangle(ca.Position.ToRectangleF())

            Dim centerX As Single = rect.Left + (rect.Width * 0.5F)
            Dim centerY As Single = rect.Top + (rect.Height * 0.5F)

            Dim countText As String = totalRooms.ToString()
            Dim subText As String = "Rooms"

            Dim isDark As Boolean = Toggle1 IsNot Nothing AndAlso Toggle1.Checked
            Dim textCol As Color = If(isDark, Color.White, Color.Black)

            Using fontCount As New Font("Segoe UI", 14.0F, FontStyle.Bold)
                Using fontSub As New Font("Segoe UI", 11.0F, FontStyle.Bold)
                    Using brush As New SolidBrush(textCol)
                        Dim sf As New StringFormat()
                        sf.Alignment = StringAlignment.Center
                        sf.LineAlignment = StringAlignment.Center

                        e.ChartGraphics.Graphics.DrawString(countText, fontCount, brush, centerX, centerY - 10, sf)
                        e.ChartGraphics.Graphics.DrawString(subText, fontSub, brush, centerX, centerY + 10, sf)
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub FormatScheduleGrid()
        Dim isDark As Boolean = Toggle1 IsNot Nothing AndAlso Toggle1.Checked
        Dim gridBg As Color = If(isDark, Color.FromArgb(45, 45, 45), Color.White)
        Dim gridText As Color = If(isDark, Color.White, Color.FromArgb(50, 50, 50))
        Dim gridLine As Color = If(isDark, Color.FromArgb(60, 60, 60), Color.FromArgb(235, 238, 241))

        With dgvTodaysSchedule
            .BorderStyle = BorderStyle.None
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .BackgroundColor = gridBg
            .GridColor = gridLine
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False

            .EnableHeadersVisualStyles = False
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
            .ColumnHeadersHeight = 28
            .ColumnHeadersDefaultCellStyle.BackColor = If(isDark, Color.FromArgb(50, 50, 50), Color.FromArgb(240, 242, 245))
            .ColumnHeadersDefaultCellStyle.ForeColor = gridText
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)

            .RowTemplate.Height = 26
            .DefaultCellStyle.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular)
            .DefaultCellStyle.ForeColor = gridText
            .DefaultCellStyle.BackColor = gridBg
            .DefaultCellStyle.Padding = New Padding(2, 0, 2, 0)

            .DefaultCellStyle.SelectionBackColor = If(isDark, Color.FromArgb(60, 60, 60), Color.FromArgb(225, 228, 232))
            .DefaultCellStyle.SelectionForeColor = gridText

            .AlternatingRowsDefaultCellStyle.BackColor = If(isDark, Color.FromArgb(35, 35, 35), Color.FromArgb(248, 249, 250))
            .AlternatingRowsDefaultCellStyle.ForeColor = gridText
        End With
    End Sub

    Private Sub btnLogout_Click(ByVal sender As Object, ByVal e As EventArgs)


    End Sub

    Private Sub btnViewAll_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles btnViewAll.LinkClicked
        btnSchedule.PerformClick()
    End Sub

    Private Sub ApplyRoundedRegion(ByVal ctrl As Control, ByVal radius As Integer)
        If ctrl Is Nothing OrElse ctrl.Width <= 0 OrElse ctrl.Height <= 0 Then Return

        Dim path As New GraphicsPath()
        path.AddArc(ctrl.ClientRectangle.X, ctrl.ClientRectangle.Y, radius, radius, 180, 90)
        path.AddArc(ctrl.ClientRectangle.Width - radius, ctrl.ClientRectangle.Y, radius, radius, 270, 90)
        path.AddArc(ctrl.ClientRectangle.Width - radius, ctrl.ClientRectangle.Height - radius, radius, radius, 0, 90)
        path.AddArc(ctrl.ClientRectangle.X, ctrl.ClientRectangle.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        ctrl.Region = New Region(path)
    End Sub

    Private Sub ApplyCircularRegion(ByVal picBox As PictureBox)
        If picBox Is Nothing OrElse picBox.Width <= 0 OrElse picBox.Height <= 0 Then Return
        Dim path As New GraphicsPath()
        path.AddEllipse(picBox.ClientRectangle)
        picBox.Region = New Region(path)
    End Sub

    Private Sub ApplyAllRoundedCorners()
        Dim cornerRadius As Integer = 20

        ApplyRoundedRegion(pnlTotalRooms, cornerRadius)
        ApplyRoundedRegion(pnlAvailable, cornerRadius)
        ApplyRoundedRegion(pnlOccupied, cornerRadius)
        ApplyRoundedRegion(pnlConflicts, cornerRadius)
        ApplyRoundedRegion(btnDashboard, 15)
        ApplyRoundedRegion(btnSchedule, 15)
        ApplyRemainingRegions()
    End Sub

    Private Sub ApplyRemainingRegions()
        Dim cornerRadius As Integer = 20
        ApplyRoundedRegion(btnRooms, 15)
        ApplyRoundedRegion(btnAvailability, 15)
        ApplyRoundedRegion(btnConflicts, 15)

        ApplyRoundedRegion(pnlScheduleContainer, cornerRadius)
        ApplyRoundedRegion(pnlChartContainer, cornerRadius)

        ApplyRoundedRegion(pnlUserProfileCard, 25)
        ApplyCircularRegion(picUserProfile)

        ApplyRoundedRegion(pnlDate, 15)
        ApplyRoundedRegion(pnlDropRoom, 15)
        ApplyRoundedRegion(pnlSearchContainer, 15)
        ApplyRoundedRegion(pnlAddSched, 15)
        ApplyRoundedRegion(pnlSchedConflicts, 15)
        ApplyRoundedRegion(pnlSchedMan, 15)
        ApplyRoundedRegion(pnlClassroomAvail, 15)
        ApplyRoundedRegion(pnlRoomManagement, 15)
        ApplyRoundedRegion(pnlSearchRoomContainer, 15)
        ApplyRoundedRegion(pnlAddRoom, 15)
        ApplyRoundedRegion(pnlDay, 15)
        ApplyRoundedRegion(pnlRoomType, 15)
        ApplyRoundedRegion(pnlSearch, 15)
        ApplyRoundedRegion(pnlCheckbox, 15)
        ApplyRoundedRegion(pnlNormal, 15)
    End Sub

    Private Sub LoadUserProfile()
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim query As String = "SELECT full_name FROM tbl_users WHERE user_id = @userId"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@userId", GlobalSession.UserId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        lblUserName.Text = reader("full_name").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user profile: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvRooms_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvRooms.CellClick
        If e.RowIndex < 0 Then Return

        If e.ColumnIndex = dgvRooms.Columns("EditRoom").Index OrElse e.ColumnIndex = dgvRooms.Columns("DeleteRoom").Index Then
            Dim currentUserRole As String = If(GlobalSession.UserRole Is Nothing, "", GlobalSession.UserRole.Trim())
            Dim isAdmin As Boolean = currentUserRole.IndexOf("Admin", StringComparison.OrdinalIgnoreCase) >= 0

            If Not isAdmin Then
                MessageBox.Show("Access Denied: Only administrators can modify or delete rooms.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim roomId As Integer = Convert.ToInt32(dgvRooms.Rows(e.RowIndex).Cells("ID").Value)

            If e.ColumnIndex = dgvRooms.Columns("EditRoom").Index Then
                Dim editForm As New AddEditRoomForm()
                editForm.RoomId = roomId
                If editForm.ShowDialog() = DialogResult.OK Then
                    LoadRoomsData()
                    LoadRoomDropdown()
                    LoadDashboardMetrics()
                    LoadRoomChart()
                    LoadAvailabilityData()
                End If
            ElseIf e.ColumnIndex = dgvRooms.Columns("DeleteRoom").Index Then
                If MessageBox.Show("Are you sure you want to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        If conn.State <> ConnectionState.Open Then conn.Open()
                        Dim query As String = "DELETE FROM tbl_classrooms WHERE room_id = @id"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@id", roomId)
                            cmd.ExecuteNonQuery()
                        End Using

                        LoadRoomsData()
                        LoadRoomDropdown()
                        LoadDashboardMetrics()
                        LoadRoomChart()
                        LoadAvailabilityData()
                        LoadConflictsData()

                        InsertLog("Delete Room", "Deleted room ID " & roomId)
                    Catch ex As Exception
                        MessageBox.Show("Error deleting room: " & ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnAddRoom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddRoom.Click
        Dim currentUserRole As String = If(GlobalSession.UserRole Is Nothing, "", GlobalSession.UserRole.Trim())
        Dim isAdmin As Boolean = currentUserRole.IndexOf("Admin", StringComparison.OrdinalIgnoreCase) >= 0

        If Not isAdmin Then
            MessageBox.Show("Access Denied: Only administrators can add rooms.", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim addForm As New AddEditRoomForm()
        If addForm.ShowDialog() = DialogResult.OK Then
            LoadRoomsData()
            LoadRoomDropdown()
            LoadDashboardMetrics()
            LoadRoomChart()
            LoadAvailabilityData()
        End If
    End Sub

    Private Sub dgvRooms_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvRooms.CellPainting
        If e.RowIndex >= 0 AndAlso dgvRooms.Columns(e.ColumnIndex).Name = "Status" Then
            Dim isSelected As Boolean = (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected
            Dim backColor As Color = If(isSelected, dgvRooms.DefaultCellStyle.SelectionBackColor, e.CellStyle.BackColor)

            Using bgBrush As New SolidBrush(backColor)
                e.Graphics.FillRectangle(bgBrush, e.CellBounds)
            End Using

            Using p As New Pen(dgvRooms.GridColor)
                e.Graphics.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1)
            End Using

            Dim val As String = If(e.Value IsNot Nothing, e.Value.ToString(), "")
            If Not String.IsNullOrEmpty(val) Then
                Dim g As Graphics = e.Graphics
                g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

                Dim bgColor As Color
                Dim textColor As Color

                Select Case val.ToLower()
                    Case "available", "working"
                        bgColor = Color.FromArgb(209, 238, 218)
                        textColor = Color.FromArgb(30, 110, 50)
                    Case "occupied", "not working"
                        bgColor = Color.FromArgb(248, 215, 218)
                        textColor = Color.FromArgb(160, 30, 30)
                    Case "maintenance"
                        bgColor = Color.FromArgb(255, 243, 205)
                        textColor = Color.FromArgb(140, 85, 0)
                    Case Else
                        bgColor = Color.LightGray
                        textColor = Color.Black
                End Select

                Dim rect As New Rectangle(e.CellBounds.X + 8, e.CellBounds.Y + 5, e.CellBounds.Width - 16, e.CellBounds.Height - 10)

                Using path As Drawing2D.GraphicsPath = GetRoundedRect(rect, 5)
                    Using brush As New SolidBrush(bgColor)
                        g.FillPath(brush, path)
                    End Using
                End Using

                Using boldFont As New Font("Segoe UI", 9.0F, FontStyle.Bold)
                    Using sf As New StringFormat()
                        sf.Alignment = StringAlignment.Center
                        sf.LineAlignment = StringAlignment.Center
                        Using brush As New SolidBrush(textColor)
                            g.DrawString(val, boldFont, brush, rect, sf)
                        End Using
                    End Using
                End Using
            End If

            e.Handled = True
        End If
    End Sub

    Private Function GetRoundedRect(ByVal rect As Rectangle, ByVal radius As Integer) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        Dim diameter As Integer = radius * 2
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub pnlRoomsView_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlRoomsView.Paint

    End Sub

    Private Sub pictureBoxUserManagement_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBoxUserManagement.Click
        Dim userForm As New UserManagementForm()
        userForm.ShowDialog()
    End Sub

    Public Sub LoadAvailabilityData()
        Try
            Dim query As String = "SELECT r.room_name AS 'Room Name', " & _
                                  "CASE WHEN (SELECT COUNT(*) FROM tbl_schedules s2 WHERE s2.room_id = r.room_id AND s2.day_of_week = @day AND s2.schedule_id <> s.schedule_id AND s.time_start < s2.time_end AND s.time_end > s2.time_start) > 0 THEN 'Conflict' " & _
                                  "WHEN s.schedule_id IS NOT NULL THEN 'Occupied' " & _
                                  "ELSE 'Available' END AS 'Status', " & _
                                  "COALESCE(CONCAT(TIME_FORMAT(s.time_start, '%h:%i %p'), ' - ', TIME_FORMAT(s.time_end, '%h:%i %p'), ' | ', s.subject_code), '-') AS 'Current Schedule', " & _
                                  "COALESCE(u.full_name, '-') AS 'Instructor' " & _
                                  "FROM tbl_classrooms r " & _
                                  "LEFT JOIN tbl_schedules s ON r.room_id = s.room_id AND s.day_of_week = @day AND CURTIME() BETWEEN s.time_start AND s.time_end " & _
                                  "LEFT JOIN tbl_users u ON s.instructor_id = u.user_id WHERE 1=1"

            If cmbFilterRoom IsNot Nothing AndAlso cmbFilterRoom.SelectedIndex > 0 Then
                query &= " AND r.room_id = @room_id"
            End If

            If txtSearchAvailability IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtSearchAvailability.Text) AndAlso txtSearchAvailability.Text <> "Search..." Then
                query &= " AND r.room_name LIKE @search"
            End If

            query &= " ORDER BY r.room_name ASC"

            Using cmd As New MySqlCommand(query, conn)
                Dim selectedDay As String = If(cmbDay IsNot Nothing AndAlso cmbDay.SelectedItem IsNot Nothing, cmbDay.SelectedItem.ToString(), DateTime.Now.DayOfWeek.ToString())
                cmd.Parameters.AddWithValue("@day", selectedDay)

                If cmbFilterRoom IsNot Nothing AndAlso cmbFilterRoom.SelectedIndex > 0 Then
                    cmd.Parameters.AddWithValue("@room_id", cmbFilterRoom.SelectedValue)
                End If

                If txtSearchAvailability IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtSearchAvailability.Text) AndAlso txtSearchAvailability.Text <> "Search..." Then
                    cmd.Parameters.AddWithValue("@search", "%" & txtSearchAvailability.Text.Trim() & "%")
                End If

                Dim dataAdapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                dataAdapter.Fill(dt)

                dgvAvailability.DataSource = dt

                Dim isDarkTheme As Boolean = Toggle1 IsNot Nothing AndAlso Toggle1.Checked
                Dim gridBg As Color = If(isDarkTheme, Color.FromArgb(45, 45, 45), Color.White)
                Dim gridAltBg As Color = If(isDarkTheme, Color.FromArgb(35, 35, 35), Color.FromArgb(248, 249, 250))
                Dim gridText As Color = If(isDarkTheme, Color.White, Color.FromArgb(50, 50, 50))
                Dim gridLine As Color = If(isDarkTheme, Color.FromArgb(60, 60, 60), Color.FromArgb(235, 238, 241))
                Dim gridHeaderBg As Color = If(isDarkTheme, Color.FromArgb(50, 50, 50), Color.FromArgb(240, 242, 245))

                With dgvAvailability
                    .BorderStyle = BorderStyle.None
                    .AlternatingRowsDefaultCellStyle.BackColor = gridAltBg
                    .AlternatingRowsDefaultCellStyle.ForeColor = gridText
                    .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                    .DefaultCellStyle.SelectionBackColor = If(isDarkTheme, Color.FromArgb(60, 60, 60), Color.FromArgb(225, 228, 232))
                    .DefaultCellStyle.SelectionForeColor = gridText
                    .BackgroundColor = gridBg
                    .GridColor = gridLine
                    .RowHeadersVisible = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .MultiSelect = False
                    .ReadOnly = True
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .AllowUserToResizeRows = False
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .EnableHeadersVisualStyles = False
                    .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                    .ColumnHeadersHeight = 42
                    .ColumnHeadersDefaultCellStyle.BackColor = gridHeaderBg
                    .ColumnHeadersDefaultCellStyle.ForeColor = gridText
                    .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
                    .RowTemplate.Height = 38
                    .DefaultCellStyle.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular)
                    .DefaultCellStyle.ForeColor = gridText
                    .DefaultCellStyle.BackColor = gridBg
                    .DefaultCellStyle.Padding = New Padding(2, 0, 2, 0)

                    If .Columns.Contains("Room Name") Then .Columns("Room Name").FillWeight = 100
                    If .Columns.Contains("Status") Then
                        .Columns("Status").FillWeight = 75
                        .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If
                    If .Columns.Contains("Current Schedule") Then .Columns("Current Schedule").FillWeight = 150
                    If .Columns.Contains("Instructor") Then .Columns("Instructor").FillWeight = 120
                End With

                For Each col As DataGridViewColumn In dgvAvailability.Columns
                    col.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                dgvAvailability.ClearSelection()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading availability data: " & ex.Message)
        End Try
    End Sub

    Public Sub LoadAvailabilityFilters()
        If cmbDay IsNot Nothing Then
            cmbDay.Items.Clear()
            cmbDay.Items.AddRange(New String() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
            Dim todayStr As String = DateTime.Now.DayOfWeek.ToString()
            If cmbDay.Items.Contains(todayStr) Then
                cmbDay.SelectedItem = todayStr
            Else
                cmbDay.SelectedIndex = 0
            End If
        End If

        If cmbFilterRoom IsNot Nothing Then
            Try
                Dim dtRooms As New DataTable()
                Using cmd As New MySqlCommand("SELECT room_id, room_name FROM tbl_classrooms ORDER BY room_name ASC", conn)
                    Dim dataAdapter As New MySqlDataAdapter(cmd)
                    dataAdapter.Fill(dtRooms)
                End Using

                Dim dr As DataRow = dtRooms.NewRow()
                dr("room_id") = 0
                dr("room_name") = "All Rooms"
                dtRooms.Rows.InsertAt(dr, 0)

                cmbFilterRoom.DataSource = dtRooms
                cmbFilterRoom.DisplayMember = "room_name"
                cmbFilterRoom.ValueMember = "room_id"
                cmbFilterRoom.SelectedIndex = 0
            Catch ex As Exception
                MessageBox.Show("Error loading room filter: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmbDay_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDay.SelectedIndexChanged
        LoadAvailabilityData()
    End Sub

    Private Sub cmbFilterRoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbFilterRoom.SelectedIndexChanged
        LoadAvailabilityData()
    End Sub

    Private Sub txtSearchAvailability_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearchAvailability.TextChanged
        LoadAvailabilityData()
    End Sub

    Public Sub LoadFilterComboBoxes()
        LoadAvailabilityFilters()
    End Sub

    Private Sub dgvAvailability_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvAvailability.CellPainting
        If e.RowIndex >= 0 AndAlso dgvAvailability.Columns(e.ColumnIndex).Name = "Status" Then
            Dim cellBackColor As Color = e.CellStyle.BackColor
            If (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected Then
                cellBackColor = dgvAvailability.DefaultCellStyle.SelectionBackColor
            ElseIf e.RowIndex Mod 2 = 1 AndAlso dgvAvailability.AlternatingRowsDefaultCellStyle.BackColor.IsEmpty = False Then
                cellBackColor = dgvAvailability.AlternatingRowsDefaultCellStyle.BackColor
            End If

            Using bgBrush As New SolidBrush(cellBackColor)
                e.Graphics.FillRectangle(bgBrush, e.CellBounds)
            End Using

            e.Paint(e.CellBounds, DataGridViewPaintParts.Border)

            Dim val As String = Convert.ToString(e.Value)
            If Not String.IsNullOrEmpty(val) Then
                Dim backColor As Color = Color.White
                Dim foreColor As Color = Color.Black

                If val.Equals("Available", StringComparison.OrdinalIgnoreCase) Then
                    backColor = Color.FromArgb(212, 237, 218)
                    foreColor = Color.FromArgb(21, 87, 36)
                ElseIf val.Equals("Occupied", StringComparison.OrdinalIgnoreCase) Then
                    backColor = Color.FromArgb(248, 215, 218)
                    foreColor = Color.FromArgb(114, 28, 36)
                ElseIf val.Equals("Conflict", StringComparison.OrdinalIgnoreCase) Then
                    backColor = Color.FromArgb(255, 243, 205)
                    foreColor = Color.FromArgb(133, 100, 4)
                End If

                Dim rect As Rectangle = e.CellBounds
                rect.Inflate(-3, -4)

                Using path As New System.Drawing.Drawing2D.GraphicsPath()
                    Dim radius As Integer = 5
                    path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
                    path.AddArc(rect.Right - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90)
                    path.AddArc(rect.Right - (radius * 2), rect.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90)
                    path.AddArc(rect.X, rect.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90)
                    path.CloseFigure()

                    Using brush As New SolidBrush(backColor)
                        e.Graphics.FillPath(brush, path)
                    End Using
                End Using

                Using sf As New StringFormat()
                    sf.Alignment = StringAlignment.Center
                    sf.LineAlignment = StringAlignment.Center
                    Using boldFont As New Font("Segoe UI", 9.0F, FontStyle.Bold)
                        Using textBrush As New SolidBrush(foreColor)
                            e.Graphics.DrawString(val, boldFont, textBrush, rect, sf)
                        End Using
                    End Using
                End Using
            End If

            e.Handled = True
        End If
    End Sub

    Private Sub dgvConflicts_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dgvConflicts.CellPainting
        If e.RowIndex >= 0 AndAlso dgvConflicts.Columns(e.ColumnIndex).Name = "Status" Then
            Dim cellBackColor As Color = e.CellStyle.BackColor
            If (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected Then
                cellBackColor = dgvConflicts.DefaultCellStyle.SelectionBackColor
            ElseIf e.RowIndex Mod 2 = 1 AndAlso dgvConflicts.AlternatingRowsDefaultCellStyle.BackColor.IsEmpty = False Then
                cellBackColor = dgvConflicts.AlternatingRowsDefaultCellStyle.BackColor
            End If

            Using bgBrush As New SolidBrush(cellBackColor)
                e.Graphics.FillRectangle(bgBrush, e.CellBounds)
            End Using

            e.Paint(e.CellBounds, DataGridViewPaintParts.Border)

            Dim val As String = Convert.ToString(e.Value)
            If Not String.IsNullOrEmpty(val) Then
                Dim backColor As Color = Color.FromArgb(255, 243, 205)
                Dim foreColor As Color = Color.FromArgb(133, 100, 4)

                Dim rect As Rectangle = e.CellBounds
                rect.Inflate(-3, -4)

                Using path As New System.Drawing.Drawing2D.GraphicsPath()
                    Dim radius As Integer = 5
                    path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
                    path.AddArc(rect.Right - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90)
                    path.AddArc(rect.Right - (radius * 2), rect.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90)
                    path.AddArc(rect.X, rect.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90)
                    path.CloseFigure()

                    Using brush As New SolidBrush(backColor)
                        e.Graphics.FillPath(brush, path)
                    End Using
                End Using

                Using sf As New StringFormat()
                    sf.Alignment = StringAlignment.Center
                    sf.LineAlignment = StringAlignment.Center
                    Using boldFont As New Font("Segoe UI", 9.0F, FontStyle.Bold)
                        Using textBrush As New SolidBrush(foreColor)
                            e.Graphics.DrawString(val, boldFont, textBrush, rect, sf)
                        End Using
                    End Using
                End Using
            End If

            e.Handled = True
        End If
    End Sub

    Public Sub LoadConflictsData()
        Try
            Dim query As String = "SELECT s1.schedule_id AS 'ID1', s2.schedule_id AS 'ID2', " & _
                                  "r.room_name AS 'Room Name', " & _
                                  "CONCAT(TIME_FORMAT(GREATEST(s1.time_start, s2.time_start), '%h:%i %p'), ' - ', TIME_FORMAT(LEAST(s1.time_end, s2.time_end), '%h:%i %p')) AS 'Time', " & _
                                  "CASE WHEN s1.time_start = s2.time_start AND s1.time_end = s2.time_end THEN 'Two classes assigned' ELSE 'Overlapping schedule' END AS 'Conflict Details', " & _
                                  "'Pending' AS 'Status' " & _
                                  "FROM tbl_schedules s1 " & _
                                  "JOIN tbl_schedules s2 ON s1.room_id = s2.room_id " & _
                                  "AND s1.day_of_week = s2.day_of_week " & _
                                  "AND s1.schedule_id < s2.schedule_id " & _
                                  "AND s1.time_start < s2.time_end " & _
                                  "AND s1.time_end > s2.time_start " & _
                                  "JOIN tbl_classrooms r ON s1.room_id = r.room_id " & _
                                  "ORDER BY r.room_name ASC"

            Using cmd As New MySqlCommand(query, conn)
                Dim dataAdapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                dataAdapter.Fill(dt)

                dgvConflicts.DataSource = Nothing
                dgvConflicts.Columns.Clear()
                dgvConflicts.DataSource = dt

                If Not dgvConflicts.Columns.Contains("Actions") Then
                    Dim btnCol As New DataGridViewButtonColumn()
                    btnCol.Name = "Actions"
                    btnCol.HeaderText = "Actions"
                    btnCol.Text = "Resolve"
                    btnCol.UseColumnTextForButtonValue = True
                    dgvConflicts.Columns.Add(btnCol)
                End If

                Dim isDarkTheme As Boolean = Toggle1 IsNot Nothing AndAlso Toggle1.Checked
                Dim gridBg As Color = If(isDarkTheme, Color.FromArgb(45, 45, 45), Color.White)
                Dim gridAltBg As Color = If(isDarkTheme, Color.FromArgb(35, 35, 35), Color.FromArgb(248, 249, 250))
                Dim gridText As Color = If(isDarkTheme, Color.White, Color.FromArgb(50, 50, 50))
                Dim gridLine As Color = If(isDarkTheme, Color.FromArgb(60, 60, 60), Color.FromArgb(235, 238, 241))
                Dim gridHeaderBg As Color = If(isDarkTheme, Color.FromArgb(50, 50, 50), Color.FromArgb(240, 242, 245))

                With dgvConflicts
                    .BorderStyle = BorderStyle.None
                    .AlternatingRowsDefaultCellStyle.BackColor = gridAltBg
                    .AlternatingRowsDefaultCellStyle.ForeColor = gridText
                    .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                    .DefaultCellStyle.SelectionBackColor = If(isDarkTheme, Color.FromArgb(60, 60, 60), Color.FromArgb(225, 228, 232))
                    .DefaultCellStyle.SelectionForeColor = gridText
                    .BackgroundColor = gridBg
                    .GridColor = gridLine
                    .RowHeadersVisible = False
                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .MultiSelect = False
                    .ReadOnly = False
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                    .AllowUserToResizeRows = False
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .EnableHeadersVisualStyles = False
                    .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
                    .ColumnHeadersHeight = 42
                    .ColumnHeadersDefaultCellStyle.BackColor = gridHeaderBg
                    .ColumnHeadersDefaultCellStyle.ForeColor = gridText
                    .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
                    .RowTemplate.Height = 38
                    .DefaultCellStyle.Font = New Font("Segoe UI", 10.5F, FontStyle.Regular)
                    .DefaultCellStyle.ForeColor = gridText
                    .DefaultCellStyle.BackColor = gridBg
                    .DefaultCellStyle.Padding = New Padding(2, 0, 2, 0)

                    If .Columns.Contains("ID1") Then .Columns("ID1").Visible = False
                    If .Columns.Contains("ID2") Then .Columns("ID2").Visible = False

                    If .Columns.Contains("Room Name") Then
                        .Columns("Room Name").FillWeight = 100
                        .Columns("Room Name").ReadOnly = True
                    End If
                    If .Columns.Contains("Time") Then
                        .Columns("Time").FillWeight = 120
                        .Columns("Time").ReadOnly = True
                    End If
                    If .Columns.Contains("Conflict Details") Then
                        .Columns("Conflict Details").FillWeight = 140
                        .Columns("Conflict Details").ReadOnly = True
                    End If
                    If .Columns.Contains("Status") Then
                        .Columns("Status").FillWeight = 75
                        .Columns("Status").ReadOnly = True
                        .Columns("Status").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns("Status").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If
                    If .Columns.Contains("Actions") Then
                        .Columns("Actions").FillWeight = 75
                        .Columns("Actions").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    End If
                End With

                For Each col As DataGridViewColumn In dgvConflicts.Columns
                    col.SortMode = DataGridViewColumnSortMode.NotSortable
                Next

                dgvConflicts.ClearSelection()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading conflicts data: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvConflicts_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvConflicts.CellContentClick
        If e.RowIndex >= 0 AndAlso dgvConflicts.Columns(e.ColumnIndex).Name = "Actions" Then

            Dim currentUserRole As String = If(GlobalSession.UserRole Is Nothing, "", GlobalSession.UserRole.Trim())
            Dim isAdmin As Boolean = currentUserRole.IndexOf("Admin", StringComparison.OrdinalIgnoreCase) >= 0

            If Not isAdmin Then
                Dim choice As DialogResult = MessageBox.Show( _
                    "Remove or edit your sched to fix this by yourself", _
                    "Access Denied - Resolve Conflict", _
                    MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Warning)

                If choice = DialogResult.Yes Then
                    btnSchedule.PerformClick()
                End If
                Return
            End If

            Dim row As DataGridViewRow = dgvConflicts.Rows(e.RowIndex)
            Dim id1 As Integer = Convert.ToInt32(row.Cells("ID1").Value)
            Dim id2 As Integer = Convert.ToInt32(row.Cells("ID2").Value)

            Using resolveForm As New ResolveConflictForm(id1, id2, conn)
                If resolveForm.ShowDialog(Me) = DialogResult.OK Then
                    LoadConflictsData()
                    LoadAvailabilityData()
                    LoadScheduleFromDatabase()
                    LoadTodaysSchedule()
                    LoadDashboardMetrics()
                    LoadRoomChart()
                End If
            End Using
        End If
    End Sub

    Private Sub picAvailRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles picAvailRefresh.Click
        LoadAvailabilityFilters()
        LoadAvailabilityData()
    End Sub

    Private Sub btnToggleView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToggleView.Click
        If btnToggleView.Text = "Logs" Then
            Try
                Dim query As String = "SELECT log_id, action, details, performed_by, log_date FROM tbl_logs ORDER BY log_date DESC"
                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvConflicts.DataSource = Nothing
                    dgvConflicts.Columns.Clear()
                    dgvConflicts.DataSource = dt

                    dgvConflicts.ReadOnly = True
                    dgvConflicts.AllowUserToAddRows = False
                    dgvConflicts.AllowUserToDeleteRows = False

                    dgvConflicts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    If dgvConflicts.Columns.Contains("details") Then
                        dgvConflicts.Columns("details").FillWeight = 250
                        dgvConflicts.Columns("details").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    End If
                    dgvConflicts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                    dgvConflicts.BringToFront()
                End Using

                btnToggleView.Text = "Conflicts"
            Catch ex As Exception
                MessageBox.Show("Error loading logs: " & ex.Message)
            End Try
        Else
            LoadConflictsData()
            btnToggleView.Text = "Logs"
        End If
    End Sub

    Private Sub InsertLog(ByVal actionText As String, ByVal detailsText As String)
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim userName As String = "System / Administrator"

            If GlobalSession.UserId > 0 Then
                Dim userQuery As String = "SELECT full_name FROM tbl_users WHERE user_id = @uid"
                Using cmdUser As New MySqlCommand(userQuery, conn)
                    cmdUser.Parameters.AddWithValue("@uid", GlobalSession.UserId)
                    Dim result = cmdUser.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        userName = result.ToString()
                    End If
                End Using
            ElseIf Not String.IsNullOrEmpty(GlobalSession.UserRole) Then
                userName = GlobalSession.UserRole.Trim()
            End If

            Dim query As String = "INSERT INTO tbl_logs (action, details, performed_by) VALUES (@action, @details, @performed_by)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@action", actionText)
                cmd.Parameters.AddWithValue("@details", detailsText)
                cmd.Parameters.AddWithValue("@performed_by", userName)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving log: " & ex.Message)
        End Try
    End Sub

    Private Sub Toggle1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Toggle1.CheckedChanged
        Dim isDark As Boolean = Toggle1.Checked

        Dim bgColor As Color = If(isDark, Color.FromArgb(30, 30, 30), Color.FromArgb(244, 245, 247))
        Dim cardBgColor As Color = If(isDark, Color.FromArgb(45, 45, 45), Color.White)
        Dim textColor As Color = If(isDark, Color.White, Color.FromArgb(30, 30, 30))
        Dim sidebarColor As Color = If(isDark, Color.FromArgb(40, 40, 40), Color.FromArgb(235, 237, 240))
        Dim gridBgColor As Color = If(isDark, Color.FromArgb(45, 45, 45), Color.White)
        Dim gridAltColor As Color = If(isDark, Color.FromArgb(35, 35, 35), Color.FromArgb(248, 249, 250))
        Dim gridLineColor As Color = If(isDark, Color.FromArgb(60, 60, 60), Color.FromArgb(235, 238, 241))

        Me.BackColor = bgColor
        Me.ForeColor = textColor

        SetThemeRecursive(Me, bgColor, cardBgColor, textColor, sidebarColor, gridBgColor, gridAltColor, gridLineColor, isDark)

        If chartRoomOverview IsNot Nothing Then
            chartRoomOverview.BackColor = If(isDark, Color.FromArgb(45, 45, 45), Color.White)
            If chartRoomOverview.Legends.Count > 0 Then
                chartRoomOverview.Legends(0).ForeColor = textColor
            End If
            chartRoomOverview.Invalidate()
        End If

        Dim isDarkMode As Boolean = False

        If isDark Then
            pnlSidebar.BackgroundImage = My.Resources.bg_dark
            pnlSidebar.BackColor = Color.Transparent
        Else
            pnlSidebar.BackgroundImage = My.Resources.bg_light2
            pnlSidebar.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub SetThemeRecursive(ByVal parent As Control, ByVal bgColor As Color, ByVal cardBgColor As Color, ByVal textColor As Color, ByVal sidebarColor As Color, ByVal gridBgColor As Color, ByVal gridAltColor As Color, ByVal gridLineColor As Color, ByVal isDark As Boolean)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is Panel Then
                Dim panelName As String = ctrl.Name.ToLower()
                If panelName.EndsWith("view") Then
                    ctrl.BackColor = bgColor
                ElseIf panelName.Contains("header") OrElse panelName.Contains("top") Then
                    ctrl.BackColor = If(isDark, Color.FromArgb(50, 50, 50), Color.FromArgb(100, 100, 100))
                ElseIf ctrl.Width < 250 Then
                    ctrl.BackColor = sidebarColor
                Else
                    ctrl.BackColor = cardBgColor
                End If
                ctrl.ForeColor = textColor
            ElseIf TypeOf ctrl Is Label Then
                ctrl.ForeColor = textColor
                ctrl.BackColor = Color.Transparent
            ElseIf TypeOf ctrl Is PictureBox Then
                ctrl.BackColor = Color.Transparent
            ElseIf TypeOf ctrl Is CheckBox Or TypeOf ctrl Is LinkLabel Or TypeOf ctrl Is Button Then
                ctrl.ForeColor = textColor
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = If(isDark, Color.FromArgb(60, 60, 60), Color.FromArgb(240, 240, 240))
                End If
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cmb As ComboBox = CType(ctrl, ComboBox)
                If isDark Then
                    cmb.BackColor = Color.FromArgb(60, 60, 60)
                    cmb.ForeColor = Color.White
                Else
                    cmb.BackColor = Color.White
                    cmb.ForeColor = Color.Black
                End If
            ElseIf TypeOf ctrl Is TextBox Then
                Dim txt As TextBox = CType(ctrl, TextBox)
                If isDark Then
                    txt.BackColor = Color.FromArgb(60, 60, 60)
                    If txt.Text = "Search..." Then
                        txt.ForeColor = Color.Gray
                    Else
                        txt.ForeColor = Color.White
                    End If
                Else
                    txt.BackColor = Color.White
                    If txt.Text = "Search..." Then
                        txt.ForeColor = Color.Gray
                    Else
                        txt.ForeColor = Color.Black
                    End If
                End If
            ElseIf TypeOf ctrl Is DataGridView Then
                Dim dgv As DataGridView = CType(ctrl, DataGridView)
                dgv.BackgroundColor = gridBgColor
                dgv.GridColor = gridLineColor
                dgv.DefaultCellStyle.BackColor = gridBgColor
                dgv.DefaultCellStyle.ForeColor = textColor
                dgv.DefaultCellStyle.SelectionBackColor = If(isDark, Color.FromArgb(60, 60, 60), Color.FromArgb(225, 228, 232))
                dgv.DefaultCellStyle.SelectionForeColor = textColor
                dgv.AlternatingRowsDefaultCellStyle.BackColor = gridAltColor
                dgv.AlternatingRowsDefaultCellStyle.ForeColor = textColor
                dgv.ColumnHeadersDefaultCellStyle.BackColor = If(isDark, Color.FromArgb(50, 50, 50), Color.FromArgb(240, 242, 245))
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = textColor
            End If

            If ctrl.HasChildren Then
                SetThemeRecursive(ctrl, bgColor, cardBgColor, textColor, sidebarColor, gridBgColor, gridAltColor, gridLineColor, isDark)
            End If
        Next
    End Sub

    Private Sub btnNormalMode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNormalMode.Click

        For Each kvp As KeyValuePair(Of Control, Color) In OriginalColors
            If kvp.Key IsNot Nothing AndAlso Not kvp.Key.IsDisposed Then
                kvp.Key.BackColor = kvp.Value
            End If
        Next

        For Each kvp As KeyValuePair(Of Control, Color) In OriginalForeColor
            If kvp.Key IsNot Nothing AndAlso Not kvp.Key.IsDisposed Then
                kvp.Key.ForeColor = kvp.Value
            End If
        Next
    End Sub

    Private Sub Toggle1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toggle1.Load
        
    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogout.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Me.Close()
        LoginForm.Show()
    End Sub
End Class