Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim a As Integer
        Try
            ' 正常値を代入
            a = 10
            ' 関数を抜ける
            Return
        Catch ex As FormatException
            MessageBox.Show(ex.Message, "エラー発生")
        Finally
            MessageBox.Show("Finallyブロックの処理", "通知")
        End Try
    End Sub
End Class
