Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ret As Integer = retProc(10, 20)
        label1.Text = "取得した戻り値 ： " + ret.ToString()
    End Sub
    '戻り値を返すメソッド
    Private Function retProc(x As Integer, y As Integer) As Integer
        Return x * y   '引数をかけ合わせた数値を呼び出し元に戻す
    End Function
End Class
