Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt = DateTime.Now   '現在の日時を取得
        label1.Text = dt
        label2.Text = dt.AddHours(-5) '5時間前の日時を取得
        label3.Text = dt.AddDays(10)  '10日後の日時を取得
    End Sub
End Class
