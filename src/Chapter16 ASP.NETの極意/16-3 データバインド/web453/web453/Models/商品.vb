'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはテンプレートから生成されました。
'
'     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
'     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations

Partial Public Class 商品
    <Required(ErrorMessage:="{0}は必須項目です")>
    Public Property 商品ID As Integer
    <Required(ErrorMessage:="{0}は必須項目です")>
    Public Property 商品名 As String
    Public Property 単価 As Integer
End Class
