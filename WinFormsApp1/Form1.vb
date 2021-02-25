Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X As Single
        Dim Y As Single
        Dim Z As Single
        Z = Val(TextBox1.Text)
        X = Z ^ (1 / 3)
        TextBox2.Text = Format(X, "0.000")
        If X < 1.1 Then
            Y = 2 * Math.Atan(Math.Sin(X))
        ElseIf X >= 1.1 Then
            Y = (X ^ 3 * 3 ^ -X) / (X + 1) ^ 2
        End If
        TextBox3.Text = Format(Y, "0.000")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
