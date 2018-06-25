Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dname = Directory.GetCurrentDirectory()
        MessageBox.Show($"カレントフォルダーは{dname}です。", "通知")
        Directory.SetCurrentDirectory("C:\")
        MessageBox.Show(
            "カレントフォルダーをC:\に変更しました。" & vbLf &
            "［OK］ボタンをクリックすると元に戻します。", "通知")
        Directory.SetCurrentDirectory(dname)
    End Sub
End Class
