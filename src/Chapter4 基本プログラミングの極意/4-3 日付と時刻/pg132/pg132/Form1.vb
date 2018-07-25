Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt = DateTime.Now               'システム日付を取得
        label1.Text = dt.ToLongDateString() '長い形式の日付
        label2.Text = dt.ToLongTimeString() '長い形式の時刻    
    End Sub
End Class
