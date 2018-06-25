Public Class Form1
    ''' <summary>
    ''' 数値の足し算
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim a = Integer.Parse(TextBox1.Text)
        Dim b = Integer.Parse(TextBox2.Text)
        Dim t = New TargetClass()
        Dim ans = t.Add(a, b)
        TextBox3.Text = ans
    End Sub

    ''' <summary>
    ''' 文字列の連結
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim a = TextBox1.Text
        Dim b = TextBox2.Text
        Dim t = New TargetClass()
        Dim ans = t.Add(a, b)
        TextBox3.Text = ans
    End Sub

    ''' <summary>
    ''' オブジェクトの生成
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) _
        Handles Button3.Click
        Dim x = Integer.Parse(TextBox1.Text)
        Dim y = Integer.Parse(TextBox2.Text)
        Dim t = New TargetClass()
        Dim obj = t.CreatePointer(x, y)
        TextBox3.Text = obj.ToString()
    End Sub
End Class
