Module Module1
'checks your income and tries to figure out how much tax you gotta pay though. from memory im pretty sure this is unfinished and by looking at it right now im probably right.
    Sub Main()
        Console.WriteLine("What's your income?")
        Dim income As Integer = Console.ReadLine()
        Dim total, i As Double
        While total < 14000 And total < income
            i += 0.105
            total += 1
        End While

        While total <= 48000 And total < income
            i += 0.175
            total += 1
        End While

        While total <= 70000 And total < income
            i += 0.3
            total += 1
        End While

        While total < income And total < income
            i += 0.33
            total += 1
        End While

        Console.WriteLine($"runs = {total} and i= {i}")

        Console.WriteLine($"You have to pay {Math.Round(i, 2)}. Your net income is {income - Math.Round(i, 2)}. Your effective tax rate is {Math.Round((Math.Round(i, 2) / income) * 100, 1)}%")
        Console.ReadKey()
    End Sub

End Module
