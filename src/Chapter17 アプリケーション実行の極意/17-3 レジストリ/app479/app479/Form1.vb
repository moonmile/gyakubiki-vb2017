Imports Microsoft.Win32

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' レジストリへ書き出す
        Dim key = Registry.CurrentUser
        key = key.CreateSubKey("software\逆引き大全VB2017")
        key.SetValue("sample", TextBox1.Text)
        key.Close()
        MessageBox.Show("レジストリへ書き込みました")
    End Sub
End Class
