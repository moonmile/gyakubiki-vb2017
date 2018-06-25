Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        '社員番号100091のレコードを変更する
        cn.Open()
        Try
            Dim cmd = New OleDbCommand(
                "UPDATE 社員 SET 氏名='高城かなこ' " &
                " WHERE 社員番号=100091", cn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("変更しました。", "通知")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        Finally
            cn.Close()
        End Try
    End Sub
End Class
