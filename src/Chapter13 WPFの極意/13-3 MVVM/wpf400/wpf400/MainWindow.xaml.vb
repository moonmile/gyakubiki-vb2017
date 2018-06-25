Class MainWindow

    Private _model As New MyModel
    Private Sub clickBind(sender As Object, e As RoutedEventArgs)
        _model.Person = New Person With {
            .ID = 10, .Name = "Tomoaki", .Addr = "Tokyo"}
        _model.Login = New Login With {
            .ID = "xyz", .Pass = "p@ssw0rd", .Mail = "masuda@mail.com"}
        Me.DataContext = _model
    End Sub
End Class
