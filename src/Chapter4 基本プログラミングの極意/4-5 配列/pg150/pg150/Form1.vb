Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim nameAry As String() = {"荒俣", "夢野", "沼", "柄谷", "上野"}
        Dim i As Integer

        If comboBox1.SelectedIndex = -1 Then
            '選択されていないとき
            label1.Text = "クラスを選択してください。"
            Return
        End If
        i = comboBox1.SelectedIndex
        'インデックスを取得
        label1.Text = comboBox1.SelectedItem + "組の担任：" + nameAry(i) + "先生"

    End Sub
End Class
