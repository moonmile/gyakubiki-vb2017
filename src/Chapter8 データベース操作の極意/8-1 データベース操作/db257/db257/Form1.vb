Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データベースに接続してフィールド名を取得する
        cn.Open()
        Dim dt = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                    {Nothing, Nothing, "社員", Nothing})
        cn.Close()
        'フィールド名をリストボックスに表示する
        Dim q = From t In dt Select t("COLUMN_NAME")
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
