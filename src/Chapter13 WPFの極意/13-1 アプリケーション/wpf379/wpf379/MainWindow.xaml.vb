Class MainWindow
    Private _isDrag As Boolean  ' ドラッグ中
    Private _offset As Point    ' オフセット
    ''' マウスダウン
    Private Sub OnDragMouseDown(sender As Object, e As MouseButtonEventArgs)
        Dim el = TryCast(sender, UIElement)
        If el IsNot Nothing Then
            ' ドラッグ開始
            _isDrag = True
            ' オフセットを保存
            _offset = e.GetPosition(el)
            ' ドラッグ中は半透明に
            ellipse1.Opacity = 0.5
            ' マウスキャプチャ
            el.CaptureMouse()
        End If
    End Sub
    ''' マウス移動
    Private Sub OnDragMouseMove(sender As Object, e As MouseEventArgs)
        If _isDrag Then
            Dim pt = Mouse.GetPosition(board)
            ellipse1.Margin = New Thickness(pt.X - _offset.X, pt.Y - _offset.Y, 0, 0)
        End If
    End Sub
    ''' マウスアップ
    Private Sub OnDragMouseUp(sender As Object, e As MouseButtonEventArgs)
        If _isDrag Then
            Dim el = TryCast(sender, UIElement)
            ' ドラッグ終了
            _isDrag = False
            ' 透明度を戻す
            ellipse1.Opacity = 1.0
            ' キャプチャをリリース
            el.ReleaseMouseCapture()
        End If
    End Sub
End Class
