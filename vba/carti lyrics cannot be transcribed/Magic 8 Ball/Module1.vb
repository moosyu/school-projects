'gives you a random answer to a question you ask. also have a cool typing out effect i like a lot.
Module Module1
    Dim r As New Random()
    Sub Main()
        Dim answers() As String = {"Your day is munted", "Yeah nah", "Chur", "", "You may rely on it", "As I see it, yes", "Most likely"}
        Type("What is your question? ")
        Console.ReadLine()
        Type($"{answers(r.Next(0, answers.Length))}")
        Console.ReadKey()
    End Sub

    Sub Type(ByVal s As String)
        Dim charArr() As Char = s.ToCharArray
        For Each c In charArr
            Console.Write(c)
            Threading.Thread.Sleep(r.Next(20, 200))
        Next
    End Sub

End Module
