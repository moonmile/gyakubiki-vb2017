Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        If MaskedTextBox1.MaskCompleted Then
            If IsDate(MaskedTextBox1.Text) Then
                Label2.Text = "生年月日：" & MaskedTextBox1.Text
            Else
                Label2.Text = "正確に入力してください"
                MaskedTextBox1.Clear()
            End If
        Else
            Label2.Text = "最後まで入力してください"
        End If
    End Sub
End Class
