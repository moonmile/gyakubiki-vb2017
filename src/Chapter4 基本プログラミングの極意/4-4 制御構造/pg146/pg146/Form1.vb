Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim str As String = ""

        For Each chk As CheckBox In groupBox1.Controls
            If chk.Checked = True Then
                str &= chk.Text & ControlChars.Tab
            End If
        Next

        If str <> "" Then
            MessageBox.Show(str & ControlChars.Lf & "が選ばれました。", "確認")
        End If

    End Sub
End Class
