Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        Dim text1 = TextBox1.Text
        If text1.StartsWith("My") Then
            Label1.Text = "Myで始まっています。"
        Else
            Label1.Text = "Myで始まっていません。"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
    Handles Button2.Click
        Dim text1 = TextBox1.Text
        If Regex.IsMatch(text1, "^My") Then
            Label1.Text = "Myで始まっています。"
        Else
            Label1.Text = "Myで始まっていません。"
        End If
    End Sub
End Class
