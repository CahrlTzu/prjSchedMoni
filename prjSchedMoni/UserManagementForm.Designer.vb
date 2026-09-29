<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagementForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManagementForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSearchContainer = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtSearchUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlAddSched = New System.Windows.Forms.Panel()
        Me.btnAddAccount = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.pnlSearchContainer.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddSched.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "User Management (Admin only)"
        '
        'pnlSearchContainer
        '
        Me.pnlSearchContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlSearchContainer.Controls.Add(Me.PictureBox5)
        Me.pnlSearchContainer.Controls.Add(Me.txtSearchUser)
        Me.pnlSearchContainer.Location = New System.Drawing.Point(20, 70)
        Me.pnlSearchContainer.Name = "pnlSearchContainer"
        Me.pnlSearchContainer.Size = New System.Drawing.Size(368, 33)
        Me.pnlSearchContainer.TabIndex = 31
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.prjSchedMoni.My.Resources.Resources.loupe
        Me.PictureBox5.Location = New System.Drawing.Point(10, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'txtSearchUser
        '
        Me.txtSearchUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.txtSearchUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearchUser.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchUser.Location = New System.Drawing.Point(36, 5)
        Me.txtSearchUser.Name = "txtSearchUser"
        Me.txtSearchUser.Size = New System.Drawing.Size(320, 22)
        Me.txtSearchUser.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "These are the users of the system."
        '
        'pnlAddSched
        '
        Me.pnlAddSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.pnlAddSched.Controls.Add(Me.btnAddAccount)
        Me.pnlAddSched.Location = New System.Drawing.Point(616, 67)
        Me.pnlAddSched.Name = "pnlAddSched"
        Me.pnlAddSched.Size = New System.Drawing.Size(152, 41)
        Me.pnlAddSched.TabIndex = 35
        '
        'btnAddAccount
        '
        Me.btnAddAccount.AutoSize = True
        Me.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnAddAccount.FlatAppearance.BorderSize = 0
        Me.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAccount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAccount.Image = Global.prjSchedMoni.My.Resources.Resources.icons8_plus_241
        Me.btnAddAccount.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAddAccount.Location = New System.Drawing.Point(7, 3)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(138, 35)
        Me.btnAddAccount.TabIndex = 33
        Me.btnAddAccount.Text = "     Add Account"
        Me.btnAddAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddAccount.UseVisualStyleBackColor = False
        '
        'dgvUsers
        '
        Me.dgvUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(20, 120)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(740, 340)
        Me.dgvUsers.TabIndex = 36
        '
        'UserManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(794, 471)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.pnlAddSched)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pnlSearchContainer)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Form"
        Me.pnlSearchContainer.ResumeLayout(False)
        Me.pnlSearchContainer.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddSched.ResumeLayout(False)
        Me.pnlAddSched.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlSearchContainer As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlAddSched As System.Windows.Forms.Panel
    Friend WithEvents btnAddAccount As System.Windows.Forms.Button
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
End Class
