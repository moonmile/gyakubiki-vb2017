Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 1000000
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim i As Long
        For i = 0 To 1000000
            ProgressBar1.Value = i 'プログレスバーの表示更新
        Next
        Label1.Text = "処理が終了しました"
    End Sub
End Class
