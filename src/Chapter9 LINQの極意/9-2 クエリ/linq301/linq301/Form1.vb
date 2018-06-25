Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ent = New Database1Entities()
        Dim item = New 商品() With {
            .分類 = "商品",
            .商品名 = "追加した商品",
            .単価 = 999,
            .数量 = 10
        }
        ' テーブルに追加する
        ent.商品.Add(item)
        ' データベースに反映する
        ent.SaveChanges()
        ' 結果を表示する
        DataGridView1.DataSource = ent.商品.ToList()
    End Sub
End Class
