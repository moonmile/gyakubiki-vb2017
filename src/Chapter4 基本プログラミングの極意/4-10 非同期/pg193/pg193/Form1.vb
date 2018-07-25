Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        progressBar1.Minimum = 0
        progressBar1.Maximum = 10
        Await Task.Factory.StartNew(
        Sub()
            For i As Integer = 1 To 10
                Me.Invoke(New Action(
                            Sub()
                                label1.Text = String.Format("{0}秒経過", i)
                            End Sub))
                Me.Invoke(New Action(
                            Sub()
                                progressBar1.Value = i
                            End Sub))
                System.Threading.Thread.Sleep(1000)
            Next
        End Sub)
        MessageBox.Show("10秒経過しました")
    End Sub
End Class
