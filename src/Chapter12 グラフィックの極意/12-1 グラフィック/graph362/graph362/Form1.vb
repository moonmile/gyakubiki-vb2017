Imports System.Drawing.Imaging

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = Me.PictureBox1.CreateGraphics()
        ' セピア色に変換する
        Dim cm = New ColorMatrix()
        cm.Matrix00 = 0.393F
        cm.Matrix01 = 0.349F
        cm.Matrix02 = 0.272F
        cm.Matrix10 = 0.769F
        cm.Matrix11 = 0.686F
        cm.Matrix12 = 0.534F
        cm.Matrix20 = 0.189F
        cm.Matrix21 = 0.168F
        cm.Matrix22 = 0.131F
        cm.Matrix33 = 1.0F
        cm.Matrix44 = 1.0F
        Dim ia = New ImageAttributes()
        ia.SetColorMatrix(cm)
        ' 画像を描画する
        Dim img = My.Resources.kaho
        Dim rect = New Rectangle(0, 0, img.Width, img.Height)
        g.DrawImage(img, rect, 0, 0, img.Width, img.Height,
        GraphicsUnit.Pixel, ia)
    End Sub
End Class
