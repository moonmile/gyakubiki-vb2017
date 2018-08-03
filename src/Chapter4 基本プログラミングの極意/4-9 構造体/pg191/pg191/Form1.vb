Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim mn As MyMenu
        '構造体の値を設定し、構造体メンバーのプロパティを使う
        mn.menuNo = 1
        mn.Menu = "仙台味噌ラーメン"
        mn.price = 750
        MessageBox.Show("◎ 大盛り価格　---　￥" &
                        mn.priceBig, mn.Menu)
    End Sub
End Class

Public Structure MyMenu
    '構造体を定義
    Public menuNo As Integer
    Public Menu As String
    Public price As Integer
    Public ReadOnly Property priceBig() As Integer
        'プロパティをメンバーとする
        Get
            Return price + 100
        End Get
    End Property
End Structure

