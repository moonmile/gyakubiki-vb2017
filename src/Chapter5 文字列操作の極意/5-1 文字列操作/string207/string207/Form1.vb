Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim code = Asc("A")   '文字をInteger型に変換
        Label1.Text = code.ToString()
    End Sub
End Class
