Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim xapp As New Microsoft.Office.Interop.Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2017\data\Book1.xlsx")
        Dim sh As Microsoft.Office.Interop.Excel.Worksheet = wb.Sheets(1)
        Dim r = 2
        Dim items As New List(Of Data)()
        While sh.Cells(r, 1).Text <> ""
            Dim d As New Data() With {
                .ID = sh.Cells(r, 1).Value,
                .Title = sh.Cells(r, 2).Value,
                .Price = sh.Cells(r, 3).Value
            }
            items.Add(d)
            r = r + 1
        End While
        DataGridView1.DataSource = items
        xapp.Quit()
    End Sub
End Class

Public Class Data
    Public Property ID As Integer
    Public Property Title As String
    Public Property Price As Integer
End Class
