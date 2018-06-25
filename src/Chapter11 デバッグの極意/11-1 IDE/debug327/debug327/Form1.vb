Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = 0
        For i = 1 To 100
            If i Mod 3 = 0 Then
                ' 3の倍数の時
                a = Integer.Parse("3の倍数で例外発生")
            Else
                ' それ以外
                a = Integer.Parse("1")
            End If
        Next
    End Sub
End Class
