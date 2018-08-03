Imports System.Collections.Generic

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim lst = New ArrayList()
        lst.AddRange(ListBox1.Items)
        '要素を追加
        Label1.Text = "最初の要素：" & lst(0)
        Label2.Text = "要素数：" & lst.Count
    End Sub
End Class
