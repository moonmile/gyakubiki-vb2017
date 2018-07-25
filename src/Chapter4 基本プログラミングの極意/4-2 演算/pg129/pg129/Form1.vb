Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim x As Integer = -1230
        MessageBox.Show(x & " の絶対値　：　" & Math.Abs(x), "確認")
    End Sub
End Class
