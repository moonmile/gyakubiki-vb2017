Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim s = "Sample"
        Try
            ' 7文字目から2文字分取得
            Label1.Text = s.Substring(7, 2)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
