Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim n = Integer.Parse(TextBox1.Text)
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品 Order By t.Id
                Skip n Take 1
        ' 結果を表示する
        DataGridView1.DataSource = q.ToList()
    End Sub
End Class
