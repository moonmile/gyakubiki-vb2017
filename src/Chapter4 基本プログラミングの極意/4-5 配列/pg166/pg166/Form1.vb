Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ary1 = {10, 20, 30}
        Dim ary2 = {6, 7, 8, 9, 0}
        'Cloneメソッドでコピー
        Dim ary3 = DirectCast(ary1.Clone(), Integer())
        '配列を代入
        Dim ary4 = ary1
        'CopyToメソッドでコピー
        ary1.CopyTo(ary2, 2)
        'コピー後に値を変更
        ary1(0) = 99
        '各配列の要素の値を表示する
        Label1.Text = "ary1 = "
        Label2.Text = "ary2 = "
        Label3.Text = "ary3 = "
        Label4.Text = "ary4 = "
        For i = 0 To ary1.Length - 1
            Label1.Text += ary1(i) & "  "
        Next
        For i = 0 To ary2.Length - 1
            Label2.Text += ary2(i) & "  "
        Next
        For i = 0 To ary3.Length - 1
            Label3.Text += ary3(i) & "  "
        Next
        For i = 0 To ary4.Length - 1
            Label4.Text += ary4(i) & "  "
        Next
    End Sub
End Class
