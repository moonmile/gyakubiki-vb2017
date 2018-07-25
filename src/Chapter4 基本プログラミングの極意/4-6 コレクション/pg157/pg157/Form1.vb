Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim lst = New System.Collections.ArrayList()

        lst.AddRange(listBox1.Items)
        '要素を追加
        label1.Text = "最初の要素：" & lst(0)
        label2.Text = "要素数：" & lst.Count
    End Sub
End Class
