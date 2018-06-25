Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text1 As String = TextBox1.Text
        Dim textArray = text1.Split("/"c)
        '文字列を分割
        ListBox1.Items.Clear()
        'リストボックスをクリア
        For Each text2 As String In textArray
            ListBox1.Items.Add(text2)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim text1 As String = TextBox1.Text
        Dim textArray = text1.Split({"/"}, StringSplitOptions.None)
        '文字列を分割
        ListBox1.Items.Clear()
        'リストボックスをクリア
        For Each text2 As String In textArray
            ListBox1.Items.Add(text2)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) _
        Handles Button3.Click
        Dim text1 As String = TextBox1.Text
        Dim textArray = Regex.Split(text1, "/")
        '文字列を分割
        ListBox1.Items.Clear()
        'リストボックスをクリア
        For Each text2 As String In textArray
            ListBox1.Items.Add(text2)
        Next
    End Sub
End Class
