Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        ListView1.Clear()
        ListView1.View = View.Details   'リストビューを詳細表示に設定
        ListView1.Columns.Add("ファイル名", 100) '列ヘッダー作成
        ListView1.Columns.Add("ファイルサイズ", 60, HorizontalAlignment.Right)
        ListView1.Columns.Add("更新日", 120)
    End Sub

    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim dirInfo As System.IO.DirectoryInfo
        Dim fileList() As System.IO.FileInfo
        Dim filInfo As System.IO.FileInfo

        ListView1.Items.Clear() 'リストビューの一覧削除

        '指定したフォルダーの存在確認
        If System.IO.Directory.Exists(TextBox1.Text) = False Then
            MessageBox.Show("フォルダーが存在しません", "通知")
            Exit Sub
        End If

        'フォルダーのファイル情報を取得
        dirInfo = New System.IO.DirectoryInfo(TextBox1.Text)
        fileList = dirInfo.GetFiles 'フォルダー内のファイルを取得
        For Each filInfo In fileList 'リストにファイル詳細表示
            Dim fileItem As ListViewItem = New ListViewItem(filInfo.Name)
            fileItem.SubItems.Add(filInfo.Length.ToString)
            fileItem.SubItems.Add(filInfo.LastWriteTime)
            ListView1.Items.Add(fileItem)
        Next
    End Sub
End Class
