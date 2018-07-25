Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        sampleProc("1月")
        sampleProc(2)
    End Sub
    'string型の引数を受け取るsampleProcメソッド
    Private Sub sampleProc(nextMonth As String)
        MessageBox.Show("次回の放送は 　" & nextMonth & "です。", "通知")
    End Sub

    'int型の引数を受け取るsampleProcメソッド
    Private Sub sampleProc(nextMonth As Integer)
        sampleProc(nextMonth & "月") 'もう一方のSampleProcを呼び出す
    End Sub

End Class
