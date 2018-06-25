Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "秀和システムのサイトを開きます"
        'リンク文字列の指定とリンク先設定
        LinkLabel1.Links.Add(0, 6, "www.shuwasystem.co.jp")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object,
    e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim linkTarget As String
        '設定されているリンク先を取得
        linkTarget = LinkLabel1.Links(0).LinkData.ToString()
        System.Diagnostics.Process.Start(linkTarget) 'リンク先を開く

        '訪問済みとしてテキストの色を変更
        LinkLabel1.LinkVisited = True
    End Sub
End Class
