Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim myTP As TabPage
        Dim myRB As RadioButton
        ListBox1.Items.Clear()
        For Each myTP In TabControl1.TabPages
            For Each myRB In myTP.Controls
                If myRB.Checked Then
                    ListBox1.Items.Add(myRB.Text)
                End If
            Next
        Next
    End Sub
End Class
