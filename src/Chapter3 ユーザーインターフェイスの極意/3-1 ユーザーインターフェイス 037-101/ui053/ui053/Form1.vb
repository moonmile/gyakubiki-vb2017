Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Label1.AutoSize = False
        Label1.Size = New Size(300, 40)
        Label1.Text = "現在の日時:" & ControlChars.NewLine & Now.ToString
        Label1.ForeColor = Color.DarkRed
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.TextAlign = ContentAlignment.MiddleCenter
    End Sub
End Class
