Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'DBに接続してトランザクションを開始する
        cn.Open()
        Dim tr = cn.BeginTransaction()
        MessageBox.Show("トランザクションを開始しました。", "通知")
        'トランザクションを終了して接続を閉じる
        tr.Commit()
        MessageBox.Show("トランザクションを終了しました。", "通知")
        cn.Close()
    End Sub
End Class
