Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text As String = TextBox1.Text
        Label1.Text = ""
        If text.Length < 7 Then
            MessageBox.Show("7文字以上入力してください。", "通知")
            Return
        End If
        Label1.Text = text.Substring(4, 3)   '3文字取得
    End Sub
End Class
