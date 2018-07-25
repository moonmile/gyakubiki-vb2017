Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim x As Double = 3.0
        MessageBox.Show(x & " の平方根　：　" & Math.Sqrt(x), "確認")
    End Sub
End Class
