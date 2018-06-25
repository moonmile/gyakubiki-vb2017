Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim pos As Integer
        RichTextBox1.SelectionStart = RichTextBox1.SelectionStart +
                                  RichTextBox1.SelectionLength
        RichTextBox1.SelectionLength = 0
        RichTextBox1.Focus()
        pos = RichTextBox1.Find(TextBox1.Text,
                            RichTextBox1.SelectionStart,
                            RichTextBoxFinds.None)
    End Sub
End Class
