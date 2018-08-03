Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Await Task.Factory.StartNew(
        Sub()
            Dim i As Integer
            For i = 1 To 10
                Me.Invoke(New Action(
                    Sub()
                        Label1.Text = $"{i}秒経過"
                    End Sub))
                System.Threading.Thread.Sleep(1000)
            Next
        End Sub)
        Label1.Text = "10秒経過"
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Await Task.Factory.StartNew(
        Async Function()
            Dim i As Integer
            For i = 1 To 10
                Me.Invoke(New Action(
                            Sub()
                                Label1.Text = $"{i}秒経過"
                            End Sub))
                Await Task.Delay(1000)
            Next
        End Function)
        Label1.Text = "10秒経過"
    End Sub
End Class
