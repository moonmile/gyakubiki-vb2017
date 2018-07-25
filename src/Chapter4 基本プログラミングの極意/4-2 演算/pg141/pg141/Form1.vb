Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim rnd = New Random()
        '乱数を取得してラベルに表示する
        Label1.Text = rnd.Next(100)
        Label2.Text = rnd.Next(100, 1001)
    End Sub
End Class
