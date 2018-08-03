Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dt = DateTime.Now   '現在の日時を取得
        Label1.Text = dt
        Label2.Text = dt.AddHours(-5) '5時間前の日時を取得
        Label3.Text = dt.AddDays(10)  '10日後の日時を取得
    End Sub
End Class
