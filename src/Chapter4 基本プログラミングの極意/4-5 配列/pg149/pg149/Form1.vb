Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ary = New Integer(4) {}
        label1.Text = ""
        For i As Integer = 0 To 4
            ary(i) = i * 2
            label1.Text &= "ary[" & i & "] = " & ary(i) & ControlChars.Lf
        Next
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim ary = New String(1, 2) {}

        label1.Text = ""
        For i As Integer = 0 To 1
            For j As Integer = 0 To 2
                ary(i, j) = (i + j).ToString()
                label1.Text &= "ary[" & i & ", " & j & "] = " & ary(i, j) & "　"
            Next
            label1.Text &= ControlChars.Lf
        Next
    End Sub
End Class
