Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim fname = TextBox1.Text
        ListBox1.Items.Clear()
        If File.Exists(fname) = False Then
            'ファイルが無ければ終了
            Return
        End If
        'それぞれの属性をチェックする
        Dim attr = File.GetAttributes(fname)
        If (attr And FileAttributes.[ReadOnly]) <> 0 Then
            ListBox1.Items.Add("読み取り専用")
        End If
        If (attr And FileAttributes.Hidden) <> 0 Then
            ListBox1.Items.Add("隠しファイル")
        End If
        If (attr And FileAttributes.Compressed) <> 0 Then
            ListBox1.Items.Add("圧縮ファイル")
        End If
        If (attr And FileAttributes.System) <> 0 Then
            ListBox1.Items.Add("システムファイル")
        End If
    End Sub
End Class
