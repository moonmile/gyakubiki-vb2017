Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        MessageBox.Show("[OK]ボタンがクリックされました", "結果")
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        MessageBox.Show("[キャンセル]します", "結果")
        Me.Close()
    End Sub

End Class
