Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim newForm As New Form2
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)  '左上の位置を指定する
        newForm.Show()                'フォームを表示する
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        Dim newForm As New Form2
        'フォームを画面中央に表示する
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Show()
    End Sub

End Class
