Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ret As Boolean = checkBox1.Checked AndAlso checkBox2.Checked
        label1.Text = "AndAlso演算子の結果：" + ret.ToString()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim ret As Boolean = checkBox1.Checked OrElse checkBox2.Checked
        label1.Text = "OrElse演算子の結果：" + ret.ToString()
    End Sub
End Class
