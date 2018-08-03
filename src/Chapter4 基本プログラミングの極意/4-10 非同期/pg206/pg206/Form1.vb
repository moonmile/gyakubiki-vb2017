Imports System.Threading

Public Class Form1
    Private cts As New CancellationTokenSource()

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click

        Dim res = Await Task.Factory.StartNew(Of Boolean)(
        Function()
            Dim i As Integer
            For i = 1 To 10
                If cts.Token.IsCancellationRequested Then
                    Return False
                End If
                Me.Invoke(New Action(
                            Sub()
                                Label1.Text = $"{i}秒経過"
                            End Sub))
                System.Threading.Thread.Sleep(1000)
            Next
            Return True
        End Function, cts.Token)
        If res Then
            Label1.Text = "タスク正常終了"
        Else
            Label1.Text = "タスクがキャンセルされました"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        cts.Cancel()
    End Sub
End Class
