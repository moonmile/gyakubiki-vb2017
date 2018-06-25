Imports System
Imports System.IO

Module Program
    ''' <summary>
    ''' 標準出力のサンプル
    ''' </summary>
    ''' <param name="args"></param>
    Sub Main(args As String())
        If args.Length = 0 Then
            Console.WriteLine("ファイルを指定してください")
        Else
            Dim file = args(0)
            Dim n = 0   ' 行数
            Dim c = 0   ' 文字数
            Try
                Using sr = System.IO.File.OpenText(file)
                    While sr.EndOfStream() = False
                        Dim line = sr.ReadLine()
                        n = n + 1
                        c = c + line.Length
                    End While
                End Using
                Console.WriteLine($"{file} {c} {n}")
            Catch ex As Exception
                Console.WriteLine("ファイルが読み込めません " + file)
            End Try
        End If
    End Sub
End Module
