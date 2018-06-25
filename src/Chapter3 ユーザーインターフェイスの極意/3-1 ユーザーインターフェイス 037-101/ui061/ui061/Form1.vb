Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object,
    e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.ReadOnly = True 　　'読み取り専用をオンにする
            TextBox2.Enabled = False　　 '使用不可にする
        Else
            TextBox1.ReadOnly = False    '読み取り専用をオフにする
            TextBox2.Enabled = True      '使用可能にする
        End If
    End Sub
End Class
