Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim s = ""
        Try
            System.Diagnostics.Process.Start(s)
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "エラー")
        End Try
    End Sub
End Class
