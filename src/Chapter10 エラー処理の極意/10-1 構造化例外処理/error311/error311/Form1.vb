Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ary = {1, 2, 3}
        '要素数が3の配列
        Try
            '無効なインデックスを指定
            Dim num = ary(5)
        Catch ex As IndexOutOfRangeException
            MessageBox.Show(ex.Message, "エラー")
        End Try
    End Sub
End Class
