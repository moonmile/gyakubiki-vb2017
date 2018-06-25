Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    ''' <summary>
    ''' XML形式で取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim url = "http://my.redmine.jp/demo/projects.xml"
        Dim hc As New HttpClient()
        Dim Xml = Await hc.GetStringAsync(url)
        TextBox1.Text = Xml
        Dim doc = XDocument.Load(New System.IO.StringReader(Xml))

        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Add()
        Dim sh As Excel.Worksheet = wb.ActiveSheet
        ' タイトルを出力
        sh.Range("A1").Value = "ID"
        sh.Range("B1").Value = "タグ"
        sh.Range("C1").Value = "プロジェクト名"
        sh.Range("D1").Value = "内容"
        ' 内容を出力
        Dim r = 2
        For Each it In doc.Root.Elements()
            Dim id = it.Element(XName.Get("id")).Value
            Dim Tag = it.Element(XName.Get("identifier")).Value
            Dim Name = it.Element(XName.Get("name")).Value
            Dim desc = it.Element(XName.Get("description")).Value
            desc = desc.Replace(vbCrLf, "")
            System.Diagnostics.Debug.WriteLine($"{id} {Tag} {Name} {desc}")
            sh.Cells(r, 1).Value = id
            sh.Cells(r, 2).Value = Tag
            sh.Cells(r, 3).Value = Name
            sh.Cells(r, 4).Value = desc
            r = r + 1
        Next
        xapp.Visible = True
        xapp.Quit()
    End Sub
    ''' <summary>
    ''' JSON形式で取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim url = "http://my.redmine.jp/demo/projects.json"
        Dim hc As New HttpClient()
        Dim json = Await hc.GetStringAsync(url)
        TextBox1.Text = json
        Dim js As New JsonSerializer()
        Dim jr As New JsonTextReader(New System.IO.StringReader(json))
        Dim projects As JArray = JObject.ReadFrom(jr)("projects")

        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Add()
        Dim sh As Excel.Worksheet = wb.ActiveSheet
        ' タイトルを出力
        sh.Range("A1").Value = "ID"
        sh.Range("B1").Value = "タグ"
        sh.Range("C1").Value = "プロジェクト名"
        sh.Range("D1").Value = "内容"
        ' 内容を出力
        Dim r = 2
        For Each it In projects
            Dim id = it("id").Value(Of Integer)()
            Dim Tag = it("identifier").Value(Of String)()
            Dim Name = it("name").Value(Of String)()
            Dim desc = it("description").Value(Of String)()
            desc = desc.Replace(vbCrLf, "")
            System.Diagnostics.Debug.WriteLine($"{id} {Tag} {Name} {desc}")
            sh.Cells(r, 1).Value = id
            sh.Cells(r, 2).Value = Tag
            sh.Cells(r, 3).Value = Name
            sh.Cells(r, 4).Value = desc
            r = r + 1
        Next
        xapp.Visible = True
        xapp.Quit()
    End Sub
End Class
