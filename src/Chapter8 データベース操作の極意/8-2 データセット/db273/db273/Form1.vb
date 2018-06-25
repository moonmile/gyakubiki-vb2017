Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データテーブルに取得し、テーブルの最初のフィールドの型を表示する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 社員", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        Dim name = dt.Columns(0).DataType.ToString()
        MessageBox.Show("フィールドの型名：" + name, "通知")
    End Sub
End Class
