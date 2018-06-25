Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim city = 130010 ' 東京
        Dim url = $"http://weather.livedoor.com/forecast/webservice/json/v1?city={city}"
        Dim hc As New HttpClient()
        Dim json = Await hc.GetStringAsync(url)
        TextBox1.Text = json
        Dim js As New JsonSerializer()
        Dim jr As New JsonTextReader(New System.IO.StringReader(json))
        Dim root = JObject.ReadFrom(jr)
        Dim title = root("title").Value(Of String)()
        Dim forecasts As JArray = root("forecasts")
        ' 明日の天気
        Dim yesterday = forecasts(1)
        Dim dt = yesterday("date").Value(Of String)()
        Dim dateLabel = yesterday("dateLabel").Value(Of String)()
        Dim telop = yesterday("telop").Value(Of String)()
        Dim min = yesterday("temperature")("min")("celsius").Value(Of String)()
        Dim max = yesterday("temperature")("max")("celsius").Value(Of String)()
        ' Excel に出力ｆ
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Add()
        Dim sh As Excel.Worksheet = wb.ActiveSheet
        sh.Cells(1, 1).Value = "場所"
        sh.Cells(2, 1).Value = "日付"
        sh.Cells(3, 1).Value = "予報"
        sh.Cells(4, 1).Value = "最低気温（予想）"
        sh.Cells(5, 1).Value = "最高気温（予想）"
        sh.Cells(1, 2).Value = title
        sh.Cells(2, 2).Value = dt
        sh.Cells(2, 3).Value = dateLabel
        sh.Cells(3, 2).Value = telop
        sh.Cells(4, 2).Value = min
        sh.Cells(5, 2).Value = max
        xapp.Visible = True
        xapp.Quit()
    End Sub
End Class
