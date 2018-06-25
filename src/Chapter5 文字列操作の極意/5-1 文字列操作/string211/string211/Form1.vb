Imports System.Text.RegularExpressions

Public Class Form1
    ''' <summary>
    ''' 特定の文字列が含まれているか調べる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        If TextBox1.Text.Contains("リス") = True Then
            Label1.Text = "含まれています。"
        Else
            Label1.Text = "含まれていません。"
        End If
    End Sub
    ''' <summary>
    ''' 特定のパターンが含まれているか調べる
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        If Regex.IsMatch(TextBox1.Text, "ク*マ") Then
            Label1.Text = "含まれています。"
        Else
            Label1.Text = "含まれていません。"
        End If
    End Sub
End Class
