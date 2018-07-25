Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim lst = New SortedList(Of String, String)()

        'コレクションに要素を追加する
        lst("vc") = "Visual Basic"
        lst("pp") = "PowerPoint"
        lst.Add("wd", "Word")
        lst.Add("ac", "Access")

        'lstの要素を順に表示する
        listBox1.Items.Clear()
        For i = 0 To lst.Count - 1
            listBox1.Items.Add(i & " ： " & lst.Keys(i) & " ： " & lst.Values(i))
        Next
        'lstに要素を追加後、要素を順に表示する
        lst.Add("ex", "Excel")
        '要素を追加
        listBox2.Items.Clear()
        For i = 0 To lst.Count - 1
            listBox2.Items.Add(i & " ： " & lst.Keys(i) & " ： " & lst.Values(i))
        Next
    End Sub
End Class
