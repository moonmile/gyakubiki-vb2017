Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' パスを作成する
        Dim path = New GraphicsPath()
        path.StartFigure()
        path.AddEllipse(0, 0, PictureBox1.Width, PictureBox1.Height)
        path.CloseFigure()
        ' 領域を設定する
        Region = New Region(path)
    End Sub
End Class
