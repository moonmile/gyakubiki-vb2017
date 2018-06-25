Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim panelItem As Object

        For Each panelItem In Panel1.Controls
            panelItem.text = panelItem.GetType.Name
        Next
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        Dim panelItem As Object

        For Each panelItem In Panel1.Controls
            panelItem.text = ""
        Next
    End Sub
End Class
