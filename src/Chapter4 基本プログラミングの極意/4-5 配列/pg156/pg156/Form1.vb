Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ary1 As Integer() = {10, 20, 30}
        Dim ary2 As Integer() = {6, 7, 8, 9, 0}
        Dim ary3 As Integer() = DirectCast(ary1.Clone(), Integer())   'Cloneメソッドでコピー
        Dim ary4 As Integer() = ary1   '配列を代入
        ary1.CopyTo(ary2, 2)   'CopyToメソッドでコピー
        ary1(0) = 99           'コピー後に値を変更
        '各配列の要素の値を表示する
        label1.Text = "ary1 = "
        label2.Text = "ary2 = "
        label3.Text = "ary3 = "
        label4.Text = "ary4 = "
        For i As Integer = 0 To ary1.Length - 1
            label1.Text += ary1(i) & "  "
        Next
        For i As Integer = 0 To ary2.Length - 1
            label2.Text += ary2(i) & "  "
        Next
        For i As Integer = 0 To ary3.Length - 1
            label3.Text += ary3(i) & "  "
        Next
        For i As Integer = 0 To ary4.Length - 1
            label4.Text += ary4(i) & "  "
        Next

    End Sub
End Class
