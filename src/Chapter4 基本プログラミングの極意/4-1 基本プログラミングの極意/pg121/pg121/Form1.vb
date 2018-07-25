Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim string1 As String = "ワイン"
        Dim string2 As String = "チーズ"

        label1.Text = "C:\VB2015\Sample.txt"
        label2.Text = """C:\VB2015\Sample.txt"""
        label3.Text = string1 & ControlChars.Lf & string2
    End Sub
End Class
