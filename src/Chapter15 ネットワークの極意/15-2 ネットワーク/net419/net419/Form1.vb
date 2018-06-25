Imports System.Net.Sockets

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim client = New TcpClient()
        Try
            ' TCP/IP接続を行う
            client.Connect("localhost", 80)
            ' ストリームを取得する
            Dim stream = client.GetStream()
            Dim buffer = System.Text.Encoding.ASCII.GetBytes(
                "GET /iisstart.htm HTTP/1.0" & vbCr & vbLf & vbCr & vbLf)
            stream.Write(buffer, 0, buffer.Length)
            Dim data = New Byte(1000) {}
            stream.Read(data, 0, data.Length)
            ' 正常に受信できた場合
            TextBox1.Text = System.Text.Encoding.ASCII.GetString(data)
            client.Close()
        Catch ex As Exception
            ' 接続できなかった場合
            TextBox1.Text = ex.Message
        End Try
    End Sub
End Class
