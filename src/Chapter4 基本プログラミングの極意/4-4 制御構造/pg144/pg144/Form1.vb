Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim i As Integer = 1
        listBox1.Items.Clear()
        While i < 11
            'iが11未満の間繰り返す
            listBox1.Items.Add("No." & i)
            i += 1
        End While
    End Sub
End Class
