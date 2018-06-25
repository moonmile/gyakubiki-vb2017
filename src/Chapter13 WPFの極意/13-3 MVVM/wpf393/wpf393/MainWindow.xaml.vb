Class MainWindow
    Private _model As New MyModel
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Me.DataContext = _model
    End Sub

    Private Sub clickOutput(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
