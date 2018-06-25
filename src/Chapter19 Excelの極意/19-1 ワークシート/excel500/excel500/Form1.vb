Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2017\data\Book3.xlsx")
        Dim sh As Excel.Worksheet = wb.Sheets.Add(wb.Sheets(wb.Sheets.Count))
        sh.Name = TextBox1.Text
        ' 保存する
        wb.Save()
        MessageBox.Show("追加しました")
        xapp.Quit()
    End Sub
End Class
