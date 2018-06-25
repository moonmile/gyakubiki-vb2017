Public Class Form1
    ''' <summary>
    ''' クエリ式で検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品
                Where t.分類 = "本"
                Select t
        Dim cnt = q.Count()
        ' 結果を表示する
        TextBox1.Text = cnt
    End Sub

    ''' <summary>
    ''' Countメソッドにラムダ式を渡す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim cnt = ent.商品.Count(
            Function(t) t.分類 = "本")
        ' 結果を表示する
        TextBox1.Text = cnt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品
                Where t.分類 = "本"
                Select t
        ' 結果を表示する
        DataGridView1.DataSource = q.ToList()
    End Sub
End Class
