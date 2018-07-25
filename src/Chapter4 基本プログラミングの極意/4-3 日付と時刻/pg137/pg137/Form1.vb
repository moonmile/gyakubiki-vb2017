Public Class Form1
    Private sTime As DateTime '開始時刻
    Private eTime As DateTime '終了時刻

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        sTime = DateTime.Now  '開始時の時刻を取得
        label1.Text = ""
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        eTime = DateTime.Now
        '終了時の時刻を取得
        Dim ts = eTime.Subtract(sTime)
        '時刻の差分を求める
        If ts.Seconds = 10 Then
            '10秒台のとき
            label1.Text = "Congraturations!  " + ts.TotalSeconds.ToString("##.##") + "秒です。"
        Else
            label1.Text = "残念！　" + ts.TotalSeconds.ToString("##.##") + "秒でした。"
        End If
    End Sub
End Class
