Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim newForm As New Form2
        newForm.ShowDialog()
        Label2.Text = newForm.TextBox1.Text
    End Sub
End Class
