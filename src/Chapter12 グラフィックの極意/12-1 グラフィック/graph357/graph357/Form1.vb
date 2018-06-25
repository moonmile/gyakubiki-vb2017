Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = Me.PictureBox1.CreateGraphics()
        ' 円を描画する
        g.DrawEllipse(Pens.Black, 0, 0, 100, 100)
        ' 塗り潰した円を描画する
        g.FillEllipse(Brushes.Red, 50, 50, 100, 100)
        ' 作成したBrushオブジェクトを指定する
        Dim br = New TextureBrush(My.Resources.book)
        g.FillEllipse(br, 100, 100, 100, 100)
    End Sub
End Class
