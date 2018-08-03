Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim lst = New SortedList(Of String, String)()
        'コレクションに要素を追加する
        lst("vb") = "Visual Basic"
        lst("pp") = "PowerPoint"
        lst.Add("wd", "Word")
        lst.Add("ac", "Access")
        'lstの要素を順に表示する
        ListBox1.Items.Clear()
        Dim i = 0
        For Each it In lst
            ListBox1.Items.Add($"{i} ： {it.Key} ： {it.Value}")
            i += 1
        Next
        'lstに要素を追加後、要素を順に表示する
        lst.Add("ex", "Excel")
        '要素を追加
        ListBox2.Items.Clear()
        i = 0
        For Each it In lst
            ListBox2.Items.Add($"{i} ： {it.Key} ： {it.Value}")
            i += 1
        Next
    End Sub
End Class
