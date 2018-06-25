Class MainWindow
    ' 右へ移動
    Private Sub OnClickRight(sender As Object, e As RoutedEventArgs)
        Dim x = Canvas.GetLeft(Me.rect)
        Canvas.SetLeft(Me.rect, x + 20)
    End Sub
    ' 下へ移動
    Private Sub OnClickDown(sender As Object, e As RoutedEventArgs)
        Dim y = Canvas.GetTop(Me.rect)
        Canvas.SetTop(Me.rect, y + 20)
    End Sub
    ' 初期値へ戻す
    Private Sub OnClickInit(sender As Object, e As RoutedEventArgs)
        Canvas.SetLeft(Me.rect, 10)
        Canvas.SetTop(Me.rect, 10)
    End Sub
End Class
