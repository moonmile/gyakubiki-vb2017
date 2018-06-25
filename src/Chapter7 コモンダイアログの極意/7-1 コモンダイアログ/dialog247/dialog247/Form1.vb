Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        'ダイアログボックスの初期設定を行う
        With openFileDialog1
            .Title = "画像ファイルの選択"
            .CheckFileExists = True
            .RestoreDirectory = True
            .Filter = "イメージファイル|*.bmp;*.jpg;*.gif"
        End With
        'ダイアログボックスを表示し、［開く］ボタンが選択されたら
        'ファイル名を表示し、ピクチャボックスに表示する
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Label1.Text = openFileDialog1.FileName
            Label2.Text = openFileDialog1.SafeFileName
            PictureBox1.Image = 
                Image.FromFile(openFileDialog1.FileName)
        Else
            Label1.Text = ""
            Label2.Text = ""
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
