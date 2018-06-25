Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim fname1 = TextBox1.Text
        Dim fname2 = TextBox2.Text
        '移動元フォルダーが存在し、移動先フォルダーが存在しなければ移動
        If System.IO.Directory.Exists(fname1) = True AndAlso
            System.IO.Directory.Exists(fname2) = False Then
            System.IO.Directory.Move(fname1, fname2)
            Label1.Text = "移動しました。"
        Else
            Label1.Text = "移動できませんでした。"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim fname1 = TextBox1.Text
        Dim fname2 = TextBox2.Text
        '移動元ファイルが存在し、移動先ファイルが存在しなければ移動
        If System.IO.File.Exists(fname1) = True AndAlso
            System.IO.File.Exists(fname2) = False Then
            System.IO.File.Move(fname1, fname2)
            Label1.Text = "移動しました。"
        Else
            Label1.Text = "移動できませんでした。"
        End If
    End Sub
End Class
