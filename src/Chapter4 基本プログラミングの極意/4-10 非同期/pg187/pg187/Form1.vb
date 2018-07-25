Public Class Form1
    ' タスク生成と同時に実行
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Await Task.Factory.StartNew(Sub()
                                        For i As Integer = 0 To 59
                                            Me.Invoke(New Action(Sub()
                                                                     label1.Text = DateTime.Now.ToString("HH:MM:ss")
                                                                 End Sub))
                                            System.Threading.Thread.Sleep(1000)
                                        Next
                                    End Sub)
    End Sub


    ' 数秒後に実行
    Private Async Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim task__1 As New Task(Sub()
                                    For i As Integer = 0 To 59
                                        Me.Invoke(New Action(Sub()
                                                                 label1.Text = DateTime.Now.ToString("HH:MM:ss")

                                                             End Sub))
                                        System.Threading.Thread.Sleep(1000)
                                     Next
                                End Sub)
        Await Task.Delay(5000)
        task__1.Start()

    End Sub
End Class
