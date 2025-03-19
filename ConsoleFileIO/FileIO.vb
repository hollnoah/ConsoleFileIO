'header stuff
'file IO
'Spring 2025

Option Explicit On
Option Strict On
Option Compare Text
Module FileIO

    Sub Main()
        WriteToFile()

    End Sub

    Sub WriteToFile()

        FileOpen(1, "MyCoolFile.txt", OpenMode.Output)

        Write(1, "Wake Up Neo...")

        FileClose(1)

    End Sub

End Module
