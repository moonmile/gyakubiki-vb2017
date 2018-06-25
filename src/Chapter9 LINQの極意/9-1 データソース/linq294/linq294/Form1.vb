Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ent = New Database1Entities()
        Dim q = From t In ent.商品 Select t.商品名
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
