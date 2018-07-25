Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt1 = New DateTime(2016, 2, 25)
        Dim dt2 = New DateTime(2016, 5, 1, 12, 34, 56)
        label1.Text = dt1.ToString()
        label2.Text = dt2.ToString()
    End Sub
End Class
