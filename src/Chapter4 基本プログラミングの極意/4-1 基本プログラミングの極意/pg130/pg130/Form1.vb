Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        Dim ret = MessageBox.Show("ボタンをクリックしてください。", "通知",
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question)
        Select Case ret
            Case DialogResult.Yes
                Label1.Text = "［はい］がクリックされました。"
            Case DialogResult.No
                Label1.Text = "［いいえ］がクリックされました。"
            Case Else
                Label1.Text = "［キャンセル］がクリックされました。"
        End Select
    End Sub
End Class
