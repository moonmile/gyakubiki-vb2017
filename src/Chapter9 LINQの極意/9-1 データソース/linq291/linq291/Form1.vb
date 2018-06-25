Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' データソース
        Dim persons = {
            "masuda tomoaki",
            "masuda yumi",
            "masuda kaho",
            "masuda kazuhisa",
            "shinohara hayato",
            "shinohara shouta"}
        ' クエリを実行
        Dim q = From p In persons
                Where p.StartsWith("masuda") Select p
        ' クエリ結果を表示
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
