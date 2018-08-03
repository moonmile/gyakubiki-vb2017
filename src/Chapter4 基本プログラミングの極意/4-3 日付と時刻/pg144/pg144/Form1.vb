Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dt = DateTime.Now    'システム日付を取得
        Label1.Text = dt.Hour    '時を取得して表示
        Label2.Text = dt.Minute  '分を取得して表示
        Label3.Text = dt.Second  '秒を取得して表示
    End Sub
End Class
