
Public Class CUGroupBox
    Inherits GroupBox

    Private _borderColor As Color

    Public Sub New()
        MyBase.New()
        Me._borderColor = Color.Black
    End Sub

    Public Property BorderColor() As Color
        Get
            Return Me._borderColor
        End Get
        Set(ByVal value As Color)
            Me._borderColor = value
        End Set
    End Property

    'Protected Overrides Sub Paint(ByVal e As PaintEventArgs)
    '    'Dim tSize As Size = TextRenderer.MeasureText(Me.Text, Me.Font)
    '    'Dim borderRect As Rectangle = e.ClipRectangle
    '    'borderRect.Y = (borderRect.Y + (tSize.Height / 2))
    '    'borderRect.Height = (borderRect.Height - (tSize.Height / 2))
    '    'ControlPaint.DrawBorder(e.Graphics, borderRect, Me._borderColor, ButtonBorderStyle.Solid)
    '    'Dim textRect As Rectangle = e.ClipRectangle
    '    'textRect.X = (textRect.X + 6)
    '    'textRect.Width = tSize.Width
    '    'textRect.Height = tSize.Height
    '    'e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), textRect)
    '    'e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), textRect)

    '    Dim gr As Graphics = e.Graphics
    '    Dim r As Rectangle
    '    r = New Rectangle(0, 0, Width - 1, Height - 1)
    '    Using brush As Brush = New SolidBrush(BackColor)
    '        Using borderPen As New Pen(BorderColor)
    '            gr.FillRectangle(brush, r)
    '            gr.DrawRectangle(borderPen, r)
    '        End Using
    '    End Using
    'End Sub
    Protected Sub CUGroupBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim gr As Graphics = e.Graphics
        Dim r As Rectangle
        r = New Rectangle(0, 0, Width - 1, Height - 1)
        Using brush As Brush = New SolidBrush(BackColor)
            Using borderPen As New Pen(BorderColor)
                gr.FillRectangle(brush, r)
                gr.DrawRectangle(borderPen, r)
            End Using
        End Using
    End Sub
End Class