Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品
                Where t.分類 = "本"
                Select t
        DataGridView1.DataSource = q.ToList()
    End Sub
    ''' <summary>
    ''' クエリ式で検索する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品
                Where t.分類 = "本"
                Select t.数量
        Dim sum = q.Sum()
        ' 結果を表示する
        TextBox1.Text = sum
    End Sub
    ''' <summary>
    ''' ラムダ式で検索する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim ent = New Database1Entities()
        ' ラムダ式で検索する
        Dim sum = ent.商品.Where(
            Function(t) t.分類 = "本").Sum(Function(t) t.数量)
        ' 結果を表示する
        TextBox1.Text = sum
    End Sub

End Class
