Public Class Form1
    Private mre As System.Threading.ManualResetEvent

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        mre = New System.Threading.ManualResetEvent(False)
        Await Task.Factory.StartNew(
            Sub()
                Dim i As Integer
                For i = 1 To 20
                    If i = 10 Then
                        ' 10秒後にイベント待ちになる
                        Me.Invoke(New Action(
                            Sub()
                                Label1.Text = "解除イベント待ち"
                            End Sub))
                        mre.Reset()
                        mre.WaitOne()
                    End If
                    Me.Invoke(New Action(
                        Sub()
                            Label1.Text = $"{i}秒経過"
                        End Sub))
                    System.Threading.Thread.Sleep(1000)
                Next
            End Sub)
        Label1.Text = "タスク終了"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        mre.Set()
    End Sub
End Class
