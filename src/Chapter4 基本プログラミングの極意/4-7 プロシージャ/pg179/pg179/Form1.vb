Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        proc(True)                 '2つ目の引数を省略
        proc(False, "数学")        '2つ目の引数に値を1つ渡す
        proc(False, "国語", "社会") '2つ目の引数に値を複数渡す
    End Sub
    Private Sub proc(result As Boolean, ParamArray kamoku As String())
        Dim gouhi As String = "合格"
        If result = False Then
            gouhi = "追試 -->"
        End If
        For Each item As String In kamoku
            gouhi += " " & item
        Next
        MessageBox.Show($"期末試験の結果 　： 　{gouhi}", "確認")
    End Sub
End Class
