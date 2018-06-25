Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim urlmax = $"http://www.data.jma.go.jp/obd/stats/data/mdrr/tem_rct/alltable/mxtemsadext00_rct.csv"
        Dim urlmin = $"http://www.data.jma.go.jp/obd/stats/data/mdrr/tem_rct/alltable/mntemsadext00_rct.csv"
        Dim hc As New HttpClient()

        Dim enc = Encoding.GetEncoding("shift_jis")
        Dim st = Await hc.GetStreamAsync(urlmax)
        Dim tr = DirectCast(New StreamReader(st, enc, False), TextReader)
        Dim csvmax = Await tr.ReadToEndAsync()

        st = Await hc.GetStreamAsync(urlmin)
        tr = DirectCast(New StreamReader(st, enc, False), TextReader)
        Dim csvmin = Await tr.ReadToEndAsync()

        Dim data = New List(Of Data)()
        ' 最高気温CSVをパースする
        Dim lst = csvmax.Split(New String() {vbCrLf},
            StringSplitOptions.None).ToList()
        ' 先頭行は削除する
        lst.RemoveAt(0)
        For Each line In lst
            Dim vals = line.Split(New String() {","},
              StringSplitOptions.None)
            If vals.Count() > 13 Then
                ' 観測番号, 都道府県, 地点, 最高気温, 最高気温(時), 最高気温(分) を取得
                Dim d = New Data() With
                {
                    .Id = Integer.Parse(vals(0)),
                    .Place1 = vals(1),
                    .Place2 = vals(2),
                    .TemperatureMax = Double.Parse(vals(9)),
                    .MaxHour = Integer.Parse(vals(11)),
                    .MinMinitue = Integer.Parse(vals(12))
                }
                data.Add(d)
            End If
        Next

        ' 最低気温CSVをパースする
        lst = csvmin.Split(New String() {vbCrLf},
      StringSplitOptions.None).ToList()
        lst.RemoveAt(0)
        For Each line In lst

            Dim vals = line.Split(New String() {","},
          StringSplitOptions.None)
            If vals.Count() > 13 Then
                ' 観測番号, 都道府県, 地点, 最低気温, 最低気温(時), 最低気温(分) を取得
                Dim id = Integer.Parse(vals(0))
                Dim temp = Double.Parse(vals(9))
                Dim hour = Integer.Parse(vals(11))
                Dim min = Integer.Parse(vals(12))
                Dim d = data.First(Function(x) x.Id = id)
                If d Is Nothing Then
                    d.TemperatureMin = temp
                    d.MinHour = hour
                    d.MinMinitue = min
                End If
            End If
        Next
        TextBox1.Text = "取得完了"

        ' Excel に出力する
        Dim xapp = New Excel.Application()
        Dim wb = xapp.Workbooks.Add()
        Dim sh = wb.ActiveSheet
        sh.Cells(1, 1).Value = "観測番号"
        sh.Cells(1, 2).Value = "都道府県"
        sh.Cells(1, 3).Value = "地点"
        sh.Cells(1, 4).Value = "最低気温"
        sh.Cells(1, 5).Value = "時分"
        sh.Cells(1, 6).Value = "最高気温"
        sh.Cells(1, 7).Value = "時分"
        Dim r = 2
        xapp.Visible = True
        For Each d In data
            sh.Cells(r, 1).Value = d.Id
            sh.Cells(r, 2).Value = d.Place1
            sh.Cells(r, 3).Value = d.Place1
            sh.Cells(r, 4).Value = d.TemperatureMax
            sh.Cells(r, 5).Value = $"{d.MaxHour}:{d.MaxMinitue}"
            sh.Cells(r, 6).Value = d.TemperatureMin
            sh.Cells(r, 7).Value = $"{d.MinHour}:{d.MinMinitue}"
            r = r + 1
        Next
        xapp.Quit()
    End Sub
End Class
Public Class Data
    Public Property Id As Integer
    Public Property Place1 As String
    Public Property Place2 As String
    Public Property TemperatureMax As Double
    Public Property TemperatureMin As Double
    Public Property MaxHour As Integer
    Public Property MaxMinitue As Integer
    Public Property MinHour As Integer
    Public Property MinMinitue As Integer
End Class
