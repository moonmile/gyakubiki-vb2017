Public Class Form1
    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Label1.Text = TreeView1.SelectedNode.FullPath 'ノードのフルパス
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        Dim myNode As TreeNode = TreeView1.SelectedNode
        If TextBox1.Text = "" Then Exit Sub
        If myNode Is Nothing Then
            MessageBox.Show("項目を選択してください", "通知")
            Exit Sub
        End If
        myNode.Nodes.Add(New TreeNode(TextBox1.Text))　'ノードの追加
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myNode As TreeNode = TreeView1.SelectedNode
        If myNode Is Nothing Then
            MessageBox.Show("項目を選択してください", "通知")
            Exit Sub
        End If

        If myNode.Parent Is Nothing Then
            MessageBox.Show("この項目は削除できません", "通知")
        Else
            myNode.Remove() 'ノードの削除
        End If

    End Sub
End Class
