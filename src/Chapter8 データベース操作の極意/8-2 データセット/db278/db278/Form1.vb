Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ds = New DataSet("生物")
        Dim colData = {2, "ブラキオサウルス"}
        'データセットに新規テーブルを追加し、フィールドを設定する
        Dim dt = ds.Tables.Add("恐竜")
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("名前", GetType(String))
        '作成したテーブルに新しいレコードを追加する
        Dim row = dt.NewRow()
        row("ID") = 1
        row("名前") = "ティラノサウルス"
        dt.Rows.Add(row)
        'DataRowオブジェクトとして追加
        dt.Rows.Add(colData)
        'object型の配列として追加
        '最初のレコードを表示する
        MessageBox.Show("追加したレコード：  " &
                    ds.Tables(0).Rows(0)(0) &
                    "  " &
                    ds.Tables(0).Rows(0)(1), "結果通知")
    End Sub
End Class
