Module Module1
    'this code runs through a line one letter at a time. it looks pretty cool (probably doesnt work on some terminals).
    Sub Main()
        Dim noahMacneil As String = Console.ReadLine
        Dim stringChar() As Char = noahMacneil.ToCharArray

        For i = 1 To noahMacneil.Length
            Console.Clear()
            Console.WriteLine("""" & Space(i - 1) & stringChar(i - 1) & Space(noahMacneil.Length - i) & """")
            Threading.Thread.Sleep(100)
        Next

    End Sub

End Module
