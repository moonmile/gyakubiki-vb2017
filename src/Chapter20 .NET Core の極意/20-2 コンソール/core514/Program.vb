Imports System
Imports System.IO
Imports System.Text.RegularExpressions

Module Program
    Sub Main(args As String())
        If args.Length = 0 Then
            Usage()
            Exit Sub
        End If
        Dim pattern = args(0)
        Dim sr As StreamReader
        If args.Length = 1 Then
            ' 標準入力から読み込み
            sr = New StreamReader(Console.OpenStandardInput())
        Else
            ' ファイルから読み込み
            sr = System.IO.File.OpenText(args(1))
            If sr Is Nothing Then
                Console.WriteLine("ファイルが読み込めません " + args(1))
                Exit Sub
            End If
        End If
        Dim n = 1
        While sr.EndOfStream() = False
            Dim line = sr.ReadLine()
            If Regex.IsMatch(line, pattern) Then
                Console.WriteLine($"{n}: {line}")
            End If
            n = n + 1
        End While
        sr.Close()
    End Sub
    Sub Usage()
        Console.WriteLine("dotnet run <パターン> {ファイル名}")
    End Sub
End Module
