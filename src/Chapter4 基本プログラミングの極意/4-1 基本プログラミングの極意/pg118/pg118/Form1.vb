Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim intX As Integer = 30
        Dim longX As Long = intX        '暗黙の型変換
        Dim doubleX As Double = 123.456
        intX = CInt(doubleX)            'キャスト（桁落ちする）
        label1.Text = intX.ToString()   'ラベルに表示
        Dim objectX As Object = intX   '暗黙の型変換
        objectX = "Visual Basic 2015"
        Dim stringX As String = DirectCast(objectX, String)  '強制的にキャスト
        Dim stringY As String = TryCast(objectX, String)     'キャスト
    End Sub
End Class
