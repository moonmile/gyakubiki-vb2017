Public Class Form1
    Private Sub Button10_Click(sender As Object, e As EventArgs) _
        Handles Button10.Click
        Dim lst = New List(Of Control)()
        For Each c As Control In Me.Controls
            lst.Add(c)
        Next
        ' ボタンコントロールのみ取得
        Dim q = From c In lst
                Where TypeOf c Is Button Select c.Name
        ' リストボックスに表示する
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
