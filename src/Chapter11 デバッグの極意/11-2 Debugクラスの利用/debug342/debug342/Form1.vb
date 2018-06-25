Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        For i = 1 To 10
            Debug.WriteLineIf(i Mod 2 = 0, $"{i}回目")
        Next
    End Sub
End Class
