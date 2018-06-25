Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = Me.PictureBox1.CreateGraphics()
        ' グラデーションを作成
        Dim br = New LinearGradientBrush(
            New Point(0, 0),
            New Point(0, Me.PictureBox1.Height),
            Color.Green, Color.White)
        ' グラデーションで塗り潰し
        g.FillRectangle(br, 0, 0,
                        Me.PictureBox1.Width, Me.PictureBox1.Height)
    End Sub
End Class
