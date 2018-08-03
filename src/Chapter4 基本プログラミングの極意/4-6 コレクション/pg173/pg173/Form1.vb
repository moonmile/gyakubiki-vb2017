

Public Class Form1
    Public Class MyItem
        Public Property Key As String
        Public Property Text As String
    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim lst = New List(Of MyItem)()
        'コレクションに要素を追加する
        lst.Add(New MyItem With {.Key = "vb", .Text = "Visual Basic"})
        lst.Add(New MyItem With {.Key = "pp", .Text = "PowerPoint"})
        lst.Add(New MyItem With {.Key = "wd", .Text = "Word"})
        lst.Add(New MyItem With {.Key = "ac", .Text = "Access"})
        'lstの要素を順に表示する
        ListBox1.Items.Clear()
        For Each it In lst
            ListBox1.Items.Add($"{it.Key} ： {it.Text}")
        Next
        'lstから指定キーを検索する
        Dim item = lst.FirstOrDefault(Function(x)
                                          Return x.Key = TextBox1.Text
                                      End Function)
        If item Is Nothing Then
            Label1.Text = "なし"
        Else
            Label1.Text = item.Text
        End If
    End Sub
End Class
