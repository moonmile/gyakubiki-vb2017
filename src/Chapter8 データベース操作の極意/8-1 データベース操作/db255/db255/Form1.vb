Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        Try
            '接続する
            cn.Open()
            MessageBox.Show($"接続状態　：　{cn.State}", "通知")
            '切断する
            cn.Close()
            MessageBox.Show($"接続状態　：　{cn.State}", "通知")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "通知")
        End Try
    End Sub
End Class
