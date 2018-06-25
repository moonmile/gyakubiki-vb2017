Public Class Form1
    Dim a1 As Integer   'CheckBox1の値を代入
    Dim a2 As Integer   'CheckBox2の値を代入
    Dim a3 As Integer   'CheckBox3の値を代入
    Dim a4 As Integer   'CheckBox4の値を代入

    Private Sub CheckBox1_CheckedChanged(sender As Object,
    e As EventArgs) Handles CheckBox1.CheckedChanged
        'チェックが付いていれば変数a1に35000を代入し、
        'チェックが付いていなければ変数a1に0を代入する
        If CheckBox1.Checked Then
            a1 = 35000
        Else
            a1 = 0
        End If
        Label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円")
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object,
    e As EventArgs) Handles CheckBox2.CheckedChanged
        'チェックが付いていれば変数a2に40000を代入し、
        'チェックが付いていなければ変数a2に0を代入する
        If CheckBox2.Checked Then
            a2 = 40000
        Else
            a2 = 0
        End If
        Label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円")

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object,
    e As EventArgs) Handles CheckBox3.CheckedChanged
        'チェックが付いていれば変数a3に20000を代入し、
        'チェックが付いていなければ変数a3に0を代入する
        If CheckBox3.Checked Then
            a3 = 20000
        Else
            a3 = 0
        End If
        Label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円")

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object,
    e As EventArgs) Handles CheckBox4.CheckedChanged
        'チェックが付いていれば変数a4に15000を代入し、
        'チェックが付いていなければ変数a4に0を代入する
        If CheckBox4.Checked Then
            a4 = 15000
        Else
            a4 = 0
        End If
        Label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円")

    End Sub




End Class
