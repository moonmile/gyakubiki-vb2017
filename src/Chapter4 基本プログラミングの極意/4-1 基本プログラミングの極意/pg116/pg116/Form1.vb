Public Class Form1
    Const APPLI As String = "Visual VB2015 逆引き大全"
    Const TIPS_NUM As Integer = 500

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const STR As String = "の極意"
        Label1.Text = APPLI & " " & TIPS_NUM & STR
    End Sub
End Class
