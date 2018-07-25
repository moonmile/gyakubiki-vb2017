Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dic = New Dictionary(Of String, String)
        '要素を追加する
        dic("ex") = "Excel"
        dic("pp") = "PowerPoint"
        dic.Add("wd", "Word")
        dic.Add("ac", "Access")
        'キーから値を取得して表示する
        label1.Text = dic("wd")
        'キーと値をそれぞれ取得し、リストボックスに表示
        listBox1.Items.Clear()
        For Each myKey As String In dic.Keys
            listBox1.Items.Add(myKey)
        Next
        listBox2.Items.Clear()
        For Each myVal As String In dic.Values
            listBox2.Items.Add(myVal)
        Next
        'キーと値をセットで取得し、リストボックスに表示
        listBox3.Items.Clear()
        For Each myPair In dic
            listBox3.Items.Add(myPair.Key & ControlChars.Tab & myPair.Value)
        Next
    End Sub
End Class
