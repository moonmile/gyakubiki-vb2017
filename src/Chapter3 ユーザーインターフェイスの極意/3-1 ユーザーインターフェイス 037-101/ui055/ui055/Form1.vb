Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "別のフォームを開きます"
        'リンク文字列を設定
        LinkLabel1.LinkArea = New LinkArea(2, 4)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object,
    e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.ShowDialog()
        LinkLabel1.LinkVisited = True
    End Sub
End Class
