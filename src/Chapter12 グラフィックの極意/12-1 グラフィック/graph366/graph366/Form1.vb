Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        ' 画像を回転する
        Dim img = My.Resources.book
        Dim mx = New Matrix()
        ' 画像の中央で時計回りに45度回転させる
        mx.RotateAt(45, New Point(img.Width / 2, img.Height))
        g.Transform = mx
        g.DrawImage(img, New Point(0, 0))
    End Sub
End Class
