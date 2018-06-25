Public Class Form1
    Private Sub Button1_Click(sender As Object,
        e As EventArgs) Handles Button1.Click
        Dim newForm As New Form2 'Form2のインスタンスを作成
        'フォームをモーダル表示する
        newForm.Label1.Text = "モーダルで表示しています"
        newForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object,
        e As EventArgs) Handles Button2.Click
        Dim newForm As New Form2
        'フォームをモードレス表示する
        newForm.Label1.Text = "モードレスで表示しています"
        newForm.Show()
    End Sub

End Class
