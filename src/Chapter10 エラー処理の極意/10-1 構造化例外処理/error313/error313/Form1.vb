Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Try
            ' メソッドを実行
            SampleProc()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
    Private Sub SampleProc()
        Dim a As Integer
        ' フォーマット変換エラーにする
        a = Integer.Parse("間違った値")
        ' 例外はcatchしない
        MessageBox.Show($"a = {a}", "通知")
    End Sub
End Class
