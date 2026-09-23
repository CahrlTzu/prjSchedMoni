Imports MySql.Data.MySqlClient
Public Class ResolveConflictForm
    Private scheduleID1 As Integer
    Private scheduleID2 As Integer
    Private dbConn As MySqlConnection

    Public Sub New(ByVal id1 As Integer, ByVal id2 As Integer, ByVal conn As MySqlConnection)
        InitializeComponent()
        scheduleID1 = id1
        scheduleID2 = id2
        dbConn = conn
        LoadConflictDetails()
    End Sub

    Private Sub LoadConflictDetails()
        Try
            Dim query As String = "SELECT s.schedule_id, s.subject_code, CONCAT(TIME_FORMAT(s.time_start, '%h:%i %p'), ' - ', TIME_FORMAT(s.time_end, '%h:%i %p')) AS sched_time, s.day_of_week, r.room_name, COALESCE(u.full_name, 'Unassigned') AS instructor " & _
                                  "FROM tbl_schedules s " & _
                                  "JOIN tbl_classrooms r ON s.room_id = r.room_id " & _
                                  "LEFT JOIN tbl_users u ON s.instructor_id = u.user_id " & _
                                  "WHERE s.schedule_id IN (@id1, @id2)"

            Using cmd As New MySqlCommand(query, dbConn)
                cmd.Parameters.AddWithValue("@id1", scheduleID1)
                cmd.Parameters.AddWithValue("@id2", scheduleID2)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                If dt.Rows.Count >= 2 Then
                    lblSched1Info.Text = "Subject: " & dt.Rows(0)("subject_code").ToString() & vbCrLf & _
                                         "Time: " & dt.Rows(0)("sched_time").ToString() & vbCrLf & _
                                         "Instructor: " & dt.Rows(0)("instructor").ToString()

                    lblSched2Info.Text = "Subject: " & dt.Rows(1)("subject_code").ToString() & vbCrLf & _
                                         "Time: " & dt.Rows(1)("sched_time").ToString() & vbCrLf & _
                                         "Instructor: " & dt.Rows(1)("instructor").ToString()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading details: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteFirst.Click
        ResolveByDeleting(scheduleID1)
    End Sub

    Private Sub btnDeleteSecond_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteSecond.Click
        ResolveByDeleting(scheduleID2)
    End Sub

    Private Sub ResolveByDeleting(ByVal targetID As Integer)
        If MessageBox.Show("Are you sure you want to remove this schedule to resolve the conflict?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM tbl_schedules WHERE schedule_id = @id"
                Using cmd As New MySqlCommand(query, dbConn)
                    cmd.Parameters.AddWithValue("@id", targetID)
                    If dbConn.State = ConnectionState.Closed Then dbConn.Open()
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Conflict resolved successfully.")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ResolveConflictForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class