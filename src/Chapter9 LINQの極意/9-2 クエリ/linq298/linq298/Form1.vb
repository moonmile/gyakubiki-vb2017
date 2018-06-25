Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品
                Select New With {t.商品名, t.単価}
        ' 結果を表示する
        DataGridView1.DataSource = q.ToList()
    End Sub
End Class
