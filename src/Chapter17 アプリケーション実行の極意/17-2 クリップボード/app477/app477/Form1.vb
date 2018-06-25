Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' クリップボードへ転送
        Dim text = TextBox1.Text
        Clipboard.Clear()
        Clipboard.SetData(DataFormats.Html, text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ' クリップボードから取得
        If Clipboard.ContainsData(DataFormats.Html) Then
            Dim html = Clipboard.GetData(DataFormats.Html)
            TextBox1.Text = TryCast(html, String)
        End If
    End Sub
End Class
