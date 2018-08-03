Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim lst = New List(Of String)() From {
            "ティラノサウルス",
            "アパトサウルス",
            "マイアサウラ",
            "プテラノドン",
            "ブラキオサウルス"
        }
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())
        'ソート前
        lst.Sort()
        '昇順でソート
        ListBox2.Items.AddRange(lst.ToArray())
        lst.Reverse()
        '逆順でソート
        ListBox3.Items.AddRange(lst.ToArray())
    End Sub
End Class
