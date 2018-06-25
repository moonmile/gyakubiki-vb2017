Public Class Form1
    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 新規作成ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新規作成ToolStripMenuItem.Click
        Dim myForm As New Form '子フォームの作成
        Dim myRichTextBox As New RichTextBox() 'リッチテキストボックスの作成

        'リッチテキストボックスの設定
        myRichTextBox.Dock = DockStyle.Fill

        '子フォームの設定
        myForm.MdiParent = Me '親フォームを指定
        myForm.Text = "文書" & MdiChildren.Length 'タイトルバーの設定
        myForm.Size = New Size(250, 250)  'フォームのサイズを設定
        myForm.Controls.Add(myRichTextBox) 'リッチテキストボックスの追加
        myForm.Show()　　　　　　　　　　　　'フォームを開く
    End Sub

    Private Sub 左右に整列ToolStripMenuItem_Click(sender As Object,
    e As EventArgs) Handles 左右に整列ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)  '左右に並べて表示
    End Sub

    Private Sub 上下に整列ToolStripMenuItem_Click(sender As Object,
    e As EventArgs) Handles 上下に整列ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)  '上下に並べて表示
    End Sub

    Private Sub 重ねて整列ToolStripMenuItem_Click(sender As Object,
    e As EventArgs) Handles 重ねて整列ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)  '重ねて表示
    End Sub
End Class
