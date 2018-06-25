Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Label1.Text = ""
        Dialog1.ShowDialog()
        Select Case Dialog1.DialogResult
            Case DialogResult.OK
                Label1.Text = "「OK」がクリックされました"
            Case DialogResult.Cancel
                Label1.Text = "「キャンセル」がクリックされました"
        End Select
    End Sub
End Class
