Imports System.Net

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' コンピュータ名を取得する
        Dim hostname = Dns.GetHostName()
        TextBox1.Text = hostname
    End Sub
End Class
