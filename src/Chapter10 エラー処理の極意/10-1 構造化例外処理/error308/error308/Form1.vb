Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim a As Integer
        Try
            a = Integer.Parse("間違った値")
        Catch ex As ArgumentNullException
            MessageBox.Show("引数が無効です", "エラー発生")
        Catch ex As Exception
            MessageBox.Show("予期しないエラーが発生しました", "エラー発生")
        End Try
    End Sub
End Class
