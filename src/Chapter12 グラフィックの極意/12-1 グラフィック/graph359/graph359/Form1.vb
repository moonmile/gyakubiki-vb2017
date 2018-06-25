Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' フォームの背景画像を設定する
        BackgroundImage = My.Resources.book
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ' フォームの背景画像をクリアする
        BackgroundImage = Nothing
    End Sub
End Class
