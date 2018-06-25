Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim fname = TextBox1.Text
        If File.Exists(fname) = False Then
            Return
        End If
        '読み取り専用にする
        File.SetAttributes(fname, FileAttributes.ReadOnly)
        Label1.Text = $"{fname}を読み取り専用にしました。"
    End Sub
End Class
