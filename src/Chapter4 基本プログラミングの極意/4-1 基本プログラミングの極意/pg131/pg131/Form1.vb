Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim s1 As String = "ワイン"
        Dim s2 As String = "チーズ"
        Label1.Text = "C:\VB2017\Sample.txt"
        Label2.Text = """C:\VB2017\Sample.txt"""
        Label3.Text = s1 & ControlChars.Lf & s2
        Label4.Text = $"{s1}{ControlChars.Lf}{s2}"
    End Sub
End Class
