Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データベースに接続してテーブル名を取得する
        cn.Open()
        Dim dt = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
            {Nothing, Nothing, Nothing, "TABLE"})
        cn.Close()
        'テーブル名をリストボックスに表示する
        ListBox1.Items.Clear()
        For Each dr As DataRow In dt.Rows
            'TABLE_NAME列を表示
            ListBox1.Items.Add(dr("TABLE_NAME"))
        Next
    End Sub
End Class
