﻿' 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

''' <summary>
''' それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        text1.Text = "You clicked !!!"
    End Sub
End Class
