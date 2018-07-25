Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        '行頭に「'」を記述すると、行全体がコメントになります
        Dim i = 100 * 2
        '行の途中からもコメントにできます
        '次の行は、行頭に「'」があるので実行されません
        'i += 100
        MessageBox.Show($"i = {i}", "確認")
    End Sub
End Class
