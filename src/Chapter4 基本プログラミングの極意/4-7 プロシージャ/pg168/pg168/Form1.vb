Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xAry = {"London", "Paris", "NewYork"}

        Dim yAry = aryProc(xAry)
        '配列を渡して配列を受け取る
        label2.Text = ""
        For Each city As String In yAry
            '受け取った配列を表示
            label2.Text += city & ControlChars.Lf
        Next
    End Sub
    '配列を受け渡しするメソッド
    Private Function aryProc(aParam As String()) As String()
        label1.Text = ""
        For Each city As String In aParam
            '受け取った配列を表示
            label1.Text += city & ControlChars.Lf
        Next
        aParam(2) = "Tokyo"
        Return aParam  '配列を返す
    End Function
End Class
