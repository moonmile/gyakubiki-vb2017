Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt = DateTime.Today     '今日の日付を取得
        Select Case dt.DayOfWeek    '曜日を取得
            Case DayOfWeek.Sunday
                label1.Text = "日曜日"
            Case DayOfWeek.Monday
                label1.Text = "月曜日"
            Case DayOfWeek.Tuesday
                label1.Text = "火曜日"
            Case DayOfWeek.Wednesday
                label1.Text = "水曜日"
            Case DayOfWeek.Thursday
                label1.Text = "木曜日"
            Case DayOfWeek.Friday
                label1.Text = "金曜日"
            Case DayOfWeek.Saturday
                label1.Text = "土曜日"
        End Select
    End Sub
End Class
