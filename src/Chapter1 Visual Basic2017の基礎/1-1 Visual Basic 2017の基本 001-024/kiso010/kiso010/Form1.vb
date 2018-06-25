Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        '「TextBox1」に「TextBox2」の文字列を追加する
        '引数のあるメソッド
        TextBox2.AppendText(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        '「TextBpx2」の文字列を消去する
        '引数のないメソッド
        TextBox2.Clear()
    End Sub
End Class
