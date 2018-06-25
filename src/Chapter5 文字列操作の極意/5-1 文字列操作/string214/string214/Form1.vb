Imports System.Text.RegularExpressions

Public Class Form1
    ''' <summary>
    ''' 指定文字列を置き換える
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text1 = Label1.Text
        Label2.Text = text1.Replace("しまりす", "シマリス")
    End Sub
    ''' <summary>
    ''' パターンを指定して置き換える
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim text1 = Label1.Text
        Label2.Text = Regex.Replace(text1, "し..す", "シマリス")
    End Sub
End Class
