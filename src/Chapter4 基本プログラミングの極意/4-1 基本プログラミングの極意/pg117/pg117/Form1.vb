Public Class Form1
    'ClassType列挙型を定義する
    Private Enum ClassType
        'データ型を省略しているのでint型となる
        Special     '0
        Standard    '1
        Basic       '2
    End Enum
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim testResult As ClassType
        'ClassType型で宣言
        Select Case comboBox1.SelectedIndex
            Case CInt(ClassType.Special)
                testResult = ClassType.Special
            Case CInt(ClassType.Standard)
                testResult = ClassType.Standard
            Case Else
                testResult = ClassType.Basic
        End Select
        label1.Text = testResult.ToString()
    End Sub
End Class
