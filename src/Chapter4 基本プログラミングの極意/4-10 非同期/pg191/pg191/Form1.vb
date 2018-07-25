Public Class Form1
    ' 非同期処理
    Private Function onWork() As Task(Of Integer)
        Dim task = New Task(Of Integer)(
        Function()
            ' 合計値を1秒ごとに計算する
            Dim sum As Integer = 0
            For i As Integer = 1 To 10
                Me.Invoke(New Action(
                            Sub()
                                label1.Text = String.Format("{0}秒経過", i)
                            End Sub))
                sum += i
                System.Threading.Thread.Sleep(1000)
            Next
            Return sum
        End Function)
        task.Start()
        Return task
    End Function

    ' 非同期処理を呼び出す
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim sum As Integer = Await onWork()
        MessageBox.Show(String.Format("合計値 {0}", sum))
    End Sub
End Class
