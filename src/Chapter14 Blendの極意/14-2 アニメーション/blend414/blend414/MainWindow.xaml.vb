Imports System.Windows.Media.Animation

Class MainWindow
    '' 前のページへ
    Private Sub OnClockPrev(sender As Object, e As RoutedEventArgs)
        Dim sb = DirectCast(Me.Resources("Storyboard2"), Storyboard)
        sb.Begin()
    End Sub
    ' 次のページへ
    Private Sub OnClickNext(sender As Object, e As RoutedEventArgs)
        Dim sb = DirectCast(Me.Resources("Storyboard1"), Storyboard)
        sb.Begin()
    End Sub
End Class
