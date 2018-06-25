Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = Label1.Text
        Label2.Text = System.IO.Path.GetDirectoryName(path)
        Label3.Text = System.IO.Path.GetFileName(path)
    End Sub
End Class
