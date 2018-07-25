Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim x As Integer = 100
        Label1.Text = x / 20    '100÷20
        x += 20   '100に20を加算
        Label2.Text = x
    End Sub
End Class
