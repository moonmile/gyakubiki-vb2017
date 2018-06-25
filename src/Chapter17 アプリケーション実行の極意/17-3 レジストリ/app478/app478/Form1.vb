Imports Microsoft.Win32

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' レジストリから読み込む
        Dim key = Registry.CurrentUser
        key = key.OpenSubKey("software\逆引き大全VB2017")
        Dim data As String = DirectCast(key.GetValue("sample"), String)
        key.Close()
        ' 結果を出力する
        TextBox1.Text = data
    End Sub
End Class
