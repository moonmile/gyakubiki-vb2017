Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'DBに接続してレコードを取得し、フィールド数を出力する
        cn.Open()
        Dim cmd = New OleDbCommand("SELECT * FROM 社員", cn)
        Using dr = cmd.ExecuteReader()
            MessageBox.Show("フィールド数：　" & dr.FieldCount, "通知")
        End Using
        cn.Close()
    End Sub
End Class
