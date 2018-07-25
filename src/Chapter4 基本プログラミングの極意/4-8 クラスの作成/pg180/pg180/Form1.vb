﻿Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        'string型を指定したジェネリッククラスのインスタンスを生成
        Dim genericStr = New MyGeneric(Of String)() With {
            .Value = "Visual Basic"
        }
        'int型を指定したジェネリッククラスのインスタンスを生成
        Dim genericInt = New MyGeneric(Of Integer)() With {
            .Value = 2015
        }
        'それぞれのValueプロパティの値を表示する
        MessageBox.Show(genericStr.Value + "  " + genericInt.Value.ToString(), "確認")
    End Sub
End Class
'ジェネリッククラスの定義
Public Class MyGeneric(Of T)
    Private _val As T
    '型指定できるフィールドの宣言
    Public Property Value() As T
        Get
            Return _val
        End Get
        Set
            _val = Value
        End Set
    End Property
End Class
