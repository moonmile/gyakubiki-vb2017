Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim hash = New System.Collections.Hashtable()

        'コレクションに要素を追加する
        hash("ex") = "Excel"
        hash("pp") = "PowerPoint"
        hash.Add("wd", "Word")
        hash.Add("ac", "Access")

        'キーから値を取得し、文字列に変換して表示
        label1.Text = hash("pp").ToString()

        'キーと値をそれぞれ取得し、リストボックスに表示
        listBox1.Items.Clear()
        For Each key As String In hash.Keys
            listBox1.Items.Add(key)
        Next
        listBox2.Items.Clear()
        For Each val As String In hash.Values
            listBox2.Items.Add(val)
        Next

        'キーと値をセットで取得し、リストボックスに表示
        listBox3.Items.Clear()
        For Each h As System.Collections.DictionaryEntry In hash
            listBox3.Items.Add(h.Key + vbTab + h.Value)
        Next
    End Sub
End Class
