Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim a = 10
        Dim b = 20
        Dim sum = a + b
        Label1.Text = sum.ToString()
    End Sub
End Class
