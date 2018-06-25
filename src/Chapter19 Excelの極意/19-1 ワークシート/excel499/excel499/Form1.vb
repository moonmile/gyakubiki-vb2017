Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2017\data\Book2.xlsx")
        ListBox1.Items.Clear()
        For Each sh In wb.Sheets
            ListBox1.Items.Add(sh.Name)
        Next
        xapp.Quit()
    End Sub
End Class
