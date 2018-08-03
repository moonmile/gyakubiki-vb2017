Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim xAry = New Integer(4) {}
        Dim yAry = New Integer(1, 2) {}
        Label1.Text = $"xAry(4)の要素数：{xAry.Length}"
        Label2.Text = $"yAry(1,2)の全要素数：{yAry.Length}" & vbLf &
            $"1つ目の次元の要素数：{yAry.GetLength(0)}" & vbLf &
            $"2つ目の次元の要素数：{yAry.GetLength(1)}"
    End Sub
End Class
