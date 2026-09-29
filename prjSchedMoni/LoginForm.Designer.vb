<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picEye = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.pnlUserID = New System.Windows.Forms.Panel()
        Me.userIcon = New System.Windows.Forms.PictureBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.pnlLogin.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUserID.SuspendLayout()
        CType(Me.userIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.Transparent
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.Panel1)
        Me.pnlLogin.Controls.Add(Me.pnlUserID)
        Me.pnlLogin.Location = New System.Drawing.Point(59, 51)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(312, 425)
        Me.pnlLogin.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Sans Serif Collection", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(43, 293)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(218, 48)
        Me.btnLogin.TabIndex = 10
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.picEye)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Location = New System.Drawing.Point(35, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 45)
        Me.Panel1.TabIndex = 9
        '
        'picEye
        '
        Me.picEye.Image = Global.prjSchedMoni.My.Resources.Resources.eye_closed
        Me.picEye.Location = New System.Drawing.Point(8, 11)
        Me.picEye.Name = "picEye"
        Me.picEye.Size = New System.Drawing.Size(20, 20)
        Me.picEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEye.TabIndex = 9
        Me.picEye.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPassword.Location = New System.Drawing.Point(41, 12)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(185, 20)
        Me.txtPassword.TabIndex = 3
        '
        'pnlUserID
        '
        Me.pnlUserID.BackColor = System.Drawing.Color.White
        Me.pnlUserID.Controls.Add(Me.userIcon)
        Me.pnlUserID.Controls.Add(Me.txtUsername)
        Me.pnlUserID.Location = New System.Drawing.Point(35, 157)
        Me.pnlUserID.Name = "pnlUserID"
        Me.pnlUserID.Size = New System.Drawing.Size(241, 45)
        Me.pnlUserID.TabIndex = 7
        '
        'userIcon
        '
        Me.userIcon.Image = Global.prjSchedMoni.My.Resources.Resources.usericon1
        Me.userIcon.Location = New System.Drawing.Point(5, 8)
        Me.userIcon.Name = "userIcon"
        Me.userIcon.Size = New System.Drawing.Size(30, 30)
        Me.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userIcon.TabIndex = 8
        Me.userIcon.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtUsername.Location = New System.Drawing.Point(41, 12)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(185, 20)
        Me.txtUsername.TabIndex = 3
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.prjSchedMoni.My.Resources.Resources.bg1
        Me.ClientSize = New System.Drawing.Size(794, 513)
        Me.Controls.Add(Me.pnlLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.pnlLogin.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUserID.ResumeLayout(False)
        Me.pnlUserID.PerformLayout()
        CType(Me.userIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLogin As System.Windows.Forms.Panel
    Friend WithEvents pnlUserID As System.Windows.Forms.Panel
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents userIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents picEye As System.Windows.Forms.PictureBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button

End Class
