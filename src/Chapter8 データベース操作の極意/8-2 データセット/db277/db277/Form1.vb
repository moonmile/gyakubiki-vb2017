Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ds As New DataSet("生物")
        'データセットに新規テーブルを追加する
        Dim dt = ds.Tables.Add("恐竜")
        '追加したテーブルにフィールドを設定する
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("名前", GetType(String))
        MessageBox.Show(
         $"[{ds.Tables(0).TableName}]テーブルを追加しました", "通知")
    End Sub
End Class
