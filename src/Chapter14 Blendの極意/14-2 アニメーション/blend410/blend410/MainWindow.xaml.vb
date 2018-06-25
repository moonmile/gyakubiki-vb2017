Imports System.Windows.Media.Animation

Class MainWindow
    Private _sb As Storyboard = Nothing
    Private Sub regularPolygon_MouseEnter(sender As Object, e As MouseEventArgs)
        _sb = TryCast(Me.Resources("Storyboard1"), Storyboard)
        ' アニメーションを繰り返す
        _sb.RepeatBehavior = RepeatBehavior.Forever
        _sb.Begin()
    End Sub
    Private Sub regularPolygon_MouseLeave(sender As Object, e As MouseEventArgs)
        If _sb IsNot Nothing Then
            _sb.[Stop]()
            _sb.BeginTime = New TimeSpan(0)
            ' 初期値に戻す
            _sb = Nothing
        End If
    End Sub
End Class
