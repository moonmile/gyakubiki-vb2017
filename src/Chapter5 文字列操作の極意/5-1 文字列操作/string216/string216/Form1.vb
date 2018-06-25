Imports System.Text.RegularExpressions

Public Class Form1
    ''' <summary>
    ''' Trimメソッドで前後の空白を削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim t = TextBox1.Text
        If t = String.Empty Then
            '入力無しなら終了
            Return
        End If
        Label1.Text = "「" + t.Trim() + "」"
        Label2.Text = "「" + t.TrimStart() + "」"
        Label3.Text = "「" + t.TrimEnd() + "」"
    End Sub
    ''' <summary>
    ''' 正規表現で前後の空白を削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim t = TextBox1.Text
        If t = String.Empty Then
            '入力無しなら終了
            Return
        End If
        Label1.Text = "「" +
            Regex.Replace(t, "^\s*(.*?)\s*$", "$1") + "」"
        Label2.Text = "「" + Regex.Replace(t, "^\s+", "") + "」"
        Label3.Text = "「" + Regex.Replace(t, "\s+$", "") + "」"
    End Sub
End Class
