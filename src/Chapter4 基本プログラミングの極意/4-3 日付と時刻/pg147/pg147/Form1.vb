Public Class Form1
    Private sTime As DateTime '開始時刻
    Private eTime As DateTime '終了時刻
    ''' <summary>
    ''' Startボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        sTime = DateTime.Now  '開始時の時刻を取得
        Label1.Text = ""
    End Sub
    ''' <summary>
    ''' Stopボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        eTime = DateTime.Now
        '終了時の時刻を取得
        Dim ts = eTime.Subtract(sTime)
        '時刻の差分を求める
        If ts.Seconds = 10 Then
            '10秒台のとき
            Label1.Text = "Congraturations!  " +
                ts.TotalSeconds.ToString("##.##") + "秒です。"
        Else
            Label1.Text = "残念！　" +
                ts.TotalSeconds.ToString("##.##") + "秒でした。"
        End If
    End Sub
End Class
