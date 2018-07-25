Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xAry As Integer() = New Integer(4) {}
        Dim yAry As Integer(,) = New Integer(1, 2) {}

        label1.Text = "xAry(4)の要素数：" & xAry.Length
        label2.Text = "yAry(1,2)の全要素数：" & yAry.Length & vbLf &
            "1つ目の次元の要素数：" & yAry.GetLength(0) & vbLf &
            "2つ目の次元の要素数：" & yAry.GetLength(1)
    End Sub
End Class
