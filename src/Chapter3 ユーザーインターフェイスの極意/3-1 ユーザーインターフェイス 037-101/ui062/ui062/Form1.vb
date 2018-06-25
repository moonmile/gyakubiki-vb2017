Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length < 4 Then
            Label2.Text = TextBox1.Text.Length & "…文字数が足りません"
        Else
            Label2.Text = TextBox1.Text.Length
        End If
    End Sub
End Class
