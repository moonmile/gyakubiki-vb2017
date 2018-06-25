Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        Dim ad = New OleDbDataAdapter("SELECT * FROM 商品", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        'DataGridViewの最初の列を読み取り専用にしてデータを表示
        Me.DataGridView1.DataSource = dt
        Me.DataGridView1.Columns(0).ReadOnly = True
    End Sub
End Class
