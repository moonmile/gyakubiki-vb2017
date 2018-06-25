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
        '表示するレコードをDataViewに取得し、DataGridViewに関連付ける
        Dim view = New DataView(dt, "定価>=330", "",
        DataViewRowState.CurrentRows)
        Me.DataGridView1.DataSource = view
    End Sub

    Public Class 商品
        Public Property 商品コード As String
        Public Property 商品名 As String
        Public Property 定価 As Integer
    End Class
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
    Handles Button2.Click
        Dim cn = New OleDbConnection(
        "Provider=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source=C:\VB2017\SampleDB.accdb;")
        'データテーブルに取得する
        Dim ad = New OleDbDataAdapter("SELECT * FROM 商品", cn)
        Dim dt = New DataTable()
        ad.Fill(dt)
        '表示するレコードをDataViewに取得し、DataGridViewに関連付ける
        Dim q = From t In dt
                Where t("定価") >= 330
                Select New 商品 With {
                .商品コード = t("商品コード"),
                .商品名 = t("商品名"),
                .定価 = t("定価")
                }
        Me.DataGridView1.DataSource = q.ToList()
    End Sub
End Class


