Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        folderBrowserDialog1.Description =
            "フォルダーを選択してください。"
        '［新しいフォルダを作成］ボタンを表示しない
        folderBrowserDialog1.ShowNewFolderButton = False
        '［OK］ボタンが選択されたらフォルダーパスを表示
        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Label1.Text = folderBrowserDialog1.SelectedPath
        Else
            Label1.Text = ""
        End If
    End Sub
End Class
