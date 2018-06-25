Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' ホスト名を取得する
        Dim hostname = Dns.GetHostName()
        ' IPアドレスを取得する
        Dim ipentry As IPHostEntry = Dns.GetHostEntry(hostname)
        ' 最初のアドレスを取得
        For Each ipa In ipentry.AddressList
            If ipa.AddressFamily = AddressFamily.InterNetwork Then
                ' IPAddress Ver 4 のアドレスを表示
                TextBox1.Text = ipa.ToString()
            End If
        Next
    End Sub
End Class
