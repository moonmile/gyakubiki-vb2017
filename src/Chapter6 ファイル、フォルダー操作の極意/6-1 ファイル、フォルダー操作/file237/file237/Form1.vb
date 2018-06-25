Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ListBox1.Items.Clear()
        For Each dInfo In DriveInfo.GetDrives()
            Dim dType = dInfo.DriveType
            ListBox1.Items.Add(dInfo.Name & vbTab & dType.ToString())
        Next
    End Sub
End Class
