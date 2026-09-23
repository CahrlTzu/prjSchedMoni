Imports MySql.Data.MySqlClient

Public Class AddEditScheduleForm
    Public Property ScheduleId As Integer = 0

    Private Sub AddEditScheduleForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        dtpTimeStart.Format = DateTimePickerFormat.Time
        dtpTimeStart.ShowUpDown = True
        dtpTimeEnd.Format = DateTimePickerFormat.Time
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

        Dim selectedRoomId As Integer = Convert.ToInt32(cmbRoom.SelectedValue)

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

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving schedule: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class