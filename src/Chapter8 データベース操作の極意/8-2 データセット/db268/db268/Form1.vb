Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'DataTableオブジェクトに取得する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 社員", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        'すべてのレコードのすべてのフィールドの値を出力する
        Dim q = From r In dt
                Select String.Join(" ", r.ItemArray)
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
