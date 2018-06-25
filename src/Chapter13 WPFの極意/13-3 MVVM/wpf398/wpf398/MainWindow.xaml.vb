Class MainWindow
    Private _model As New MyModel
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        _model.Items.Add(New MyItem With {.ID = 1, .Name = "増田 智明", .Addr = "東京"})
        _model.Items.Add(New MyItem With {.ID = 2, .Name = "山田 太郎", .Addr = "北海道"})
        _model.Items.Add(New MyItem With {.ID = 3, .Name = "岸和田 次郎", .Addr = "大阪"})
        _model.Items.Add(New MyItem With {.ID = 4, .Name = "林 三郎", .Addr = "沖縄"})
        Me.DataContext = _model
    End Sub
End Class
