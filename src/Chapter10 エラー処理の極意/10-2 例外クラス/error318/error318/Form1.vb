Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim s = ""
        Try
            ' 空文字を指定
            Label1.Text = Integer.Parse(s).ToString()
        Catch ex As FormatException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
