Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ListBox1.Items.Clear()
        For i = 1 To 10
            ListBox1.Items.Add("No." & i)
        Next
    End Sub
End Class
