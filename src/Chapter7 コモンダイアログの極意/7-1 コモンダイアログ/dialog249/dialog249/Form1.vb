Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        With fontDialog1
            .ShowColor = True
            '色の選択を可能にする
            'リッチテキストボックスのフォントと色をダイアログに反映
            .Font = RichTextBox1.SelectionFont
            .Color = RichTextBox1.SelectionColor
        End With
        '［OK］ボタンが選択されたらリッチテキストボックスに反映
        If fontDialog1.ShowDialog() = DialogResult.OK Then
            With RichTextBox1
                .SelectionFont = fontDialog1.Font
                .SelectionColor = fontDialog1.Color
            End With
        End If
    End Sub
End Class
