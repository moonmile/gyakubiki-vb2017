Imports System.Data.OleDb

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        Dim ds = New DataSet("t_商品")
        'データセットに取得する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 商品", cn)
        ad.Fill(ds, "t_商品")
        'データセットのレコードを並べ替えて表示する
        Dim view = New DataView(ds.Tables("t_商品"), "",
            "定価 ASC", DataViewRowState.CurrentRows)
        ListBox1.Items.Clear()
        For Each v In view
            ListBox1.Items.Add($"{v("商品名")} {v("定価")}円")
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim cn = New OleDbConnection(
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=C:\VB2017\SampleDB.accdb;")
        Dim ds = New DataSet("t_商品")
        'データセットに取得する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 商品", cn)
        ad.Fill(ds, "t_商品")
        'データセットのレコードを並べ替えて表示する
        Dim q = From t In ds.Tables("t_商品")
                Order By t("定価") Ascending
                Select $"{t("商品名")} {t("定価")}円"
        ListBox1.DataSource = q.ToList()
    End Sub
End Class
