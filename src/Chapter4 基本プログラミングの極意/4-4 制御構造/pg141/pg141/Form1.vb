Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt As DateTime
        '入力されているかどうか、日付に変換可能かチェックする
        If textBox1.Text = "" Then
            label1.Text = "入力されていません。"
        ElseIf DateTime.TryParse(textBox1.Text, dt) Then
            label1.Text = "入力した日付：" + dt
        Else
            label1.Text = "正しい日付を入力してください。"
        End If
    End Sub
End Class
