Public Class Form1
    Private _task As Task
    ''' <summary>
    ''' タスクを作成する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' ラムダ式を使う場合
        _task = New Task(Sub()
                             For i As Integer = 0 To 59
                                 Me.Invoke(New Action(Sub()
                                                          label1.Text = DateTime.Now.ToString("HH:MM:ss")

                                                      End Sub))
                                 System.Threading.Thread.Sleep(1000)
                             Next

                         End Sub)
        _task.Start()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' メソッドを使う場合
        _task = New Task(AddressOf OnWork)
        _task.Start()
    End Sub

    ' バックグラウンドプロセス
    Private Sub OnWork()
        For i As Integer = 0 To 59
            Me.Invoke(New Action(Sub()
                                     label1.Text = DateTime.Now.ToString("HH:MM:ss")

                                 End Sub))
            System.Threading.Thread.Sleep(1000)
        Next
    End Sub
End Class
