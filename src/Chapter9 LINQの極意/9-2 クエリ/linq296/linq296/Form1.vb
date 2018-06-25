Public Class Form1
    ''' <summary>
    ''' 昇順で検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品 Order By t.単価 Select t
        ' 結果を表示する
        DataGridView1.DataSource = q.ToList()
    End Sub
    ''' <summary>
    ''' 降順で検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品 Order By t.単価 Descending Select t
        ' 結果を表示する
        DataGridView1.DataSource = q.ToList()
    End Sub
End Class
