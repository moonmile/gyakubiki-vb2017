Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim str = ""
        For Each chk As CheckBox In groupBox1.Controls
            If chk.Checked = True Then
                str &= chk.Text & ControlChars.Tab
            End If
        Next
        If str <> "" Then
            MessageBox.Show(str & ControlChars.Lf &
                            "が選ばれました。", "確認")
        End If
    End Sub
End Class
