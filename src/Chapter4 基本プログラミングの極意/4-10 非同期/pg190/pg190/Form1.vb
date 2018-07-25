Public Class Form1
    Private Sub onTask1()
        For i As Integer = 0 To 4
            Me.Invoke(New Action(
                    Sub()
                        label1.Text = String.Format("{0}秒経過", i)

                    End Sub))
            System.Threading.Thread.Sleep(1000)
        Next
    End Sub
    Private Sub onTask2()
        For i As Integer = 0 To 9
            Me.Invoke(New Action(
                    Sub()
                        label2.Text = String.Format("{0}秒経過", i)

                    End Sub))
            System.Threading.Thread.Sleep(1000)
        Next
    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Task.Factory.StartNew(
        Sub()
            Me.Invoke(New Action(
                        Sub()
                            label3.Text = "タスク開始"
                        End Sub))
            Dim task1 = Task.Factory.StartNew(Sub() onTask1())
            Dim task2 = Task.Factory.StartNew(Sub() onTask2())
            ' 複数のタスクの完了を待つ
            Task.WaitAll(task1, task2)
            Me.Invoke(New Action(
                        Sub()
                            label3.Text = "タスク終了"

                        End Sub))
        End Sub)
    End Sub
End Class
