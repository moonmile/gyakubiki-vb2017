Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim answer As Double       '数値型で宣言
        'ラベルの文字列をdouble型に変換して計算する
        answer = Double.Parse(label1.Text) + Double.Parse(label2.Text)
        'double型の数値を文字列に変換してラベルに表示する
        Me.label3.Text = answer.ToString()
    End Sub
End Class
