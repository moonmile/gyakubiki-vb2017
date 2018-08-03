Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim apli = New String() _
            {"PowerPoint", "Word", "Excel", "Access"}
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox1.Items.AddRange(apli)      'ソート前
        Array.Sort(apli)       '昇順でソート
        ListBox2.Items.AddRange(apli)
        Array.Reverse(apli)    '現在と逆順でソート
        ListBox3.Items.AddRange(apli)
    End Sub
End Class
