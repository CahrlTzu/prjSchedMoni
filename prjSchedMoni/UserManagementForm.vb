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
                imgEdit.ImageLayout = DataGridViewImageCellLayout.Zoom
                dgvUsers.Columns.Add(imgEdit)
            End If

            If Not dgvUsers.Columns.Contains("DeleteUser") Then
                Dim imgDelete As New DataGridViewImageColumn()
                imgDelete.Name = "DeleteUser"
                imgDelete.HeaderText = "Delete"
                imgDelete.ImageLayout = DataGridViewImageCellLayout.Zoom
                dgvUsers.Columns.Add(imgDelete)
            End If

            For Each row As DataGridViewRow In dgvUsers.Rows
                If Not row.IsNewRow Then
                    row.Cells("EditUser").Value = My.Resources.edit_icon
                    row.Cells("DeleteUser").Value = My.Resources.delete_icon
                End If
            Next

            If dgvUsers.Columns.Contains("ID") Then
                dgvUsers.Columns("ID").Visible = False
            End If

            ' Format and lock the grid layout
            FormatUserGrid(dgvUsers)

            dgvUsers.ClearSelection()

        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearchUser_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearchUser.TextChanged
        LoadUsersData()
    End Sub

    Private Sub dgvUsers_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        If e.RowIndex < 0 OrElse dgvUsers.Rows(e.RowIndex).IsNewRow Then Return
        If dgvUsers.Rows(e.RowIndex).Cells("ID").Value Is DBNull.Value Then Return

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

    Public Sub FormatUserGrid(ByVal dgv As DataGridView)
        ' 1. General Grid Appearance & Strict Layout Rules
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.MultiSelect = False
        dgv.RowHeadersVisible = False
        dgv.BackgroundColor = Color.White
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.GridColor = Color.FromArgb(230, 230, 230)
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToResizeRows = False
        dgv.AllowUserToResizeColumns = False
        dgv.ReadOnly = True

        ' 2. Header Styling
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.5, FontStyle.Bold)
        dgv.ColumnHeadersHeight = 45
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        ' 3. Row Styling & Spacious Padding
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40)
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219)
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.RowTemplate.Height = 48
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250)

        ' 4. Perfect Column Sizing (Fills the window width completely with no blank gaps)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        If dgv.Columns.Contains("Username") Then
            dgv.Columns("Username").Width = 150
            dgv.Columns("Username").Resizable = DataGridViewTriState.False
        End If

        If dgv.Columns.Contains("Role") Then
            dgv.Columns("Role").Width = 130
            dgv.Columns("Role").Resizable = DataGridViewTriState.False
        End If

        For Each col As DataGridViewColumn In dgv.Columns
            Dim colName As String = col.Name.ToLower()
            Dim colText As String = col.HeaderText.ToLower()

            If colName.Contains("edit") OrElse colName.Contains("delete") OrElse colText.Contains("edit") OrElse colText.Contains("delete") Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                col.Width = 65
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                col.Resizable = DataGridViewTriState.False
            End If
        Next


        If dgv.Columns.Contains("Full Name") Then
            dgv.Columns("Full Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgv.Columns("Full Name").MinimumWidth = 180
        End If
    End Sub

End Class