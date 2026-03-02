Imports System.IO
Module Module1 'makes 1001 empty files called hello, hello1, hello2 etc. change the "file" variable to make this work if you dont have a k drive
    Sub Main()
        Dim s As String = "Hello World"
        Dim file As String = "K:\Hello"
        For i As Integer = 1 To 1000
            Using w As New StreamWriter(file & $"{i}.txt")
                w.WriteLine(s)
            End Using

        Next
    End Sub

End Module
