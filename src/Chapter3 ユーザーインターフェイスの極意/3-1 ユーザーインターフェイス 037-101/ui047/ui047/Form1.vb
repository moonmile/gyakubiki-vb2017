Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("OKボタンがクリックされました")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Cancelボタンがクリックされました")
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
        Me.CancelButton = Button2
        Label1.Text =
            "フォームの読み込み時にAcceptボタン、Cancelボタンを設定しました"
        Button1.Text = "OK"
        Button2.Text = "Cancel"
    End Sub
End Class
