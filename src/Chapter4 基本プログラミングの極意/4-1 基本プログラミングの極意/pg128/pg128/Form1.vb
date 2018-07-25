Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim i As Integer = 30
        Dim lng As Long = i   '暗黙の型変換
        Dim d As Double = 123.456
        i = CInt(d)           'キャスト（桁落ちする）
        Label2.Text = i       'ラベルに表示
        Dim o As Object = i   '暗黙の型変換
        o = "Visual Basic 2017"
        Dim s1 As String = DirectCast(o, String)  '強制的にキャスト
        Dim s2 As String = TryCast(o, String)     'キャスト
    End Sub
End Class

