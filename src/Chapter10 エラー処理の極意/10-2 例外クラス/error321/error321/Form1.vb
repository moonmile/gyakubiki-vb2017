Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dname As String = "C:\VB2017\Sample.txt"
        Try
            ' フォルダではなくファイル名を指定する
            For Each fname In System.IO.Directory.GetFiles(dname)
                ListBox1.Items.Add(fname)
            Next
        Catch ex As System.IO.IOException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
