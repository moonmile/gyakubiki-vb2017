Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim i As Integer = 11
        listBox1.Items.Clear()
        Do
            listBox1.Items.Add("No." & i)
            i += 1
        Loop While i <= 10 'iが10以下の間繰り返す
    End Sub
End Class
