Imports System.Net.Sockets

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim client = New TcpClient()
        Try
            ' TCP/IP接続を行う
            client.Connect("localhost", 8011)
            ' ストリームを取得する
            Dim stream = client.GetStream()
            Dim buffer = System.Text.Encoding.ASCII.GetBytes(
                "GET /start.htm HTTP/1.0" & vbCr & vbLf & vbCr & vbLf)
            stream.Write(buffer, 0, buffer.Length)
            ' 正常に送信できた場合
            TextBox1.Text = "正常に送信できました"
            client.Close()
        Catch ex As Exception
            ' 接続できなかった場合
            TextBox1.Text = ex.Message
        End Try
    End Sub
End Class
