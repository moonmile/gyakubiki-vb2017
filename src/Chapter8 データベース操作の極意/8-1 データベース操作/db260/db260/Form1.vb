Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        '社員番号100091のレコードを追加する（既にある場合はエラー表示）
        cn.Open()
        Try
            Dim cmd = New OleDbCommand(
                "INSERT INTO 社員 " &
                "VALUES(100091, '百田かなこ', 'C-001')", cn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("追加しました。", "通知")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        Finally
            cn.Close()
        End Try
    End Sub
End Class
