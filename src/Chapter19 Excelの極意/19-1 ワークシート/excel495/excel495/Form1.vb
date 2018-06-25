Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim xapp As New Microsoft.Office.Interop.Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2017\data\Book1.xlsx")
        Dim sh As Microsoft.Office.Interop.Excel.Worksheet = wb.Sheets(1)
        sh.Range("B2").Value = TextBox1.Text
        wb.SaveAs("C:\VB2017\data\BookSave.xlsx")
        MessageBox.Show("保存しました")
        xapp.Quit()
    End Sub
End Class
