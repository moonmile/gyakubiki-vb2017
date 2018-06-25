Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text1 = TextBox1.Text
        Label1.Text = "「" + text1.PadLeft(15) + "」"
        Label2.Text = "「" + text1.PadRight(15) + "」"
    End Sub
End Class
