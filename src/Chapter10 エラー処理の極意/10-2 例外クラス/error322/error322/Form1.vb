Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Try
            ' 存在しないファイルを指定する
            Dim img = Image.FromFile("C:\XYZXYZXYZ.jpg")
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
