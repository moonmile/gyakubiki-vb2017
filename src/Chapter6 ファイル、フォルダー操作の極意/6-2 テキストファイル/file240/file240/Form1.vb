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
            Dim ch As Integer = st.Read()
            '1文字読み取る
            While ch <> -1
                'ファイルの最後まで処理する
                ListBox1.Items.Add(Char.ConvertFromUtf32(ch))
                ch = st.Read()
            End While
        End Using
    End Sub
End Class
