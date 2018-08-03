Public Class Form1
    ' 非同期処理
    Private Function onWork() As Task(Of Integer)
        Dim task = New Task(Of Integer)(
            Function()
                ' 合計値を1秒ごとに計算する
                Dim sum As Integer = 0
                For i = 1 To 10
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
        task.ContinueWith(
            Sub(t)
                Dim res As Integer = t.Result
                Me.Invoke(New Action(
                    Sub()
                        Label2.Text = $"合計値 {res}"
                    End Sub))
            End Sub)
        Return task
    End Function

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Await onWork()
    End Sub
End Class
