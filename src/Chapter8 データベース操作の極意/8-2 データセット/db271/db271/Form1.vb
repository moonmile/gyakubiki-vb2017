Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データテーブルに取得する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 商品", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        'データセットからデータを抽出して表示する
        Dim view = New DataView(dt, "定価>=330", "",
            DataViewRowState.CurrentRows)
        ListBox1.Items.Clear()
        For i As Integer = 0 To view.Count - 1
            Dim s = ""
            For j As Integer = 0 To view.Table.Columns.Count - 1
                s += view(i)(j) & " "
            Next
            ListBox1.Items.Add(s)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        'データテーブルに取得する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 商品", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        'データセットからLINQで抽出して表示する
        Dim q = From t In dt
                Where t("定価") >= 330
                Select String.Join(" ", t.ItemArray)
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
