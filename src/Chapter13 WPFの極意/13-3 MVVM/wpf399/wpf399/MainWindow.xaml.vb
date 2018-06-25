Class MainWindow
    Private _model As New MyModel
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        _model.Text = ""
        _model.FillColor = New SolidColorBrush(Colors.White)
        Me.DataContext = _model
    End Sub
End Class
