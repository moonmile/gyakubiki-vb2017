Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        ListBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = -1 Then
            Label1.Text = "選択されていません"
        Else
            Label1.Text = ListBox1.SelectedIndex + 1 &
                        "番目：　" & ListBox1.SelectedItem
        End If
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        ListBox1.ClearSelected()
        Label1.Text = ""
    End Sub

End Class
