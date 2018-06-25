Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Minimum = 1            '最小値の設定
        NumericUpDown1.Maximum = 100           '最大値の設定
        NumericUpDown1.Value = 50              '現在値の設定
        NumericUpDown1.Increment = 5            '増減値の設定
    End Sub
End Class
