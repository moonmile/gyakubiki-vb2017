Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ret = proc(10, 20)
        Label1.Text = "取得した戻り値 ： " + ret.ToString()
    End Sub
    '戻り値を返すメソッド
    Private Function proc(x As Integer, y As Integer) As Integer
        Return x * y   '引数をかけ合わせた数値を呼び出し元に戻す
    End Function
End Class
