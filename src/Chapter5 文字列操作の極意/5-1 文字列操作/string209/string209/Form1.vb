Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text = TextBox1.Text
        Label1.Text = text.ToUpper()   ' 大文字に変換
        Label2.Text = text.ToLower()   ' 小文字に変換
    End Sub
End Class
