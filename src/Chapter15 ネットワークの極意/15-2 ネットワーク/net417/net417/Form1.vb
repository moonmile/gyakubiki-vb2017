Imports System.Net.Sockets

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' TCP/IP接続を行う
        Dim client = New TcpClient()
        Try
            client.Connect("localhost", 80)
            ' 正常に接続できた場合
            TextBox1.Text = "正常に接続できました"
            client.Close()
        Catch ex As Exception
            ' 接続できなかった場合
            TextBox1.Text = ex.Message
        End Try
    End Sub
End Class
