Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        '例外を発生させる
        Dim a = Integer.Parse("間違った値")
        MessageBox.Show($"a = {a}")
    End Sub
End Class
