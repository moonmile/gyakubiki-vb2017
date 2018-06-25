Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = Me.PictureBox1.CreateGraphics()
        ' リソースから取得する
        Dim img = My.Resources.kaho
        ' 画像を描画する
        g.DrawImage(img, 0, 0)
    End Sub
End Class
