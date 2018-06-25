Imports System.Net.Http
Imports System.Web

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim client As New HttpClient()
        ' クエリ文字列を作成する
        Dim text As String = TextBox1.Text
        Dim ub As New UriBuilder("http://www.google.com/search")
        Dim dic As New Dictionary(Of String, String)()
        Dim query = HttpUtility.ParseQueryString("")
        query("q") = HttpUtility.UrlEncode(text)
        query("hl") = "jp"
        ub.Query = query.ToString()
        Try
            ' HTTPサーバーへ接続しストリームを取得する
            Dim stream = Await client.GetStreamAsync(ub.Uri)
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
