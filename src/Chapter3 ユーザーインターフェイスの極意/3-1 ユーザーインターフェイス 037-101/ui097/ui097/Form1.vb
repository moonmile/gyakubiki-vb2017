Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        If System.IO.Directory.Exists(TextBox1.Text) = False Then
            MessageBox.Show("フォルダーが存在しません", "通知")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("ファイル名を指定してください", "通知")
            Exit Sub
        End If
        RichTextBox1.SaveFile(TextBox1.Text & "\" & TextBox2.Text & ".rtf",
                      RichTextBoxStreamType.RichText)
        MessageBox.Show("ファイルを保存しました", "結果")
    End Sub
End Class
