Module Module1 'every 3rd letter is a fizz, every 5th is a buzz, every 15th is a fizzbuzz. big stuff going on here.
    Sub Main()
        For n As Double = 1 To 100
            If Math.Floor(n / 3) = Math.Ceiling(n / 3) And Math.Floor(n / 5) = Math.Ceiling(n / 5) Then
                Console.Write("Fizzbuzz, ")
            ElseIf Math.Floor(n / 3) = Math.Ceiling(n / 3) Then
                Console.Write("Fizz, ")
            ElseIf Math.Floor(n / 5) = Math.Ceiling(n / 5) Then
                Console.Write("Buzz, ")
            Else
                Console.Write($"{n}, ")
            End If
        Next
        Console.ReadLine()
    End Sub
End Module