Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text1 = TextBox1.Text
        Dim text2 = TextBox2.Text
        Dim ret = text1.CompareTo(text2)
        '比較
        If ret = 0 Then
            Label1.Text = "同じです。"
        ElseIf ret < 0 Then
            Label1.Text = text1 & "の方が小さいです。"
        Else
            Label1.Text = text1 & "の方が大きいです。"
        End If
    End Sub
End Class
