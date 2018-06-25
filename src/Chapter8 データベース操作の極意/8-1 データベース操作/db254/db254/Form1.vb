Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection()
        '接続文字列を設定して接続する
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;"
        Try
            cn.Open()
            MessageBox.Show("接続しました。", "通知")
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        End Try
    End Sub
End Class
