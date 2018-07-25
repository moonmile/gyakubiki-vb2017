Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ret = MessageBox.Show("ボタンをクリックしてください。", "通知",
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Question)
        Select Case ret
            Case DialogResult.Yes
                label1.Text = "［はい］がクリックされました。"
            Case DialogResult.No
                label1.Text = "［いいえ］がクリックされました。"
            Case Else
                label1.Text = "［キャンセル］がクリックされました。"
        End Select
    End Sub
End Class
