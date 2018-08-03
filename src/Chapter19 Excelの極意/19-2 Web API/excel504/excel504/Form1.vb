Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url = "http://www.shuwasystem.co.jp/"
        Dim hc = New HttpClient()
        Dim html = Await hc.GetStringAsync(url)
        Dim hdoc = New HtmlAgilityPack.HtmlDocument()
        hdoc.LoadHtml(html)
        Dim lst = hdoc.DocumentNode.SelectNodes("//img[@alt='新刊']")
        Dim items = New List(Of String)()
        Dim books = New List(Of Book)()
        For Each it In lst
            Dim Text = it.ParentNode.SelectSingleNode("a").
            InnerText.Trim()
            items.Add(Text)
            Dim link = it.ParentNode.SelectSingleNode("a").
            GetAttributeValue("href", "")
            books.Add(New Book() With {
                    .Title = Text, .link = link})
        Next
        listBox1.DataSource = items
        ' excel に出力
        Dim xapp = New Excel.Application()
        Dim wb = xapp.Workbooks.Add()
        Dim sh = wb.ActiveSheet
        sh.Cells(1, 1).Value = "タイトル"
        sh.Cells(1, 2).Value = "リンク"
        Dim r = 2
        For Each it In books
            sh.Cells(r, 1).Value = it.Title
            sh.Cells(r, 2).Value = it.Link
            r = r + 1
        Next
        xapp.Visible = True
        xapp.Quit()
    End Sub
End Class

Public Class Book
    Public Property Title As String
    Public Property Link As String
End Class
