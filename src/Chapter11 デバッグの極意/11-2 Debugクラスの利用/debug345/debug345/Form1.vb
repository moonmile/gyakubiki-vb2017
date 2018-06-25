Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        For i = 1 To 30
            If i > 25 Then
                ' 警告メッセージと詳細メッセージを表示する
                Debug.Fail("定員オーバーです。",
                    "「簡単クッキングコース」の定員は25名です。")
            End If
        Next
    End Sub
End Class
