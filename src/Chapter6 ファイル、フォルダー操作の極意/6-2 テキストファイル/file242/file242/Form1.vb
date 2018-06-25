Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = TextBox1.Text
        If File.Exists(path) = False Then
            MessageBox.Show("ファイルが見つかりません。", "通知")
            Return
        End If
        ListBox1.Items.Clear()
        Using st = New StreamReader(path)
            While st.Peek() <> -1
                ListBox1.Items.Add(st.ReadLine())
            End While
        End Using
    End Sub
End Class
