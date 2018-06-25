''' <summary>
''' テスト対象のクラス
''' </summary>
Public Class TargetClass
    ''' <summary>
    ''' 足し算
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    Public Function Add(a As Integer, b As Integer) As Integer
        Return a + b
    End Function
    ''' <summary>
    ''' 文字列の連結
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    Public Function Add(a As String, b As String) As String
        Return a + b
    End Function

    Public Function CreatePointer(x As Integer, y As Integer) As XY
        If x < 0 Or y < 0 Then
            Return Nothing
        Else
            Return New XY With {.X = x, .Y = y}
        End If
    End Function
End Class

''' <summary>
''' 座標を保持するクラス
''' </summary>
Public Class XY
    Public Property X As Integer
    Public Property Y As Integer
End Class
