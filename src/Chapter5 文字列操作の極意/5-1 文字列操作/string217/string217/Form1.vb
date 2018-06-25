Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text1 = TextBox1.Text
        If text1.Length < 4 Then
            MessageBox.Show("4文字以上入力してください。", "通知")
            Return
        End If
        Label1.Text = text1.Remove(1, 3)
    End Sub
End Class
