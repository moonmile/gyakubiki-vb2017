Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim lst = New List(Of String)() From {
            "東京",
            "品川",
            "新横浜"
        }
        'リストボックスの項目をlstに追加する
        For Each val As Object In ListBox1.Items
            lst.Add(val)
        Next
        'テキストボックスの文字列をlstから検索して結果を表示する
        Dim ret As Integer = lst.IndexOf(TextBox1.Text)
        If ret = -1 Then
            Label1.Text = "コレクション内に存在しません。"
        Else
            Label1.Text = TextBox1.Text & "のインデックス：" & ret
        End If
    End Sub
End Class
