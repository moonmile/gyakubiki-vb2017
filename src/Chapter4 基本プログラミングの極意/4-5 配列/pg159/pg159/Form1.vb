Public Class Form1
    ''' <summary>
    ''' 一次元配列
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ary = New Integer(4) {}
        Label1.Text = ""
        For i As Integer = 0 To 4
            ary(i) = i * 2
            Label1.Text &= $"ary[{i}] = {ary(i)}" & ControlChars.Lf
        Next
    End Sub
    ''' <summary>
    ''' 二次元配列
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim ary = New Integer(1, 2) {}
        Label1.Text = ""
        For i As Integer = 0 To 1
            For j As Integer = 0 To 2
                ary(i, j) = i + j
                Label1.Text &= $"ary[{i},{j}] = {ary(i, j)}　"
            Next
            Label1.Text &= ControlChars.Lf
        Next
    End Sub
End Class
