Public Class Form1
    Private Sub Button1_HelpRequested(sender As Object,
        hlpevent As HelpEventArgs) Handles Button1.HelpRequested
        'ヘルプボタンをクリックした後、ボタンをクリックした時に
        '実行する処理：メッセージの表示
        MessageBox.Show("ボタンをクリックすると終了します。")
    End Sub

    Private Sub Button1_Click(sender As Object,
        e As EventArgs) Handles Button1.Click
        'ボタンをクリックした時に実行する処理：終了する
        Me.Close()
    End Sub
End Class
