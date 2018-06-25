Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim s1 = "abc"
        Dim s2 = Nothing
        Try
            'Nothing を渡す
            Label1.Text = s1.Insert(2, s2)
        Catch ex As ArgumentNullException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
