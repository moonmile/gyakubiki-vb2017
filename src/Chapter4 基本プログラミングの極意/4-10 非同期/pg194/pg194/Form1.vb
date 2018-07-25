Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Await Task.Factory.StartNew(
        Sub()
            For i As Integer = 1 To 10
                Me.Invoke(New Action(
                            Sub()
                                label1.Text = String.Format("{0}秒経過", i)
                            End Sub))
                System.Threading.Thread.Sleep(1000)
            Next
        End Sub)
        label1.Text = "10秒経過"
    End Sub

    Private Async Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Await Task.Factory.StartNew(
        Async Function()
            For i As Integer = 1 To 10
                Me.Invoke(New Action(
                            Sub()
                                label1.Text = String.Format("{0}秒経過", i)
                            End Sub))
                Await Task.Delay(1000)
            Next
        End Function)
        label1.Text = "10秒経過"
    End Sub
End Class
