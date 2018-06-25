Imports System.Windows.Media.Animation

Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs)
        Dim sb = DirectCast(Me.Resources("Storyboard1"), Storyboard)
        sb.Begin()
    End Sub
End Class
