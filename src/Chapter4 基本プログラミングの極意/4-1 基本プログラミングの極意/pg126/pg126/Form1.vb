Public Class Form1
    Const APPLI As String = "Visual VB2017 逆引き大全"
    Const TIPS_NUM As Integer = 555

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Const STR As String = "の極意"
        Label1.Text = APPLI & " " & TIPS_NUM & STR
        Label2.Text = $"{APPLI} {TIPS_NUM}{STR}"
    End Sub
End Class
