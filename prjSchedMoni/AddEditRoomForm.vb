Imports MySql.Data.MySqlClient

Public Class AddEditRoomForm

    Public Property RoomId As Integer = 0

    Private Sub AddEditRoomForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If cmbStatus.Items.Count = 0 Then
            cmbStatus.Items.Add("Working")
            cmbStatus.Items.Add("Maintenance")
            cmbStatus.Items.Add("Not Working")
            cmbStatus.SelectedIndex = 0
        End If

        If RoomId > 0 Then
            Me.Text = "Edit Room"
            LoadRoomDetails()
        Else
            Me.Text = "Add Room"
        End If
    End Sub

    Private Sub LoadRoomDetails()
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim query As String = "SELECT room_name, room_type, capacity, status FROM tbl_classrooms WHERE room_id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", RoomId)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.[Read]() Then
                        txtRoomName.Text = reader("room_name").ToString()
                        txtRoomType.Text = reader("room_type").ToString()
                        txtCapacity.Text = reader("capacity").ToString()
                        Dim dbStatus As String = reader("status").ToString()
                        If cmbStatus.Items.Contains(dbStatus) Then
                            cmbStatus.SelectedItem = dbStatus
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading room details: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtRoomName.Text) OrElse String.IsNullOrWhiteSpace(txtCapacity.Text) OrElse cmbStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim capacity As Integer
        If Not Integer.TryParse(txtCapacity.Text, capacity) Then
            MessageBox.Show("Capacity must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedStatus As String = cmbStatus.SelectedItem.ToString()

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim query As String = ""

            If RoomId = 0 Then
                query = "INSERT INTO tbl_classrooms (room_name, room_type, capacity, status) VALUES (@name, @room_type, @capacity, @status)"
            Else
                query = "UPDATE tbl_classrooms SET room_name = @name, room_type = @room_type, capacity = @capacity, status = @status WHERE room_id = @id"
            End If

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", txtRoomName.Text.Trim())
                cmd.Parameters.AddWithValue("@room_type", If(txtRoomType IsNot Nothing, txtRoomType.Text.Trim(), ""))
                cmd.Parameters.AddWithValue("@capacity", capacity)
                cmd.Parameters.AddWithValue("@status", selectedStatus)
                If RoomId > 0 Then
                    cmd.Parameters.AddWithValue("@id", RoomId)
                End If
                cmd.ExecuteNonQuery()
            End Using

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error saving room: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class