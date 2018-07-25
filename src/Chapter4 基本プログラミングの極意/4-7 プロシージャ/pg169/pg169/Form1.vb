Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        xProc(True)                 '2つ目の引数を省略
        xProc(False, "数学")        '2つ目の引数に値を1つ渡す
        xProc(False, "国語", "社会") '2つ目の引数に値を複数渡す
    End Sub
    Private Sub xProc(result As Boolean, ParamArray kamoku As String())
        Dim gouhi As String = "合格"

        If result = False Then
            gouhi = "追試 -->"
        End If
        For Each item As String In kamoku
            gouhi += " " & item
        Next
        MessageBox.Show("期末試験の結果 　： 　" & gouhi, "確認")
    End Sub
End Class
