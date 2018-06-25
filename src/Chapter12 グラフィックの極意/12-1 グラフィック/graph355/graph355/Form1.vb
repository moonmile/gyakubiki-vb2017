Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles _
        Button1.Click
        Dim g = Me.PictureBox1.CreateGraphics()
        ' 普通の直線
        g.DrawLine(Pens.Black, 0, 0, Me.PictureBox1.Width, 0)
        ' 太い線
        Dim boldPen = New Pen(Color.Black, 5)
        g.DrawLine(boldPen, 0, 30, Me.PictureBox1.Width, 30)
        ' 点線
        Dim dotPen = New Pen(Color.Black)
        dotPen.DashStyle = DashStyle.Dot
        g.DrawLine(dotPen, 0, 60, Me.PictureBox1.Width, 60)
    End Sub
End Class
