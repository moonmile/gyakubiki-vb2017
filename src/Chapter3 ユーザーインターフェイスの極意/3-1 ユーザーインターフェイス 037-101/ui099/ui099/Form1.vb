Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        TrackBar1.Minimum = 10          '最小値の設定
        TrackBar1.Maximum = 30          '最大値の設定
        TrackBar1.Value = 10            '現在値の設置
        TrackBar1.TickFrequency = 1     '目盛の間隔を設定
        TrackBar1.SmallChange = 1       'ドラッグによる増減値の設定
        TrackBar1.LargeChange = 5       'クリックによる増減値の設定
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object,
    e As EventArgs) Handles TrackBar1.Scroll
        TextBox1.Text = TrackBar1.Value.ToString()
        Dim myFont As Font = Label1.Font
        Label1.Font =
        New Font(myFont.FontFamily, TrackBar1.Value)
    End Sub
End Class
