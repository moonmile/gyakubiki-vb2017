Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        '［テスト］テーブルを作成する
        cn.Open()
        Try
            Dim cmd = New OleDbCommand(
                "CREATE TABLE テスト(コード INT, 商品名 TEXT)", cn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("テーブルを作成しました。", "通知")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        Finally
            cn.Close()
        End Try
    End Sub
End Class
