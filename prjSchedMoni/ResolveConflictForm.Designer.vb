<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResolveConflictForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResolveConflictForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSched1 = New System.Windows.Forms.Panel()
        Me.btnDeleteFirst = New System.Windows.Forms.Button()
        Me.lblSched1Info = New System.Windows.Forms.Label()
        Me.lblSched1Title = New System.Windows.Forms.Label()
        Me.pnlSched2 = New System.Windows.Forms.Panel()
        Me.btnDeleteSecond = New System.Windows.Forms.Button()
        Me.lblSched2Info = New System.Windows.Forms.Label()
        Me.lblSched2Title = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pnlSched1.SuspendLayout()
        Me.pnlSched2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 34)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "An overlapping schedule conflict has been detected. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please choose which schedul" & _
            "e to remove or reassign:"
        '
        'pnlSched1
        '
        Me.pnlSched1.BackColor = System.Drawing.Color.White
        Me.pnlSched1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSched1.Controls.Add(Me.btnDeleteFirst)
        Me.pnlSched1.Controls.Add(Me.lblSched1Info)
        Me.pnlSched1.Controls.Add(Me.lblSched1Title)
        Me.pnlSched1.Location = New System.Drawing.Point(20, 65)
        Me.pnlSched1.Name = "pnlSched1"
        Me.pnlSched1.Size = New System.Drawing.Size(240, 220)
        Me.pnlSched1.TabIndex = 13
        '
        'btnDeleteFirst
        '
        Me.btnDeleteFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnDeleteFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteFirst.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteFirst.ForeColor = System.Drawing.Color.White
        Me.btnDeleteFirst.Location = New System.Drawing.Point(12, 165)
        Me.btnDeleteFirst.Name = "btnDeleteFirst"
        Me.btnDeleteFirst.Size = New System.Drawing.Size(215, 35)
        Me.btnDeleteFirst.TabIndex = 23
        Me.btnDeleteFirst.Text = "Remove Schedule A"
        Me.btnDeleteFirst.UseVisualStyleBackColor = False
        '
        'lblSched1Info
        '
        Me.lblSched1Info.AutoSize = True
        Me.lblSched1Info.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSched1Info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSched1Info.Location = New System.Drawing.Point(12, 45)
        Me.lblSched1Info.Name = "lblSched1Info"
        Me.lblSched1Info.Size = New System.Drawing.Size(196, 15)
        Me.lblSched1Info.TabIndex = 15
        Me.lblSched1Info.Text = "Subject: --\nTime: --\nInstructor: --"
        '
        'lblSched1Title
        '
        Me.lblSched1Title.AutoSize = True
        Me.lblSched1Title.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSched1Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSched1Title.Location = New System.Drawing.Point(12, 12)
        Me.lblSched1Title.Name = "lblSched1Title"
        Me.lblSched1Title.Size = New System.Drawing.Size(76, 17)
        Me.lblSched1Title.TabIndex = 14
        Me.lblSched1Title.Text = "Schedule A"
        '
        'pnlSched2
        '
        Me.pnlSched2.BackColor = System.Drawing.Color.White
        Me.pnlSched2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSched2.Controls.Add(Me.btnDeleteSecond)
        Me.pnlSched2.Controls.Add(Me.lblSched2Info)
        Me.pnlSched2.Controls.Add(Me.lblSched2Title)
        Me.pnlSched2.Location = New System.Drawing.Point(275, 65)
        Me.pnlSched2.Name = "pnlSched2"
        Me.pnlSched2.Size = New System.Drawing.Size(240, 220)
        Me.pnlSched2.TabIndex = 24
        '
        'btnDeleteSecond
        '
        Me.btnDeleteSecond.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnDeleteSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSecond.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSecond.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSecond.Location = New System.Drawing.Point(12, 165)
        Me.btnDeleteSecond.Name = "btnDeleteSecond"
        Me.btnDeleteSecond.Size = New System.Drawing.Size(215, 35)
        Me.btnDeleteSecond.TabIndex = 23
        Me.btnDeleteSecond.Text = "Remove Schedule A"
        Me.btnDeleteSecond.UseVisualStyleBackColor = False
        '
        'lblSched2Info
        '
        Me.lblSched2Info.AutoSize = True
        Me.lblSched2Info.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSched2Info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSched2Info.Location = New System.Drawing.Point(12, 45)
        Me.lblSched2Info.Name = "lblSched2Info"
        Me.lblSched2Info.Size = New System.Drawing.Size(196, 15)
        Me.lblSched2Info.TabIndex = 15
        Me.lblSched2Info.Text = "Subject: --\nTime: --\nInstructor: --"
        '
        'lblSched2Title
        '
        Me.lblSched2Title.AutoSize = True
        Me.lblSched2Title.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSched2Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSched2Title.Location = New System.Drawing.Point(12, 12)
        Me.lblSched2Title.Name = "lblSched2Title"
        Me.lblSched2Title.Size = New System.Drawing.Size(75, 17)
        Me.lblSched2Title.TabIndex = 14
        Me.lblSched2Title.Text = "Schedule B"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(415, 305)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 38)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ResolveConflictForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(534, 361)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.pnlSched2)
        Me.Controls.Add(Me.pnlSched1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ResolveConflictForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ResolveConflictForm"
        Me.pnlSched1.ResumeLayout(False)
        Me.pnlSched1.PerformLayout()
        Me.pnlSched2.ResumeLayout(False)
        Me.pnlSched2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlSched1 As System.Windows.Forms.Panel
    Friend WithEvents lblSched1Info As System.Windows.Forms.Label
    Friend WithEvents lblSched1Title As System.Windows.Forms.Label
    Friend WithEvents btnDeleteFirst As System.Windows.Forms.Button
    Friend WithEvents pnlSched2 As System.Windows.Forms.Panel
    Friend WithEvents btnDeleteSecond As System.Windows.Forms.Button
    Friend WithEvents lblSched2Info As System.Windows.Forms.Label
    Friend WithEvents lblSched2Title As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
