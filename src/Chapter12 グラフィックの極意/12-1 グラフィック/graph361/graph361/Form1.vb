Imports System.Drawing.Imaging

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = Me.PictureBox1.CreateGraphics()
        ' 透明度を指定する
        Dim cm = New ColorMatrix()
        cm.Matrix00 = 1.0F
        cm.Matrix11 = 1.0F
        cm.Matrix22 = 1.0F
        cm.Matrix33 = 0.5F
        cm.Matrix44 = 1.0F
        Dim ia = New ImageAttributes()
        ia.SetColorMatrix(cm)
        ' 画像を描画する
        Dim img = My.Resources.book
        Dim rect = New Rectangle(0, 0, img.Width, img.Height)
        g.DrawImage(img, rect, 0, 0, img.Width, img.Height,
            GraphicsUnit.Pixel, ia)
    End Sub
End Class
