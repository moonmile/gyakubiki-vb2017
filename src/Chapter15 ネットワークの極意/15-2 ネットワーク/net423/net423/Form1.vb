Imports System.Net.Http

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim client = New HttpClient()
        Try
            ' 指定URLのファイルをダウンロードする
            Dim data = Await client.GetByteArrayAsync(
                "http://localhost/test.zip")
            Dim fs = System.IO.File.OpenWrite("c:\VB2017\test.lzh")
            fs.Write(data, 0, data.Length)
            fs.Close()
            MessageBox.Show("ダウンロードが完了しました")
        Catch ex As Exception
            ' URLが不正の場合は例外が発生する
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
