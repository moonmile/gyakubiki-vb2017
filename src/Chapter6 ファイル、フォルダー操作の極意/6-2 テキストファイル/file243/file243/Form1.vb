Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = TextBox1.Text
        Dim st = File.CreateText(path)
        st.Close()
        Label1.Text = "ファイルを作成しました。"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim path = TextBox1.Text
        Dim st = New StreamWriter(path, False,
            System.Text.Encoding.GetEncoding("shift_jis"))
        st.Close()
        Label1.Text = "ファイルを作成しました。"
    End Sub
End Class
