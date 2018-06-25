Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dname = TextBox1.Text
        If Directory.Exists(dname) = False Then
            MessageBox.Show(dname & "が見つかりません。", "通知")
            Return
        End If
        'リストボックスにファイル名を表示する
        ListBox1.DataSource = Directory.GetFiles(dname)
    End Sub
End Class
