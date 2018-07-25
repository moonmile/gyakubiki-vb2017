Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim sc = New SampleClass("新規お客様")
        sc.ShowData()
        MessageBox.Show("氏名：" + sc.GetName("山田はなこ様"), "確認")
    End Sub
End Class
'SampleClassクラス
Public Class SampleClass
    Private _name As String

    'ThisNameの値を表示するメソッド
    Public Sub ShowData()
        MessageBox.Show("お客様名：　" & _name, "確認")
    End Sub

    '受け取った文字列の最後から「様]を除くメソッド
    Public Function GetName(name As String) As String
        If name.EndsWith("様") Then
            Return name.Substring(0, name.Length - 1)
        Else
            Return name
        End If
    End Function

    'クラスのコンストラクター
    Public Sub New(name As String)
        _name = name
    End Sub
End Class
