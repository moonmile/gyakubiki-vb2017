Public Class Form1
    '構造体を戻り値として返すメソッド
    Private Function twicePoint(x As Integer, y As Integer) As StructPoint
        Dim aPoint As StructPoint
        aPoint.X = x * 2
        aPoint.Y = y * 2
        Return aPoint  '構造体を返す
    End Function
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim pt As StructPoint

        'メソッドを呼び出して、構造体を戻り値として受け取る
        pt = twicePoint(100, 200)
        MessageBox.Show("xの位置　：　" & pt.X & vbLf & "yの位置　：　" & pt.Y, " 戻り値の構造体の値 ")
    End Sub
End Class
Public Structure StructPoint
    '構造体を定義
    Public X As Integer
    Public Y As Integer
End Structure
