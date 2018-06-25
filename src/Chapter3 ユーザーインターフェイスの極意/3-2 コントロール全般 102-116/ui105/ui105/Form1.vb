Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim x As Integer = PictureBox1.Left
        Dim y As Integer = PictureBox1.Top
        If y >= 200 Then Exit Sub
        PictureBox1.Location = New Point(x + 5, y + 5)
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        PictureBox1.Left = 10
        PictureBox1.Top = 50
    End Sub
End Class
