Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'DBに接続して社員テーブルのレコード数を取得する
        cn.Open()
        Dim cmd = New OleDbCommand(
            "SELECT COUNT(*) FROM 社員", cn)
        Dim num = CInt(cmd.ExecuteScalar())
        cn.Close()
        MessageBox.Show(num & "件のレコードがあります。", "通知")
    End Sub
End Class
