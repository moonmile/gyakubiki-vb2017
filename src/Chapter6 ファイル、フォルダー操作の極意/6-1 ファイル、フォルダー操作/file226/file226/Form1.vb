Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim fname1 = TextBox1.Text
        Dim fname2 = TextBox2.Text
        'コピー元ファイル無し、または、コピー先ファイル有り
        'または、コピー先フォルダー無しなら終了
        If File.Exists(fname1) = False Then
            Label1.Text = "コピー元のファイルがありません。"
            Return
        End If
        If File.Exists(fname2) = True Then
            Label1.Text = "コピー先のファイルがあります。"
            Return
        End If
        If Directory.Exists(
            Path.GetDirectoryName(fname2)) = False Then
            Label1.Text = "コピー先はディレクトリです。"
            Return
        End If
        File.Copy(fname1, fname2)  'コピー
        Label1.Text = $"{fname2}にコピーしました。"
    End Sub
End Class
