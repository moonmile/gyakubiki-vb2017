Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim lst = New List(Of String)()
        'lstに要素を追加する。
        lst.AddRange(New String() {"味噌", "醤油", "お酒"})
        'lstの各要素の値を表示する。
        Label1.Text = ""
        For i As Integer = 0 To lst.Count - 1
            Label1.Text += lst(i) + ControlChars.Lf
        Next
    End Sub
End Class
