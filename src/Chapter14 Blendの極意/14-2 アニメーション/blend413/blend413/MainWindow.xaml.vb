Imports System.Windows.Media.Animation

Class MainWindow
    Private Sub Ellipse_MouseDown(sender As Object, e As MouseButtonEventArgs)
        Dim sb = DirectCast(Me.Resources("Storyboard1"), Storyboard)
        sb.Begin()
    End Sub
End Class
