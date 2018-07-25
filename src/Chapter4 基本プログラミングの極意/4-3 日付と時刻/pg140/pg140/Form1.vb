Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt As DateTime
        Dim ret As Boolean = DateTime.TryParse(textBox1.Text, dt)
        If ret Then
            label1.Text = dt
        Else
            label1.Text = "DateTime型の値に変換できません。"
        End If
    End Sub
End Class
