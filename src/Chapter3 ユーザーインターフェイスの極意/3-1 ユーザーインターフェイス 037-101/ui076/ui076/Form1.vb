Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("イチゴパフェ")
        ComboBox1.Items.Add("バナナアイスクレープ")
        ComboBox1.Items.Add("フォンダンチョコラ")
        ComboBox1.Items.Add("マロンパンケーキ")
    End Sub

    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            Label2.Text = "選択されていません"
        Else
            Label2.Text = ComboBox1.Text
        End If
    End Sub
End Class
