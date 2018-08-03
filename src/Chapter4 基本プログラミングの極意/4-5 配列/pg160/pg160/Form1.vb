Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim names As String() = {"荒俣", "夢野", "沼", "柄谷", "上野"}
        Dim i As Integer
        If ComboBox1.SelectedIndex = -1 Then
            '選択されていないとき
            Label1.Text = "クラスを選択してください。"
            Return
        End If
        i = ComboBox1.SelectedIndex
        'インデックスを取得
        Label1.Text = ComboBox1.SelectedItem + $"組の担任：{names(i)}先生"
    End Sub
End Class
