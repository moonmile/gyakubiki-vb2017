Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim fname = TextBox1.Text
        If System.IO.Directory.Exists(fname) = True Then
            'フォルダー
            System.IO.Directory.Delete(fname, True)
            Label1.Text = $"{fname}を削除しました。"
        ElseIf System.IO.File.Exists(fname) = True Then
            'ファイル
            System.IO.File.Delete(fname)
            Label1.Text = $"{fname}を削除しました。"
        Else
            Label1.Text = $"{fname}が見つかりませんでした。"
        End If
    End Sub
End Class
