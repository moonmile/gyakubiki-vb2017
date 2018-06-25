Imports Microsoft.Win32

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim key = Registry.CurrentUser
        key = key.OpenSubKey("software\逆引き大全VB2017", True)
        key.DeleteValue("sample")
        MessageBox.Show("レジストリから削除しました")
    End Sub
End Class
