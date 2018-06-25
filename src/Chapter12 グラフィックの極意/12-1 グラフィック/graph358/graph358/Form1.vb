Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = Me.PictureBox1.CreateGraphics()
        Dim points = New Point(3) {}
        ' 多角形を描画する
        points(0) = New Point(50, 0)
        points(1) = New Point(100, 50)
        points(2) = New Point(50, 100)
        points(3) = New Point(0, 50)
        g.DrawLines(Pens.Black, points)
        ' 閉じた多角形を描画する
        points(0) = New Point(100, 0)
        points(1) = New Point(150, 50)
        points(2) = New Point(100, 100)
        points(3) = New Point(50, 50)
        g.DrawPolygon(Pens.Red, points)
    End Sub
End Class
