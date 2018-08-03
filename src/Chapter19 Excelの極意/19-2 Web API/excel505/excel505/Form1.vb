Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url = "http://www.shuwasystem.co.jp/products/7980html/5002.html"
        Dim hc = New HttpClient()
        Dim html = Await hc.GetStringAsync(url)
        Dim hdoc = New HtmlAgilityPack.HtmlDocument()
        hdoc.LoadHtml(html)
        Dim title = hdoc.DocumentNode.SelectSingleNode(
            "//h1[@class='syoseki']").InnerText.Trim()
        Dim table = hdoc.DocumentNode.SelectSingleNode(
            "//div[@class='norm']")
        Dim items = table.SelectNodes("*/tr/td")
        Dim author = items(1).InnerText.Trim()
        Dim isbn = items(5).InnerText.Trim()
        Dim dt = items(7).InnerText.Trim()
        Dim Text =
            "タイトル " + title + vbCrLf +
            "著者 " + author + vbCrLf +
            "ISBN " + isbn + vbCrLf +
            "発売日 " + dt + vbCrLf
        TextBox1.Text = Text
        ' excel に出力
        Dim xapp = New Excel.Application()
        Dim wb = xapp.Workbooks.Add()
        Dim sh = wb.ActiveSheet
        sh.Cells(1, 1).Value = "タイトル"
        sh.Cells(2, 1).Value = "著者"
        sh.Cells(3, 1).Value = "ISBN"
        sh.Cells(4, 1).Value = "発売日"
        sh.Cells(1, 2).Value = title
        sh.Cells(2, 2).Value = author
        sh.Cells(3, 2).Value = isbn
        sh.Cells(4, 2).Value = dt
        xapp.Visible = True
        xapp.Quit()
    End Sub
End Class
