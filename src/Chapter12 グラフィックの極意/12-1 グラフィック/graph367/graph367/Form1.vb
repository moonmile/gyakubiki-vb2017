Public Class Form1
    Private page = -1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        Dim img = My.Resources.panorama
        ' ページを進める
        page += 1
        If page >= 5 Then
            page = 0
        End If
        ' 部分を表示する
        Dim pt = New Point(0, page * 208)
        g.DrawImage(img, New Rectangle(0, 0, 277, 208), New Rectangle(0, page * 208, 277, 208), GraphicsUnit.Pixel)
    End Sub
End Class
