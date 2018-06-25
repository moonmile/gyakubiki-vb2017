Class MainWindow
    Private Sub CheckBox1_Checked(sender As Object, e As RoutedEventArgs)
        If CType(sender, CheckBox).IsChecked = True Then
            InkCanvas1.DefaultDrawingAttributes.Color = Colors.Red
            InkCanvas1.DefaultDrawingAttributes.Width = 10
        Else
            InkCanvas1.DefaultDrawingAttributes.Color = Colors.Black
            InkCanvas1.DefaultDrawingAttributes.Width = 2
        End If
    End Sub
End Class
