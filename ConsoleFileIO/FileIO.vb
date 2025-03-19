Option Explicit On
Option Strict On
Option Compare Text
'header stuff
'file IO
'Spring 2025

Imports System.Linq.Expressions

Module FileIO

    Sub Main()
        ' WriteToFile()
        'AppendToFile()
        ReadFromFile()
    End Sub

    Sub WriteToFile()
        'openmode.outout
        'write to the file
        'if the file exists, it overwrites existing data
        'if it doesn't exist, it creates it
        FileOpen(1, "MyCoolFile.txt", OpenMode.Output)

        Write(1, "Wake Up Neo...")
        Write(1, "Follow the white rabbit...")

        FileClose(1)

    End Sub

    Sub AppendToFile()
        'openmode.append
        'append to the end of the file
        'if the file exists, it keeps existing data
        'if it doesn't exist, it creates it
        FileOpen(1, "MyCoolFile.txt", OpenMode.Append)
        For i = 1 To 10
            Write(1, "Follow the white rabbit...")

        Next

        FileClose(1)
    End Sub

    Sub ReadFromFile()
        Dim currentRecord As String
        Dim fileNmae As String = "MyCoolFile.txt"
        '  Try
        FileOpen(1, fileNmae, OpenMode.Input)
        'For i = 1 To 11
        '    Input(1, currentRecord)
        '    Console.WriteLine(currentRecord)

        'Next

        Do Until EOF(1) 'EOF() returns true when there are no more records to read
            Input(1, currentRecord)
            Console.WriteLine(currentRecord)
        Loop

        FileClose(1)


            ' Catch ex As Exception
        ' MsgBox($"Oops! Looks like the file {fileNmae} does not exist...")
        '  End Try

    End Sub

End Module
