Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection()
        ' 間違った接続文字列を作成する
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\noneDB.accdb;"
        Try
            cn.Open()
            MessageBox.Show("接続しました。", "通知")
            cn.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
