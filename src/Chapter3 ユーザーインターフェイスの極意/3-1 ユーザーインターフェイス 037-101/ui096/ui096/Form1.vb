Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        If System.IO.File.Exists(TextBox1.Text) = False Then
            MessageBox.Show("ファイルが存在しません", "通知")
            Exit Sub
        End If
        If TextBox1.Text.EndsWith("txt") Then
            RichTextBox1.LoadFile(TextBox1.Text,
                                  RichTextBoxStreamType.PlainText)
        ElseIf TextBox1.Text.EndsWith("rtf") Then
            RichTextBox1.LoadFile(TextBox1.Text,
                                  RichTextBoxStreamType.RichText)
        Else
            MessageBox.Show("txt形式、rtf形式のファイルを指定してください", "通知")
        End If
    End Sub
End Class
