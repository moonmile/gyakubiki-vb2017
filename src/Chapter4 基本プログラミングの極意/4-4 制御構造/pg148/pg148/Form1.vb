Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt = DateTime.Today
        Dim RetStr = If(dt.Day <= 15, "前半", "後半")
        label1.Text = "今日の日付:" & dt.ToShortDateString() & vbLf & "月の" & RetStr & "です。"
    End Sub
End Class
