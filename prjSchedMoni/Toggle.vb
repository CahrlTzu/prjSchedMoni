Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class Toggle
    Inherits System.Windows.Forms.UserControl

    Private _checked As Boolean

    Public Sub New()
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        Me.Size = New Size(60, 24)
    End Sub

    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(ByVal value As Boolean)
            If Not _checked.Equals(value) Then
                _checked = value
                Me.OnCheckedChanged()
                Me.Invalidate()
            End If
        End Set
    End Property

    Protected Overridable Sub OnCheckedChanged()
        RaiseEvent CheckedChanged(Me, EventArgs.Empty)
    End Sub

    Public Event CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

    Protected Overrides Sub OnMouseClick(ByVal e As MouseEventArgs)
        Me.Checked = Not Me.Checked
        MyBase.OnMouseClick(e)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Me.OnPaintBackground(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using path = New GraphicsPath()
            Dim d = 2
            Dim r = Me.Height - (d * 2)
            path.AddArc(d, d, r, r, 90, 180)
            path.AddArc(Me.Width - r - d, d, r, r, -90, 180)
            path.CloseFigure()
            e.Graphics.FillPath(If(Checked, Brushes.MediumSeaGreen, Brushes.LightGray), path)

            Dim thumbSize = Me.Height - 6
            Dim rect = If(Checked, New System.Drawing.Rectangle(Me.Width - thumbSize - 3, 3, thumbSize, thumbSize), New System.Drawing.Rectangle(3, 3, thumbSize, thumbSize))
            e.Graphics.FillEllipse(Brushes.White, rect)
        End Using
    End Sub

End Class