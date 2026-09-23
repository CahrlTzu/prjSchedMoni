Imports MySql.Data.MySqlClient

Public Class UserManagementForm

    Private Sub UserManagementForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadUsersData()
    End Sub

    Public Sub LoadUsersData()
        Try
            If conn.State <> ConnectionState.Open Then conn.Open()

            Dim query As String = "SELECT user_id AS 'ID', username AS 'Username', full_name AS 'Full Name', role AS 'Role' FROM tbl_users WHERE 1=1"

            If txtSearchUser IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtSearchUser.Text) Then
                query &= " AND (username LIKE @search OR full_name LIKE @search)"
            End If

            query &= " ORDER BY full_name ASC"

            Using cmd As New MySqlCommand(query, conn)
                If txtSearchUser IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtSearchUser.Text) Then
                    cmd.Parameters.AddWithValue("@search", "%" & txtSearchUser.Text.Trim() & "%")
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                dgvUsers.DataSource = dt
            End Using

            If Not dgvUsers.Columns.Contains("EditUser") Then
                Dim imgEdit As New DataGridViewImageColumn()
                imgEdit.Name = "EditUser"
                imgEdit.HeaderText = "Edit"
                imgEdit.ImageLayout = DataGridViewImageCellLayout.Normal ' Keeps original icon size
                dgvUsers.Columns.Add(imgEdit)
            End If

            If Not dgvUsers.Columns.Contains("DeleteUser") Then
                Dim imgDelete As New DataGridViewImageColumn()
                imgDelete.Name = "DeleteUser"
                imgDelete.HeaderText = "Delete"
                imgDelete.ImageLayout = DataGridViewImageCellLayout.Normal ' Keeps original icon size
                dgvUsers.Columns.Add(imgDelete)
            End If

            For Each row As DataGridViewRow In dgvUsers.Rows
                row.Cells("EditUser").Value = My.Resources.edit_icon
                row.Cells("DeleteUser").Value = My.Resources.delete_icon
            Next

            With dgvUsers
                .BorderStyle = BorderStyle.None
                .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250)
                .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                .DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 228, 232)
                .DefaultCellStyle.SelectionForeColor = Color.Black
                .BackgroundColor = Color.White
                .GridColor = Color.FromArgb(235, 238, 241)
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
                .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245)
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40)
                .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
                .RowTemplate.Height = 40
                .DefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                .DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50)
                .DefaultCellStyle.BackColor = Color.White
                .DefaultCellStyle.Padding = New Padding(6, 0, 6, 0)

                If .Columns.Contains("ID") Then
                    .Columns("ID").Visible = False
                End If

                If .Columns.Contains("Username") Then .Columns("Username").FillWeight = 110
                If .Columns.Contains("Full Name") Then .Columns("Full Name").FillWeight = 150
                If .Columns.Contains("Role") Then .Columns("Role").FillWeight = 90

                If .Columns.Contains("EditUser") Then
                    .Columns("EditUser").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    .Columns("EditUser").Width = 55
                    .Columns("EditUser").Resizable = DataGridViewTriState.False
                End If
                If .Columns.Contains("DeleteUser") Then
                    .Columns("DeleteUser").AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    .Columns("DeleteUser").Width = 60
                    .Columns("DeleteUser").Resizable = DataGridViewTriState.False
                End If
            End With

            dgvUsers.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearchUser_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearchUser.TextChanged
        LoadUsersData()
    End Sub

    Private Sub dgvUsers_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim userId As Integer = Convert.ToInt32(dgvUsers.Rows(e.RowIndex).Cells("ID").Value)

        If dgvUsers.Columns(e.ColumnIndex).Name = "EditUser" Then
            Dim editForm As New AddEditUserForm(userId)
            If editForm.ShowDialog() = DialogResult.OK Then
                LoadUsersData()
            End If

        ElseIf dgvUsers.Columns(e.ColumnIndex).Name = "DeleteUser" Then
            Dim username As String = dgvUsers.Rows(e.RowIndex).Cells("Username").Value.ToString()
            Dim confirmResult As DialogResult = MessageBox.Show("Are you sure you want to delete user '" & username & "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If confirmResult = DialogResult.Yes Then
                Try
                    If conn.State <> ConnectionState.Open Then conn.Open()
                    Dim query As String = "DELETE FROM tbl_users WHERE user_id = @id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", userId)
                        cmd.ExecuteNonQuery()
                    End Using
                    LoadUsersData()
                    MessageBox.Show("User account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error deleting user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnAddAccount_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddAccount.Click
        Dim createForm As New AddEditUserForm()
        If createForm.ShowDialog() = DialogResult.OK Then
            LoadUsersData()
        End If
    End Sub

End Class