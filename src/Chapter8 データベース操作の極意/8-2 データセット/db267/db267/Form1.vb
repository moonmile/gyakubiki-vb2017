Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データセットに取得する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 社員", cn)
        Dim ds = New DataSet("t_社員")
        ad.Fill(ds, "t_社員")
        MessageBox.Show("データセットに取得しました。", "通知")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データテーブルに取得する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 社員", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        MessageBox.Show("データテーブルに取得しました。", "通知")
    End Sub
End Class
