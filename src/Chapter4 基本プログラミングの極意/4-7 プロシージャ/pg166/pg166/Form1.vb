﻿Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim xStr As String = "Param"
        Dim yStr As String = "Param"
        xProc(xStr)        '値渡しで渡す
        yProc(yStr)        '参照渡しで渡す
        label1.Text = Convert.ToString("値渡しの結果：") & xStr
        label2.Text = Convert.ToString("参照渡しの結果：") & yStr
    End Sub
    Private Sub xProc(xParam As String)
        '値渡しの引数を受け取る
        xParam = "Change!"
    End Sub

    Private Sub yProc(ByRef yParam As String)
        '参照渡しの引数を受け取る
        yParam = "Change!"
    End Sub
End Class
