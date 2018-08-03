Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim lstX = {"London", "Paris", "NewYork"}
        Dim lstY = proc(lstX)
        '配列を渡して配列を受け取る
        Label2.Text = ""
        For Each city As String In lstY
            '受け取った配列を表示
            Label2.Text += city & ControlChars.Lf
        Next
    End Sub
    ''' <summary>
    ''' 配列を受け渡しするメソッド
    ''' </summary>
    ''' <param name="lst"></param>
    ''' <returns></returns>
    Private Function proc(lst As String()) As String()
        Label1.Text = ""
        For Each city In lst
            '受け取った配列を表示
            Label1.Text += city & ControlChars.Lf
        Next
        lst(2) = "Tokyo"
        Return lst  '配列を返す
    End Function
End Class
