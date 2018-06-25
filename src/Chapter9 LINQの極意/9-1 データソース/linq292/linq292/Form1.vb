Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' XMLファイルを読み込む
        Dim persons = XElement.Load("c:\VB2017\persons.xml")
        ' クエリを実行
        Dim q = From p In persons.Descendants("person")
                Where p.Element("name").Value.StartsWith("masuda")
                Select p.Element("name").Value
        ' クエリ結果を表示
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
