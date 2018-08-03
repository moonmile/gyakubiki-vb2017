Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim i = 11
        ListBox1.Items.Clear()
        Do
            ListBox1.Items.Add("No." & i)
            i += 1
        Loop While i <= 10 'iが10以下の間繰り返す
    End Sub
End Class
