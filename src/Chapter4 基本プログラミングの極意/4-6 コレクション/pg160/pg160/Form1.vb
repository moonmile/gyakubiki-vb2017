Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim lst = New List(Of String)() From {
            "ティラノサウルス",
            "アパトサウルス",
            "マイアサウラ",
            "プテラノドン",
            "ブラキオサウルス"
        }

        listBox1.Items.Clear()
        listBox2.Items.Clear()
        listBox3.Items.Clear()
        listBox1.Items.AddRange(lst.ToArray())
        'ソート前
        lst.Sort()
        '昇順でソート
        listBox2.Items.AddRange(lst.ToArray())
        lst.Reverse()
        '逆順でソート
        listBox3.Items.AddRange(lst.ToArray())

    End Sub
End Class
