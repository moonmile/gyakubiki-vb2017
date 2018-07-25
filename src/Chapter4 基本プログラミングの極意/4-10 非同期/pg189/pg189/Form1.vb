Public Class Form1
    Private Sub onTask1()
        For i As Integer = 0 To 9
            Me.Invoke(New Action(Sub()
                                     label1.Text = String.Format("{0}秒経過", i)
                                 End Sub))
            System.Threading.Thread.Sleep(1000)
        Next
    End Sub
    Private Sub onTask2()
        For i As Integer = 0 To 9
            Me.Invoke(New Action(Sub()
                                     label2.Text = String.Format("{0}秒経過", i)
                                 End Sub))
            System.Threading.Thread.Sleep(1000)
        Next
    End Sub

    ' タスクの完了を待つ
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Await Task.Run(Sub() onTask1())
        Await Task.Run(Sub() onTask2())
    End Sub

    ' タスクの完了を待たない
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Task.Run(Sub() onTask1())
        Task.Run(Sub() onTask2())
    End Sub
End Class
