Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ret = Await Task.Factory.StartNew(Function()
                                                  For i As Integer = 0 To 9
                                                      Me.Invoke(New Action(Sub()
                                                                               label1.Text = String.Format("{0}秒経過", i)

                                                                           End Sub))
                                                      System.Threading.Thread.Sleep(1000)
                                                  Next
                                                  Return DateTime.Now
                                              End Function)
        label1.Text = String.Format("最終時刻:{0}", ret)
    End Sub
End Class
