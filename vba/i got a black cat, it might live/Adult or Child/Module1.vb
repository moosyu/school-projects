Module Module1
'just using case to tell you your age ig feel like ive done this before, getting some deja vu
    Sub Main()
        Console.WriteLine("whats your age")
        Dim y As Integer = Console.ReadLine()
        Select Case y
            Case 0 To 17
                Console.WriteLine("child")
            Case 18 To 120
                Console.WriteLine("adult")
            Case Else
                Console.WriteLine("out of range")
        End Select
        Console.ReadLine()
    End Sub

End Module
