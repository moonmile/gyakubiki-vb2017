Imports System.Threading

Public Class Form1
    Private cts = New CancellationTokenSource()
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim res = Await Task.Factory.StartNew(Of Boolean)(
        Function()
            For i As Integer = 1 To 10
                If cts.Token.IsCancellationRequested Then
                    Return False
                End If
                Me.Invoke(New Action(
                            Sub()
                                label1.Text = String.Format("{0}秒経過", i)
                            End Sub))
                System.Threading.Thread.Sleep(1000)
            Next
            Return True
        End Function, cts.Token)
        If res Then
            label1.Text = "タスク正常終了"
        Else
            label1.Text = "タスクがキャンセルされました"
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        cts.Cancel()
    End Sub
End Class
