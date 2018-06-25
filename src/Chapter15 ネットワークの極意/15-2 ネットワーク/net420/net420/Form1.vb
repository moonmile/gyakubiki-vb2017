Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    ''' <summary>
    ''' サーバー開始
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Task.Run(Sub() DoWork())
    End Sub
    ''' <summary>
    ''' サーバー停止
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Me.server.Stop()
    End Sub
    ''' <summary>
    ''' ワーカースレッド
    ''' </summary>
    Private server As TcpListener
    Public Sub DoWork()
        ' リスナーを作成する
        server = New TcpListener(IPAddress.Loopback, 9000)
        ' リスナーを開始する
        server.Start()
        Invoke(
            New Action(
            Sub()
                TextBox1.Text = "サーバー開始"
            End Sub))
        Try
            While True
                ' クライアントからの接続を受け付ける
                Dim client As TcpClient = server.AcceptTcpClient()
                Dim stream As NetworkStream = client.GetStream()
                ' 受信データの読み出し
                Dim data = New Byte(100) {}
                Dim len = stream.Read(data, 0, data.Length)
                Dim str = System.Text.Encoding.ASCII.GetString(data, 0, len)
                TextBox1.Text = Convert.ToString("受信データ:") & str
                client.Close()
            End While
        Catch ex As Exception
            Invoke(New Action(
                   Sub()
                       TextBox1.Text = "サーバー終了"
                   End Sub))
        End Try
    End Sub
End Class
