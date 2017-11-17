Public Class ccButton

    Public Property borderColor As Color
    Public Property disabledBorderColor As Color
    Public Property disabledForeColor As Color
    Public Property disabledBackColor As Color

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim backC As Color = Color.Red
        Dim foreC As Color = Color.Red
        Dim borderC As Color = Color.Red
        If Me.Enabled Then
            backC = BackColor
            foreC = ForeColor
            borderC = borderColor
        Else
            backC = disabledBackColor
            foreC = disabledForeColor
            borderC = disabledBorderColor
        End If
        'MyBase.OnPaint(e)
        'e.Graphics.
        'Dim g = Me.CreateGraphics()
        MyBase.OnPaint(e)
        'e.Graphics.Clear(backC)
        e.Graphics.FillRectangle(New SolidBrush(backC), 0, 0, Me.Bounds.Width, Me.Bounds.Height)
        e.Graphics.DrawRectangle(New Pen(borderC, 1), 0, 0, Me.Bounds.Width - 1, Me.Bounds.Height - 1)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        e.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(foreC), New Rectangle(0, 0, Me.Bounds.Width, Me.Bounds.Height), sf)

        'Add your custom paint code here
    End Sub

End Class