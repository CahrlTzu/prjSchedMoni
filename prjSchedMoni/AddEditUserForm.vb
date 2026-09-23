Imports MySql.Data.MySqlClient

Public Class AddEditUserForm
    Private editUserId As Integer = 0
    Private isEditMode As Boolean = False

    Public Sub New()
        InitializeComponent()
        isEditMode = False
    End Sub

    Public Sub New(ByVal userId As Integer)
        InitializeComponent()
        editUserId = userId
        isEditMode = True
        Me.Text = "Edit User Account"
        btnSave.Text = "Update"
    End Sub

    Private Sub AddEditUserForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If cmbRole.Items.Count > 0 Then cmbRole.SelectedIndex = 0

        If isEditMode Then
            LoadUserDataToEdit()
        End If
    End Sub

    Private Sub LoadUserDataToEdit()
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()
            Dim query As String = "SELECT username, full_name, role FROM tbl_users WHERE user_id = @id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", editUserId)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtUsername.Text = reader("username").ToString()
                        txtFullName.Text = reader("full_name").ToString()
                        cmbRole.SelectedItem = reader("role").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtFullName.Text) OrElse
           cmbRole.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim query As String = ""
            If isEditMode Then
                If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                    query = "UPDATE tbl_users SET username = @username, full_name = @fullname, role = @role WHERE user_id = @id"
                Else
                    query = "UPDATE tbl_users SET username = @username, password = @password, full_name = @fullname, role = @role WHERE user_id = @id"
                End If
            Else
                If String.IsNullOrWhiteSpace(txtPassword.Text) Then
                    MessageBox.Show("Password is required for new users.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                query = "INSERT INTO tbl_users (username, password, full_name, role) VALUES (@username, @password, @fullname, @role)"
            End If

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim())
                cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem.ToString())

                If Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())
                End If

                If isEditMode Then
                    cmd.Parameters.AddWithValue("@id", editUserId)
                End If

                cmd.ExecuteNonQuery()
            End Using

            Dim successMsg As String = If(isEditMode, "User account updated successfully!", "User account created successfully!")
            MessageBox.Show(successMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class