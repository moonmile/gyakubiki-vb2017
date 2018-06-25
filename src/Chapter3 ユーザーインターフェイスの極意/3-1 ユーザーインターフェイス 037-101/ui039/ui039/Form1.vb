Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.MaximizeBox = True And Me.MinimizeBox = True Then
            Me.MaximizeBox = False
            Me.MinimizeBox = False
        Else
            Me.MaximizeBox = True
            Me.MinimizeBox = True
        End If
    End Sub
End Class
