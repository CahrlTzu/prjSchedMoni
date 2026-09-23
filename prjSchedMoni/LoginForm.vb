Imports MySql.Data.MySqlClient
Public Class LoginForm

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub userIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userIcon.Click

    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub picEye_Click(ByVal sender As Object, ByVal e As EventArgs) Handles picEye.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
            picEye.Image = My.Resources.eye_open
        Else
            txtPassword.UseSystemPasswordChar = True
            picEye.Image = My.Resources.eye_closed
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        Try
            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

            Dim query As String = "SELECT user_id, role FROM tbl_users WHERE username = @user AND password = @pass"
            Dim userId As Integer = 0
            Dim userRole As String = ""
            Dim loginSuccess As Boolean = False

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        userId = Convert.ToInt32(reader("user_id"))
                        userRole = reader("role").ToString()
                        loginSuccess = True
                    End If
                End Using
            End Using

            If loginSuccess Then
                GlobalSession.UserId = userId
                GlobalSession.UserRole = userRole

                Dim mainForm As New DashboardForm()
                mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class