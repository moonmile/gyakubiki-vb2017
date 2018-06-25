Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'テストテーブルを削除する
        Try
            cn.Open()
            Dim cmd = New OleDbCommand("DROP TABLE テスト", cn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("削除しました。", "通知")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        Finally
            cn.Close()
        End Try
    End Sub
End Class
