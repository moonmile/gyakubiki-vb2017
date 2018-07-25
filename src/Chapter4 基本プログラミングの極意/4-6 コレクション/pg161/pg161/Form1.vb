Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim lst = New List(Of String)() From {
            "東京",
            "品川",
            "新横浜"
        }
        'リストボックスの項目をlstに追加する
        For Each val As Object In listBox1.Items
            lst.Add(val)
        Next
        'テキストボックスの文字列をlstから検索して結果を表示する
        Dim ret As Integer = lst.IndexOf(textBox1.Text)
        If ret = -1 Then
            label1.Text = "コレクション内に存在しません。"
        Else
            label1.Text = textBox1.Text & "のインデックス：" & ret
        End If
    End Sub
End Class
