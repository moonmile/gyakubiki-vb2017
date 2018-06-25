Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = Today.ToShortDateString
    End Sub
End Class
