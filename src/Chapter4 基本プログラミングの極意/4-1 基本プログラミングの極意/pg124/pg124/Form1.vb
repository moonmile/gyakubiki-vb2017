Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ret = MessageBox.Show("アプリケーションを終了しますか？", "確認", MessageBoxButtons.YesNo)
        If ret = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
