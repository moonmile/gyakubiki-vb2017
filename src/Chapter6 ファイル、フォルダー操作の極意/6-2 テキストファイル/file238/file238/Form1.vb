Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        Dim path = TextBox1.Text
        If File.Exists(path) = False Then
            MessageBox.Show("ファイルが見つかりません。", "通知")
            Return
        End If
        Dim rs = File.OpenRead(path)
        MessageBox.Show("ファイルを開きました。", "通知")
        rs.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
    Handles Button2.Click
        Dim path = TextBox1.Text
        If path = "" Then
            '入力無しなら終了
            Return
        End If
        Dim ws = New StreamWriter(path, True,
                                System.Text.Encoding.Default)
        MessageBox.Show("ファイルを開きました。", "通知")
        ws.Close()
    End Sub
End Class
