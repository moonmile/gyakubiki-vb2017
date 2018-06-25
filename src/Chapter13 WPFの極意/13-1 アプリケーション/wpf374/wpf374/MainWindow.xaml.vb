Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs)
        ' テキストボックスの文字列をリストへ追加
        Dim s = textBox1.Text
        If s <> "" Then
            listBox1.Items.Add(s)
        End If
    End Sub
End Class
