Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        RichTextBox1.SelectionFont =
            New Font("MS ゴシック", 14, FontStyle.Italic)
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        If RichTextBox1.SelectionColor <> Color.Red Then
            RichTextBox1.SelectionColor = Color.Red
        Else
            RichTextBox1.SelectionColor = Color.Black
        End If
    End Sub

    Private Sub Button3_Click(sender As Object,
    e As EventArgs) Handles Button3.Click
        Dim myFont As Font = RichTextBox1.SelectionFont
        Dim myFS As FontStyle

        If RichTextBox1.SelectionFont.Bold = False Then
            myFS = FontStyle.Bold
        Else
            myFS = FontStyle.Regular
        End If
        RichTextBox1.SelectionFont =
            New Font(myFont.FontFamily, myFont.Size, myFS)
    End Sub
End Class
