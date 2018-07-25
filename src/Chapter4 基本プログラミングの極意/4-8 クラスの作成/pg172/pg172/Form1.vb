Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj = New SampleClass("新規お客様")
        MessageBox.Show("SampleClassのインスタンスを生成しました。", "確認")
    End Sub
End Class
'SampleClassクラス
Public Class SampleClass
    Private thisName As String
    Private thisID As String

    'クラスのコンストラクター
    Public Sub New(cName As String)
        thisName = cName
        thisID = DateTime.Now.ToString("yyMMddHHmm")
    End Sub
End Class
