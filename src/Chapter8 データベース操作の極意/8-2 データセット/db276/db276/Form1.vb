Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データテーブルに取得する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 社員", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        'コマンドビルダの作成
        Dim builder = New OleDbCommandBuilder(ad)
        'テーブルデータを更新し、データベースに反映する
        dt.Rows(0)("氏名") = "クラリス"
        '氏名フィールド変更
        ad.Update(dt)
        'データベースに反映
        MessageBox.Show("社員テーブルを更新しました。", "通知")
    End Sub
End Class
