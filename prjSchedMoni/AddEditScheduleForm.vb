Imports MySql.Data.MySqlClient

Public Class AddEditScheduleForm
    Public Property ScheduleId As Integer = 0
    Private isInitializing As Boolean = True


    Private Sub AddEditScheduleForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        isInitializing = True
        dtpTimeStart.Format = DateTimePickerFormat.Custom
        dtpTimeStart.CustomFormat = "hh:mm tt"
        dtpTimeStart.ShowUpDown = True
        cmbRoom.DrawMode = DrawMode.OwnerDrawFixed
        dtpTimeEnd.Format = DateTimePickerFormat.Custom
        dtpTimeEnd.CustomFormat = "hh:mm tt"
        dtpTimeEnd.ShowUpDown = True

        LoadRooms()
        LoadInstructors()
        LoadDays()

        Dim currentUserRole As String = If(GlobalSession.UserRole Is Nothing, "", GlobalSession.UserRole.Trim())
        Dim isAdmin As Boolean = currentUserRole.IndexOf("Admin", StringComparison.OrdinalIgnoreCase) >= 0

        If Not isAdmin Then
            cmbInstructor.SelectedValue = GlobalSession.UserId
            cmbInstructor.Enabled = False
        End If

        If ScheduleId > 0 Then
            LoadScheduleDetails()
            If Not isAdmin Then
                cmbInstructor.SelectedValue = GlobalSession.UserId
                cmbInstructor.Enabled = False
            End If
        End If
        isInitializing = False
    End Sub

    Private Sub LoadRooms()
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim query As String = "SELECT room_id, room_name FROM tbl_classrooms"
            Using da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                cmbRoom.DataSource = dt
                cmbRoom.DisplayMember = "room_name"
                cmbRoom.ValueMember = "room_id"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading rooms: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadInstructors()
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim query As String = "SELECT user_id, full_name FROM tbl_users"
            Using da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                cmbInstructor.DataSource = dt
                cmbInstructor.DisplayMember = "full_name"
                cmbInstructor.ValueMember = "user_id"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading instructors: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadDays()
        cmbDay.Items.Clear()
        cmbDay.Items.Add("Monday")
        cmbDay.Items.Add("Tuesday")
        cmbDay.Items.Add("Wednesday")
        cmbDay.Items.Add("Thursday")
        cmbDay.Items.Add("Friday")
        cmbDay.Items.Add("Saturday")
        cmbDay.Items.Add("Sunday")
    End Sub

    Private Sub LoadScheduleDetails()
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim query As String = "SELECT * FROM tbl_schedules WHERE schedule_id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", ScheduleId)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        cmbRoom.SelectedValue = reader("room_id")

                        If reader("instructor_id") IsNot DBNull.Value Then
                            cmbInstructor.SelectedValue = Convert.ToInt32(reader("instructor_id"))
                        End If

                        txtSubjectCode.Text = reader("subject_code").ToString()
                        txtDescription.Text = reader("subject_description").ToString()
                        cmbDay.SelectedItem = reader("day_of_week").ToString()

                        If reader("time_start") IsNot DBNull.Value Then
                            Dim tsStart As TimeSpan = CType(reader("time_start"), TimeSpan)
                            dtpTimeStart.Value = DateTime.Today.Add(tsStart)
                        End If

                        If reader("time_end") IsNot DBNull.Value Then
                            Dim tsEnd As TimeSpan = CType(reader("time_end"), TimeSpan)
                            dtpTimeEnd.Value = DateTime.Today.Add(tsEnd)
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading schedule details: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If cmbRoom.SelectedValue Is Nothing Then Return
        If cmbInstructor.SelectedValue Is Nothing Then
            MessageBox.Show("Please select an instructor.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRoomId As Integer = Convert.ToInt32(cmbRoom.SelectedValue)
        Dim selectedInstructorId As Integer = Convert.ToInt32(cmbInstructor.SelectedValue)

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim checkQuery As String = "SELECT status FROM tbl_classrooms WHERE room_id = @id"
            Using cmd As New MySqlCommand(checkQuery, conn)
                cmd.Parameters.AddWithValue("@id", selectedRoomId)
                Dim roomStatus As String = Convert.ToString(cmd.ExecuteScalar())

                If roomStatus = "Maintenance" OrElse roomStatus = "Not Working" Then
                    Dim result As DialogResult = MessageBox.Show("The room is " & roomStatus & ". Do you want to check available rooms?", "Room Unavailable", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If result = DialogResult.Yes Then
                        Dim mainForm As DashboardForm = TryCast(Application.OpenForms("DashboardForm"), DashboardForm)
                        If mainForm IsNot Nothing Then
                            mainForm.Show()
                            mainForm.BringToFront()
                            mainForm.pnlRoomsView.Visible = True
                            mainForm.pnlRoomsView.BringToFront()
                            mainForm.LoadRoomsData()
                        End If
                        Me.Close()
                    End If
                    Return
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking room status: " & ex.Message)
            Return
        End Try

        If String.IsNullOrWhiteSpace(txtSubjectCode.Text) OrElse cmbDay.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim overlapQuery As String = "SELECT COUNT(*) FROM tbl_schedules WHERE day_of_week = @day_of_week AND (room_id = @room_id OR instructor_id = @instructor_id) AND (@time_start < time_end AND @time_end > time_start)"
            If ScheduleId > 0 Then
                overlapQuery &= " AND schedule_id <> @id"
            End If

            Using cmdCheck As New MySqlCommand(overlapQuery, conn)
                cmdCheck.Parameters.AddWithValue("@day_of_week", cmbDay.SelectedItem.ToString())
                cmdCheck.Parameters.AddWithValue("@room_id", selectedRoomId)
                cmdCheck.Parameters.AddWithValue("@instructor_id", selectedInstructorId)
                cmdCheck.Parameters.AddWithValue("@time_start", dtpTimeStart.Value.TimeOfDay)
                cmdCheck.Parameters.AddWithValue("@time_end", dtpTimeEnd.Value.TimeOfDay)
                If ScheduleId > 0 Then
                    cmdCheck.Parameters.AddWithValue("@id", ScheduleId)
                End If

                Dim conflictCount As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                If conflictCount > 0 Then
                    MessageBox.Show("Conflict detected! The selected room or instructor is already booked during this time slot.", "Schedule Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking schedule conflicts: " & ex.Message)
            Return
        End Try

        Dim instructorId As Object = DBNull.Value
        If cmbInstructor.SelectedValue IsNot Nothing Then
            instructorId = cmbInstructor.SelectedValue
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim query As String = ""

            If ScheduleId = 0 Then
                query = "INSERT INTO tbl_schedules (room_id, instructor_id, subject_code, subject_description, day_of_week, time_start, time_end) VALUES (@room_id, @instructor_id, @subject_code, @subject_description, @day_of_week, @time_start, @time_end)"
            Else
                query = "UPDATE tbl_schedules SET room_id = @room_id, instructor_id = @instructor_id, subject_code = @subject_code, subject_description = @subject_description, day_of_week = @day_of_week, time_start = @time_start, time_end = @time_end WHERE schedule_id = @id"
            End If

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@room_id", selectedRoomId)
                cmd.Parameters.AddWithValue("@instructor_id", instructorId)
                cmd.Parameters.AddWithValue("@subject_code", txtSubjectCode.Text.Trim())
                cmd.Parameters.AddWithValue("@subject_description", txtDescription.Text.Trim())
                cmd.Parameters.AddWithValue("@day_of_week", cmbDay.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@time_start", dtpTimeStart.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@time_end", dtpTimeEnd.Value.TimeOfDay)

                If ScheduleId > 0 Then
                    cmd.Parameters.AddWithValue("@id", ScheduleId)
                End If

                cmd.ExecuteNonQuery()
            End Using

            If ScheduleId = 0 Then
                InsertLog("Add Schedule", "A new class schedule was added.")
            Else
                InsertLog("Edit Schedule", "Schedule ID " & ScheduleId & " was updated.")
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving schedule: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dtpTimeStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTimeStart.ValueChanged

    End Sub

    Private Sub cmbRoom_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles cmbRoom.MouseDown
        If isInitializing Then Return

        If cmbDay.SelectedItem Is Nothing Then
            cmbRoom.DroppedDown = False
            MessageBox.Show("Please select a day first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbDay.Focus()
            cmbDay.DroppedDown = True
        End If
    End Sub

    Private Sub cmbDay_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbDay.SelectedIndexChanged
        cmbDay.BackColor = SystemColors.Window
    End Sub

    Private Sub cmbDay_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles cmbDay.DrawItem
        If e.Index < 0 Then Return
        e.DrawBackground()
        Using brush As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(cmbDay.Items(e.Index).ToString(), e.Font, brush, e.Bounds)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub cmbRoom_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles cmbRoom.DrawItem
        If e.Index < 0 Then Return

        e.DrawBackground()

        Dim dt As DataTable = CType(cmbRoom.DataSource, DataTable)
        Dim roomId As Integer = Convert.ToInt32(dt.Rows(e.Index)("room_id"))
        Dim roomName As String = dt.Rows(e.Index)("room_name").ToString()

        Dim isOccupied As Boolean = CheckRoomIsOccupied(roomId)
        Dim textColor As Color = If(isOccupied, Color.Blue, e.ForeColor)

        Using itemFont As New Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold)
            Using brush As New SolidBrush(textColor)
                e.Graphics.DrawString(roomName, itemFont, brush, e.Bounds)
            End Using
        End Using

        e.DrawFocusRectangle()
    End Sub

    Private Function CheckRoomIsOccupied(ByVal roomId As Integer) As Boolean
        If cmbDay.SelectedItem Is Nothing Then Return False

        Dim occupied As Boolean = False
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM tbl_schedules WHERE day_of_week = @day AND room_id = @room AND (@start < time_end AND @end > time_start)"
            If ScheduleId > 0 Then
                query &= " AND schedule_id <> @id"
            End If

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@day", cmbDay.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@room", roomId)
                cmd.Parameters.AddWithValue("@start", dtpTimeStart.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@end", dtpTimeEnd.Value.TimeOfDay)
                If ScheduleId > 0 Then
                    cmd.Parameters.AddWithValue("@id", ScheduleId)
                End If

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                occupied = (count > 0)
            End Using
        Catch ex As Exception
        End Try

        Return occupied
    End Function

    Private Sub InsertLog(ByVal actionText As String, ByVal detailsText As String)
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim userName As String = "Unknown"
            Dim userQuery As String = "SELECT full_name FROM tbl_users WHERE user_id = @uid"
            Using cmdUser As New MySqlCommand(userQuery, conn)
                cmdUser.Parameters.AddWithValue("@uid", GlobalSession.UserId)
                Dim result = cmdUser.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    userName = result.ToString()
                End If
            End Using

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

End Class