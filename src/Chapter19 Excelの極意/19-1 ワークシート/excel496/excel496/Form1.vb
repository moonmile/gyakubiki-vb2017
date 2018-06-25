Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim xapp As New Microsoft.Office.Interop.Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2017\data\Book1.xlsx")
        Dim sh As Microsoft.Office.Interop.Excel.Worksheet = wb.Sheets(1)
        Dim rg = sh.Range("A1", "C1")
        rg.Interior.Color = System.Drawing.Color.FromArgb(100, 255, 100).ToArgb()
        wb.SaveAs("C:\VB2017\data\BookSave.xlsx")
        MessageBox.Show("保存しました")
        xapp.Quit()
    End Sub
End Class
