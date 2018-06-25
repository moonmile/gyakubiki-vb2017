Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        'ダイアログボックスの初期設定
        With saveFileDialog1
            .RestoreDirectory = True
            .OverwritePrompt = True
            .Filter = "JPeg（*.jpg）|*.jpg|Gif（*.gif）|*.gif"
        End With
        'ダイアログボックスを表示し、キャンセルなら終了
        If saveFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        'ファイル名を表示し、ピクチャーボックスのイメージを保存する
        Label1.Text = Path.GetFileName(saveFileDialog1.FileName)
        Using fs = DirectCast(saveFileDialog1.OpenFile(), FileStream)
            If saveFileDialog1.FilterIndex = 1 Then
                PictureBox1.Image.Save(fs, Imaging.ImageFormat.Jpeg)
            Else
                PictureBox1.Image.Save(fs, Imaging.ImageFormat.Gif)
            End If
        End Using
        Label2.Text = "保存しました。"
    End Sub
End Class
