Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データセットに取得し、DataGridViewに関連付ける
        Dim ad = New OleDbDataAdapter("SELECT * FROM 商品", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
