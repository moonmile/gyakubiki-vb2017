Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ret = MessageBox.Show("アプリケーションを終了しますか？",
                                "確認", MessageBoxButtons.YesNo)
        If ret = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
