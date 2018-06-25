Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim fname = TextBox1.Text
        If fname = "" Then
            '入力無しなら終了
            Return
        End If
        System.IO.Directory.CreateDirectory(fname)
        Label1.Text = $"{fname}を作成しました。"
    End Sub
End Class
