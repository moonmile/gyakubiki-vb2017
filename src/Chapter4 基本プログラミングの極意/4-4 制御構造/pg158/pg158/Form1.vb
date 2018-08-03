Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dt = DateTime.Today
        Dim RetStr = If(dt.Day <= 15, "前半", "後半")
        Label1.Text = $"今日の日付:{dt}" & ControlChars.Lf &
            $"月の{RetStr}です。"
    End Sub
End Class
