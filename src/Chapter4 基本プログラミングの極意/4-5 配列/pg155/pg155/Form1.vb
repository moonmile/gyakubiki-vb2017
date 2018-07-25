Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ary As String() = {"東京", "名古屋", "大阪"}
        label1.Text = "ary(0)=" + ary(0) + ", " + "ary(1)=" + ary(1) + ", " + "ary(2)=" + ary(2)
        Array.Clear(ary, 1, 2)  '最後の2つの要素をクリア
        label2.Text = "ary(0)=" + ary(0) + ", " + "ary(1)=" + ary(1) + ", " + "ary(2)=" + ary(2)
    End Sub
End Class
