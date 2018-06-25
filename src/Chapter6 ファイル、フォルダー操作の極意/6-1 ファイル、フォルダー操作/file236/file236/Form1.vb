Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ListBox1.DataSource = Directory.GetLogicalDrives()
    End Sub
End Class
