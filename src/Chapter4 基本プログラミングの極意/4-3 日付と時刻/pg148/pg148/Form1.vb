Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ts1 = New TimeSpan(20, 10, 5)        '20時間10分5秒
        Dim ts2 = New TimeSpan(0, 25, 20, 15)    '0日25時間20分15秒
        Dim ts3 = New TimeSpan(0, 0, 0, 0, 1001) '0秒1001ミリ秒
        Label1.Text = ts1.ToString()
        Label2.Text = ts2.ToString()
        Label3.Text = ts3.ToString()
    End Sub
End Class
