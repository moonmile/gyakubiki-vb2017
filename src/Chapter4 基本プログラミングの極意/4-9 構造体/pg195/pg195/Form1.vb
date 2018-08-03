Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim pt As Point
        'メソッドを呼び出して、構造体を戻り値として受け取る
        pt = twicePoint(100, 200)
        MessageBox.Show("xの位置　：　" & pt.X & vbLf &
                        "yの位置　：　" & pt.Y,
                        " 戻り値の構造体の値 ")
    End Sub
    '構造体を戻り値として返すメソッド
    Private Function twicePoint(x As Integer, y As Integer) As Point
        Dim pt As Point
        pt.X = x * 2
        pt.Y = y * 2
        Return pt  '構造体を返す
    End Function
End Class

Public Structure Point
    '構造体を定義
    Public X As Integer
    Public Y As Integer
End Structure


