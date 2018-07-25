Public Class Form1
    Private Function Check1()
        Label2.Text += " Check1呼出"
        Return checkBox1.Checked
    End Function
    Private Function Check2()
        Label2.Text += " Check2呼出"
        Return checkBox1.Checked
    End Function
    ''' <summary>
    ''' And演算子
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Label2.Text = ""
        Dim ret = Check1() And Check2()
        Label1.Text = "And演算子の結果：" + ret.ToString()
    End Sub
    ''' <summary>
    ''' AndAlso演算子
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Label2.Text = ""
        Dim ret = Check1() AndAlso Check2()
        Label1.Text = "AndAlso演算子の結果：" + ret.ToString()
    End Sub
    ''' <summary>
    ''' Or演算子
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) _
        Handles Button3.Click
        Label2.Text = ""
        Dim ret = Check1() Or Check2()
        Label1.Text = "Or演算子の結果：" + ret.ToString()
    End Sub
    ''' <summary>
    ''' OrElse演算子
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button4_Click(sender As Object, e As EventArgs) _
        Handles Button4.Click
        Label2.Text = ""
        Dim ret = Check1() OrElse Check2()
        Label1.Text = "OrElse演算子の結果：" + ret.ToString()
    End Sub
End Class
