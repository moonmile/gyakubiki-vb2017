Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品 Select t
        ' リストボックスにフォーマットを設定
        ListBox1.FormattingEnabled = True
        AddHandler ListBox1.Format,
        Sub(_s, _e)
            _e.Value = String.Format("{0} {1}円",
                DirectCast(_e.Value, 商品).商品名,
                DirectCast(_e.Value, 商品).単価)
        End Sub
        ' 結果を表示する
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
