Public Class Form1
    'ClassType列挙型を定義する
    Private Enum ClassType
        'データ型を省略しているのでInteger型となる
        Special     '0
        Standard    '1
        Basic       '2
    End Enum

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        Dim test As ClassType
        'ClassType型で宣言
        Select Case ComboBox1.SelectedIndex
            Case CInt(ClassType.Special)
                test = ClassType.Special
            Case CInt(ClassType.Standard)
                test = ClassType.Standard
            Case Else
                test = ClassType.Basic
        End Select
        Label1.Text = test.ToString()
    End Sub
End Class
