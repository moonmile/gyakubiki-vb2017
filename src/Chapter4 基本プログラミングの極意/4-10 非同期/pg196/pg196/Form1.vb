Public Class Form1
    Private _task As Task
    ''' <summary>
    ''' ラムダ式を使う場合
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        _task = New Task(
            Sub()
                For i As Integer = 0 To 59
                    Me.Invoke(New Action(
                        Sub()
                            label1.Text =
                            DateTime.Now.ToString("HH:MM:ss")
                        End Sub))
                    System.Threading.Thread.Sleep(1000)
                Next
            End Sub)
        _task.Start()
    End Sub
    ''' <summary>
    ''' メソッドを使う場合
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        _task = New Task(AddressOf OnWork)
        _task.Start()
    End Sub
    ' バックグラウンドプロセス
    Private Sub OnWork()
        For i As Integer = 0 To 59
            Me.Invoke(New Action(
                      Sub()
                          label1.Text =
                          DateTime.Now.ToString("HH:MM:ss")
                      End Sub))
            System.Threading.Thread.Sleep(1000)
        Next
    End Sub
End Class
