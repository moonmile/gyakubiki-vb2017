﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim bs As BurgerSet
        Dim setSize = {"S", "M", "L"}
        '構造体メンバーの値を設定してから表示する。
        bs.Burger = "ベーコンレタスバーガー"
        bs.Drink.Name = "オレンジジュース"
        bs.Drink.Size = setSize
        '配列を代入
        MessageBox.Show("バーガー名： " + bs.Burger + vbLf &
                    "ドリンク名： " + bs.Drink.Name + vbLf &
                    "ドリンクサイズ： " + bs.Drink.Size(1), "確認")
    End Sub
End Class


Public Structure BurgerSet
    '構造体の定義
    Public Drink As Drink
    '構造体をメンバーとする
    Public Burger As String
End Structure
Public Structure Drink
    '構造体の定義
    Public Name As String
    Public Size As String()
    '配列をメンバーとする
End Structure
