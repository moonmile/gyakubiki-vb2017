Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' テキスト形式でペーストする
        If Clipboard.ContainsText() Then
            Dim text = Clipboard.GetText()
            TextBox1.Text = text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ' 画像形式でペーストする
        If Clipboard.ContainsImage() Then
            Dim image = Clipboard.GetImage()
            PictureBox1.Image = image
        End If
    End Sub
End Class
