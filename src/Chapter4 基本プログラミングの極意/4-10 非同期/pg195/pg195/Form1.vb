Public Class Form1
    Private mre As System.Threading.ManualResetEvent
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        mre = New System.Threading.ManualResetEvent(False)
        Await Task.Factory.StartNew(
        Sub()
            For i As Integer = 1 To 20
                If i = 10 Then
                    ' 10秒後にイベント待ちになる
                    Me.Invoke(New Action(
                                Sub()
                                    label1.Text = "解除イベント待ち"
                                End Sub))
                    mre.Reset()
                    mre.WaitOne()
                End If
                Me.Invoke(New Action(
                            Sub()
                                label1.Text = String.Format("{0}秒経過", i)
                            End Sub))
                System.Threading.Thread.Sleep(1000)
            Next
        End Sub)
        label1.Text = "タスク終了"
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        mre.Set()
    End Sub
End Class
