Imports System

Module Program
    ''' <summary>
    ''' �W�����͂̃T���v��
    ''' </summary>
    ''' <param name="args"></param>
    Sub Main(args As String())
        Dim n = 0
        While True
            Dim line = Console.ReadLine()
            If line Is Nothing Then Exit While
            n = n + 1
            Console.WriteLine($"{n:0000}: {line}")
        End While
    End Sub
End Module
