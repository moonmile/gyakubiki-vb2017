Public Class Form1
    Private Function onWork() As Task(Of Integer)
        Dim task = New Task(Of Integer)(
        Function()
            ' 合計値を1秒ごとに計算する
            Dim sum As Integer = 0
            For i As Integer = 1 To 10
                Me.Invoke(New Action(
                    Sub()
                        Label1.Text = $"{i}秒経過"
                    End Sub))
                sum += i
                System.Threading.Thread.Sleep(1000)
            Next
            Return sum
        End Function)
        task.Start()
        Return task
    End Function

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim sum As Integer = Await onWork()
        MessageBox.Show($"合計値 {sum}")
    End Sub
End Class
