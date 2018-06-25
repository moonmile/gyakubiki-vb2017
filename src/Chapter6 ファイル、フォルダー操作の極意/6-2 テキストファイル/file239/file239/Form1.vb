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
            Dim line = st.ReadLine()
            While line IsNot Nothing
                'ファイルの最後まで読み取る
                ListBox1.Items.Add(line)
                line = st.ReadLine()
            End While
        End Using
    End Sub
End Class
