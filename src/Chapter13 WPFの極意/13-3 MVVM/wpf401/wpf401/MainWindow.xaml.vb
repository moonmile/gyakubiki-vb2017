Class MainWindow
    Private Sub clickBind(sender As Object, e As RoutedEventArgs)
        Dim ent = New Database1Entities()
        ' LINQで検索sるう
        Dim q = From t In ent.商品
                Select t
        Me.DataContext = q.ToList()
    End Sub
End Class
