Public Class Form1
    Private Sub Button1_Click(sender As Object,
                              e As EventArgs) Handles Button1.Click
        'ラベルに現在の日付と時刻を表示する
        Label1.Text = "現在の日時：" + DateTime.Now

    End Sub
End Class
