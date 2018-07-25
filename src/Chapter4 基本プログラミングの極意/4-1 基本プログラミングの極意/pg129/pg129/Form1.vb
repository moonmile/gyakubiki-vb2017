Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim d As Double       '数値型で宣言
        'ラベルの文字列をDouble型に変換して計算する
        d = Double.Parse(Label1.Text) + Double.Parse(Label2.Text)
        'Double型の数値を文字列に変換してラベルに表示する
        Label3.Text = d
    End Sub
End Class
