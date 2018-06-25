Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim myRB As RadioButton

        For Each myRB In Panel1.Controls
            If myRB.Checked Then
                Label2.Text = myRB.Text & "　が選択されました"
                Exit For
            End If
        Next

    End Sub
End Class
