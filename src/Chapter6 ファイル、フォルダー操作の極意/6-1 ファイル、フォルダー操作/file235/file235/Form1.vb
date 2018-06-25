Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim folder = Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments)
        Label1.Text = folder
    End Sub
End Class
