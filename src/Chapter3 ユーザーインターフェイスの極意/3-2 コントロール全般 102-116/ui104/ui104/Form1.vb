Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        PictureBox1.Size = New Size(360, 300)
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        PictureBox1.Width = 120
        PictureBox1.Height = 100
    End Sub
End Class
