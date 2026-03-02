Module Module1
' just the game where you guess a number and it tells you if its too high or too low
    Sub Main()
        Dim rand As New Random()
        Dim n, i As Integer
        n = rand.Next(1, 20)
        Console.WriteLine("Guess a number between 1 and 20")
        Dim guesses As Integer = 10
        While Not i = n And guesses > 0
            i = Validate(Console.ReadLine())
            If i > n Then
                Console.WriteLine("too high")
            ElseIf i < n Then
                Console.WriteLine("too low")
            End If
            guesses -= 1
        End While
        Console.WriteLine($"you did it with {guesses + 1} guesses left!")
        Console.ReadLine()
    End Sub

    Function Validate(ByVal s As String) As Double
        Dim i As Integer
        If Not Double.TryParse(s, i) Then Console.Write("invalid!!")
        Return i
    End Function

End Module