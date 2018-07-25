Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim myRand = New Random()
        '乱数を取得してラベルに表示する
        label1.Text = myRand.Next(100)
        label2.Text = myRand.Next(100, 1001)
    End Sub
End Class
