Class MainWindow
    Private Sub button1_Click(sender As Object, e As RoutedEventArgs)
        Dim ent = New Database1Entities()
        ' LINQで検索する
        Dim q = From t In ent.商品 Select t
        ' ComboBoxにバインド
        comboBox1.DisplayMemberPath = "商品名"
        comboBox1.ItemsSource = q.ToList()
        ' ListViewを表示する
        listView1.ItemsSource = q.ToList()
    End Sub
End Class
