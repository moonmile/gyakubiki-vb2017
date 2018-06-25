Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        '［OK］ボタンが選択されたらラベルに反映
        If colorDialog1.ShowDialog() = DialogResult.OK Then
            Label1.BackColor = colorDialog1.Color
        End If
    End Sub
End Class
