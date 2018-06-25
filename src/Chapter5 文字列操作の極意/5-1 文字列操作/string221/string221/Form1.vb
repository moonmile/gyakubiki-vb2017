Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim textArray = {"aaa", "bbb", "ccc"}
        Dim mark = TextBox1.Text
        Label1.Text = String.Join(mark, textArray)
    End Sub
End Class
