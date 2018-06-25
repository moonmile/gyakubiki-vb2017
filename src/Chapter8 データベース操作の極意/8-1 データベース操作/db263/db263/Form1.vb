Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        Dim cn = New OleDbConnection(
        "Provider=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=C:\VB2017\SampleDB.accdb;")
        'SQL文を作成して実行する
        cn.Open()
        Dim cmd = New OleDbCommand("SELECT * FROM 社員", cn)
        Using dr = cmd.ExecuteReader()
            '1番目と2番目のフィールドをリストボックスに出力する
            ListBox1.Items.Clear()
            While dr.Read()
                ListBox1.Items.Add(dr.GetInt32(0) &
                                "：" & dr.GetString(1))
            End While
        End Using
        cn.Close()
    End Sub
End Class
