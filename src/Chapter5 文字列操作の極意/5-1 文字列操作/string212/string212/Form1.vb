Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text = TextBox1.Text
        Dim pos = -1
        ListBox1.Items.Clear()
        While True
            pos = text.IndexOf("カキ", pos + 1)
            If pos = -1 Then
                Exit While
            End If
            ListBox1.Items.Add((pos + 1) & "文字目")
        End While
    End Sub
End Class
