Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim apli = New String() {"PowerPoint", "Word", "Excel", "Access"}

        listBox1.Items.Clear()
        listBox2.Items.Clear()
        listBox3.Items.Clear()
        listBox1.Items.AddRange(apli)      'ソート前
        Array.Sort(apli)       '昇順でソート
        listBox2.Items.AddRange(apli)
        Array.Reverse(apli)    '現在と逆順でソート
        listBox3.Items.AddRange(apli)
    End Sub
End Class
