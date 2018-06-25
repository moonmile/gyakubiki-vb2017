Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            ListBox1.Items.Insert(0, TextBox1.Text)
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            ListBox1.Items.Insert(ListBox1.Items.Count, TextBox1.Text)
            TextBox1.Text = ""
        End If
    End Sub
End Class
