Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        Dim xapp As New Microsoft.Office.Interop.Excel.Application()
        xapp.Quit()
    End Sub
End Class
