Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'DBに接続してトランザクションを開始、適用する
        cn.Open()
        Dim cmd = New OleDbCommand(
            "INSERT INTO 社員 " &
            "VALUES(100101, '井ノ上真央', 'B-001')", cn)
        Dim tr = cn.BeginTransaction()
        'トランザクションを開始
        cmd.Transaction = tr
        'トランザクションを適用
        'DBを更新し、トランザクションを確定または中止する
        Try
            cmd.ExecuteNonQuery()
            tr.Commit()
            MessageBox.Show("終了しました。", "通知")
        Catch ex As Exception
            tr.Rollback()
            MessageBox.Show(ex.Message, "エラー")
            MessageBox.Show("ロールバックしました。", "通知")
        End Try
        cn.Close()
    End Sub
End Class
