Imports System

Module Program
    ''' <summary>
    ''' コマンドラインからスイッチを取得
    ''' dotnet run -- --help
    ''' </summary>
    ''' <param name="args"></param>
    Sub Main(args As String())
        If args.Length = 0 Then
            Usage()
        ElseIf args.Length = 1 Then
            Select Case args(0)
                Case "-h", "--help"
                    Console.WriteLine("ヘルプスイッチを選択")
                Case "-v", "--version"
                    Console.WriteLine("For Visual Basic 2017")
                Case Else
                    Console.WriteLine("スイッチが違います")
            End Select
        Else
            Usage()
        End If
    End Sub

    Sub Usage()
        Console.WriteLine("逆引き大全 VB2017 サンプル")
        Console.WriteLine(" -h | --help : ヘルプを表示")
        Console.WriteLine(" -b | --version : バージョンを表示")
    End Sub
End Module
