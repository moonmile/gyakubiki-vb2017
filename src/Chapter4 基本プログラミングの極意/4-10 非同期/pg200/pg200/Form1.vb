Public Class Form1
    Private Sub onTask1()
        Dim i = 0
        While i < 5
            Me.Invoke(New Action(
                Sub()
                    Label1.Text = $"{i}秒経過"
                End Sub))
            System.Threading.Thread.Sleep(1000)
            i = i + 1
        End While
    End Sub
    Private Sub onTask2()
        Dim i = 0
        While i < 10
            Me.Invoke(New Action(
                Sub()
                    Label2.Text = $"{i}秒経過"
                End Sub))
            System.Threading.Thread.Sleep(1000)
            i = i + 1
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Task.Factory.StartNew(
        Sub()
            Me.Invoke(New Action(
                        Sub()
                            Label3.Text = "タスク開始"
                        End Sub))
            Dim task1 = Task.Factory.StartNew(Sub() onTask1())
            Dim task2 = Task.Factory.StartNew(Sub() onTask2())
            ' 複数のタスクの完了を待つ
            Task.WaitAll(task1, task2)
            Me.Invoke(New Action(
                        Sub()
                            Label3.Text = "タスク終了"
                        End Sub))
        End Sub)
    End Sub
End Class
