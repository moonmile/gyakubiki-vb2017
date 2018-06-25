Imports System.IO

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) _
        Handles button1.Click
        Dim fname = TextBox1.Text
        Dim text = TextBox2.Text
        Using ws = File.AppendText(fname)
            ws.WriteLine(text)
        End Using
        Label1.Text = "ファイルに追加しました。"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim fname = TextBox1.Text
        Dim text = TextBox2.Text
        Using ws = New StreamWriter(fname, True,
            System.Text.Encoding.GetEncoding("shift_jis"))
            ws.WriteLine(text)
        End Using
        Label1.Text = "ファイルに追加しました。"
    End Sub
End Class
