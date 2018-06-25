Imports System.Net.Http
Imports System.Net.Http.Headers

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim client As New HttpClient()
        Try
            Dim content As New MultipartFormDataContent()
            ' 指定URLへファイルをアップロードする
            Dim path = "c:\VB2017\test.zip"
            Dim fileCont = New StreamContent(
                System.IO.File.OpenRead(path))
            fileCont.Headers.ContentDisposition =
                New ContentDispositionHeaderValue("attachment") With {
                    .FileName = System.IO.Path.GetFileName(path)
                }
            content.Add(fileCont)
            Await client.PostAsync("http://localhost/upload.aspx", content)
            TextBox1.Text = "ファイルをアップロードしました"
        Catch ex As Exception
            ' アップロードが異常の場合は例外が発生する
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
