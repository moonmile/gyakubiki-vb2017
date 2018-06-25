Class MainWindow
    Private _model = New MyModel()
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Me.DataContext = _model
    End Sub

    Private Sub clickOutput(sender As Object, e As RoutedEventArgs)
        _model.OutText = $"入力:[{_model.InText}]"
    End Sub
End Class
