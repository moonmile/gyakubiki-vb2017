Imports System

Module Program
    ''' <summary>
    ''' �R�}���h���C������X�C�b�`���擾
    ''' dotnet run -- --help
    ''' </summary>
    ''' <param name="args"></param>
    Sub Main(args As String())
        If args.Length = 0 Then
            Usage()
        ElseIf args.Length = 1 Then
            Select Case args(0)
                Case "-h", "--help"
                    Console.WriteLine("�w���v�X�C�b�`��I��")
                Case "-v", "--version"
                    Console.WriteLine("For Visual Basic 2017")
                Case Else
                    Console.WriteLine("�X�C�b�`���Ⴂ�܂�")
            End Select
        Else
            Usage()
        End If
    End Sub

    Sub Usage()
        Console.WriteLine("�t������S VB2017 �T���v��")
        Console.WriteLine(" -h | --help : �w���v��\��")
        Console.WriteLine(" -b | --version : �o�[�W������\��")
    End Sub
End Module
