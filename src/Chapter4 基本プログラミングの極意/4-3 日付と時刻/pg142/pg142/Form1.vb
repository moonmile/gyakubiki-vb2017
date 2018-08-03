Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dt = DateTime.Now               'システム日付を取得
        Label1.Text = dt.ToLongDateString() '長い形式の日付
        Label2.Text = dt.ToLongTimeString() '長い形式の時刻    
    End Sub
End Class
