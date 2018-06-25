Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Using ws = New StreamWriter(
        New FileStream(TextBox1.Text, FileMode.Create))
            ws.Write(TextBox2.Text)
        End Using
        Label1.Text = "ファイルに出力しました。"
    End Sub
End Class
