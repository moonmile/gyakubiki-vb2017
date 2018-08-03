Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 10
        Await Task.Factory.StartNew(
        Sub()
            Dim i As Integer
            For i = 1 To 10
                Me.Invoke(New Action(
                    Sub()
                        Label1.Text = String.Format("{0}秒経過", i)
                    End Sub))
                Me.Invoke(New Action(
                    Sub()
                        ProgressBar1.Value = i
                    End Sub))
                System.Threading.Thread.Sleep(1000)
            Next
        End Sub)
        MessageBox.Show("10秒経過しました")
    End Sub
End Class
