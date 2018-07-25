Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim x As Double = 3
        MessageBox.Show(x & " の平方根　：　" & Math.Sqrt(x), "確認")
    End Sub
End Class
