Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dt = DateTime.Now   '現在の日付を取得
        Label1.Text = dt.Year   '年を取得して表示
        Label2.Text = dt.Month  '月を取得して表示
        Label3.Text = dt.Day    '日を取得して表示    
    End Sub
End Class
