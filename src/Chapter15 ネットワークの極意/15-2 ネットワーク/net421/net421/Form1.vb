Imports System.Net.Http

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' HTTPサーバーへ接続する
        Dim client = New HttpClient()
        Try
            ' HTTPサーバーへ接続しストリームを取得する
            Dim stream = Await client.GetStreamAsync(TextBox1.Text)
            ' テキストボックスへ結果を書き出す
            Dim reader As New System.IO.StreamReader(stream)
            TextBox2.Text = reader.ReadToEnd()
            reader.Close()
            stream.Close()
        Catch ex As Exception
            ' URLが不正の場合は例外が発生する
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
