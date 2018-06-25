Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Directoryは、System.IOクラスに属するが、インポートしたので記述を省略できる
        If Directory.Exists(TextBox1.Text) = True Then
            Label2.Text = "フォルダーが見つかりました"
        Else
            Label2.Text = "フォルダーが見つかりません"
        End If
    End Sub
End Class
