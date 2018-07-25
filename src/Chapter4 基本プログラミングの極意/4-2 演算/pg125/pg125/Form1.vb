Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim intX As Integer = 100
        label1.Text = (intX / 20).ToString() '100÷20
        intX += 20   '100に20を加算
        label2.Text = intX.ToString()
    End Sub
End Class
