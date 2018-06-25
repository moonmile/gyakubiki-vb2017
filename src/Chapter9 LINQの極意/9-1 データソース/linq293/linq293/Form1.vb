Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' データベースに接続
        Dim ad = New DataSet1TableAdapters.商品TableAdapter()
        Dim table = ad.GetData()
        ' 商品名を検索
        Dim q = From t In table Select t.商品名
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
