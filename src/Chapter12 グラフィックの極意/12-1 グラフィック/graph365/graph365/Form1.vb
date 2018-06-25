Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' 画像に合わせてフォームを変形
        PictureBox1.Image = My.Resources.book
        BackColor = Color.Red
        ' 透明色を設定する
        TransparencyKey = Color.Red
        ' フレームを消す
        FormBorderStyle = FormBorderStyle.None
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ' 元に戻す
        TransparencyKey = Color.Empty
        BackColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.Sizable
    End Sub

End Class
