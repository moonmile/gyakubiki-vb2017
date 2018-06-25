Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'DBに接続してトランザクションを開始する
        cn.Open()
        Dim cmd = cn.CreateCommand()
        Dim tr = cn.BeginTransaction()
        'トランザクションを適用し、レコードを追加する
        cmd.Connection = cn
        cmd.Transaction = tr
        cmd.CommandText =
            "INSERT INTO 社員 VALUES(100101, '井ノ上真央', 'B-001')"
        cmd.ExecuteNonQuery()       'レコードを追加
        'トランザクションを確定して接続を閉じる
        tr.Commit()
        MessageBox.Show("処理を終了しました。", "通知")
        cn.Close()
    End Sub
End Class
