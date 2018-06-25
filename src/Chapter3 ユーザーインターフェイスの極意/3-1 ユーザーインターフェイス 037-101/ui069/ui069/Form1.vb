Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Image.FromFile("C:\VB2017\himeji.jpg")
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object,
    e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            PictureBox1.Image = My.Resources.text01
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
        End If
    End Sub

End Class
