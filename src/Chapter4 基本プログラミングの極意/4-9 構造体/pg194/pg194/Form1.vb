Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim mn As StructMenu
        '構造体の値を設定し、メソッドを呼び出す
        mn.MenuNo = 1
        mn.Menu = "仙台味噌ラーメン"
        mn.Price = 750
        showData(mn)    '構造体を受け取るメソッドを呼び出す
    End Sub
    '構造体を引数として受け取るメソッド
    Private Sub showData(nMenu As StructMenu)
        MessageBox.Show(nMenu.Menu + "　：　" +
                        nMenu.Price.ToString("0円"), "確認")
    End Sub
End Class

Public Structure StructMenu
    '構造体を定義
    Public MenuNo As Integer
    Public Menu As String
    Public Price As Integer
End Structure


