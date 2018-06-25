Imports System.Drawing.Imaging

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = Me.PictureBox1.CreateGraphics()
        Dim img1 = My.Resources.kaho
        Dim img2 = My.Resources.frame
        ' 透明色を設定する
        Dim ia = New ImageAttributes()
        ia.SetColorKey(Color.Red, Color.Red)
        ' 背景の画像を描画する
        g.DrawImage(img1, New Rectangle(New Point(0, 0), img1.Size))
        ' 重ね合わせの画像を描画する
        g.DrawImage(img2, New Rectangle(
                    New Point(0, 0), img2.Size), 0, 0,
                    img2.Width, img2.Height, GraphicsUnit.Pixel, ia)
    End Sub
End Class
