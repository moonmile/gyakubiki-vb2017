Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Try
            ' 存在しないフォルダを指定する
            For Each fname In System.IO.Directory.GetFiles("c:\azyx")
                ListBox1.Items.Add(fname)
            Next
        Catch ex As System.IO.DirectoryNotFoundException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
