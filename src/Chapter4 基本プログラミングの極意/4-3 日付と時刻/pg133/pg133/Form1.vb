Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt = DateTime.Now   '現在の日付を取得
        label1.Text = dt.Year   '年を取得して表示
        label2.Text = dt.Month  '月を取得して表示
        label3.Text = dt.Day    '日を取得して表示    
    End Sub
End Class
