Class MainWindow
    Private _model = New MyModel
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        _model.Items.Add("さる")
        _model.Items.Add("きじ")
        _model.Items.Add("いぬ")
        _model.Items.Add("桃太郎")
        _model.Items.Add("赤おに")
        _model.Items.Add("青おに")
        Me.DataContext = _model
    End Sub
End Class
