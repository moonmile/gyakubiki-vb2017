Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim a = 10
        Dim b = 0
        Try
            If b = 0 Then
                Throw New DivideByZeroException("0で除算はできません")
            End If
            a = a / b
            MessageBox.Show($"a = {a}", "通知")
        Catch ex As DivideByZeroException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
