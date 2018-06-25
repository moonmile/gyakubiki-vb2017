Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データテーブルに取得し、レコード数を取得して表示する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 社員", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        Dim cnt = dt.Rows.Count
        MessageBox.Show($"テーブルのレコード数：{cnt}", "通知")
    End Sub
End Class
