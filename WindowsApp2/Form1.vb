Public Class Form1
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Z As Single, X As Single, Y(6) As Single
        Dim A As Single, B As Single, h As Single
        Dim i As Integer
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        h = Val(TextBox3.Text)
        i = 0
        For Z = A To B Step h
            X = 3 * Z ^ 3
            i = i + 1
            If X < 1 Then
                Y(i) = X ^ 2 * Math.Exp(-X)
            Else
                Y(i) = Math.Log(X ^ 2) / (X * (1 + X))
            End If
            Dim index = DataGridView1.Rows.Add()
            DataGridView1.Rows.Item(index).Cells(0).Value = Z.ToString("0.0")
            DataGridView1.Rows.Item(index).Cells(1).Value = X.ToString("0.000")
            DataGridView1.Rows.Item(index).Cells(2).Value = Y(i).ToString("0.000")
        Next Z
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
