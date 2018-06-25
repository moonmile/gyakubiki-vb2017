Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        MessageBox.Show("パスワード：" & TextBox1.Text, "入力内容")
    End Sub
End Class
