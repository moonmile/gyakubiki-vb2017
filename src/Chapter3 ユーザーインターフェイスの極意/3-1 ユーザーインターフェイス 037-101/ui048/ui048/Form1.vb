Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "不透明度：" & Me.Opacity
    End Sub

    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Me.Opacity += 0.1
        Label1.Text = "不透明度：" & Me.Opacity
    End Sub
End Class
