Public Class Form1
    Private Sub ToolStripButton1_Click(sender As Object,
    e As EventArgs) Handles ToolStripButton1.Click
        Dim obj As Object
        For Each obj In Me.Controls
            'オブジェクトがテキストボックスで、
            'そのテキストボックスにフォーカスがあるとき、太字にする
            If TypeOf obj Is TextBox AndAlso TryCast(obj, TextBox).Focused Then
                Dim objText = TryCast(obj, TextBox) 'TextBox型に型変換
                'テキストボックスのフォントスタイルを太字にする
                objText.Font = New Font(objText.Font, FontStyle.Bold)
            End If
        Next
    End Sub
End Class
