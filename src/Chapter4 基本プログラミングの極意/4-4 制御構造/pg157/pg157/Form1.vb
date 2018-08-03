Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim str1 = ""
        Dim str2 = ""
        For Each chk As RadioButton In groupBox1.Controls
            If chk.Checked = True Then
                str1 &= chk.Text & "  "
                '処理をループの先頭に戻す
                Continue For
            Else
                str2 &= chk.Text & "  "
            End If
        Next
        If str1 <> "" Then
            MessageBox.Show(str1 & vbLf &
                    "が選択されました。" & vbLf & vbLf &
                    str2 & vbLf &
                    "が選択されませんでした。", "確認")
        End If
    End Sub
End Class
