Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ent = New Database1Entities()
        ' 削除対象のレコードを検索する
        Dim q = From t In ent.商品 Where t.Id = 2 Select t
        If q.Count() > 0 Then
            ' テーブルから削除する
            ent.商品.Remove(q.First())
        End If
        ' データベースに反映する
        ent.SaveChanges()
        ' 結果を表示する
        DataGridView1.DataSource = ent.商品.ToList()
    End Sub
End Class
