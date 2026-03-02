Module Module1 'converts temperature from fahrenheit to celcius. idk why it has way more functions then usual

    Sub Main()
        Dim c, f As Double

        Console.WriteLine("temp? farenheit")
        f = Validate(Console.ReadLine)
        c = GetCelcius(f)
        ShowTemp(c)

        Console.WriteLine("temp celcius?")
        c = Validate(Console.ReadLine)
        f = GetFahrenheit(c)
        ShowTemp(f)

        Console.ReadKey()
    End Sub
    Function GetFahrenheit(ByVal c As Double) As Double
        Return Math.Round((c * 9 / 5) + 32, 1)
    End Function

    Function GetCelcius(ByVal f As Double) As Double
        Return Math.Round((f - 32) * 5 / 9, 1)
    End Function

    Sub ShowTemp(ByVal c As Double)
        If c < 10 Then
            Console.WriteLine($"cold ({c} degrees)")
        ElseIf c > 50 Then
            Console.WriteLine($"hot ({c} degrees)")
        Else
            Console.WriteLine($"just right ({c} degrees)")
        End If

    End Sub

    Function Validate(ByVal s As String) As Double
        Dim d As Double = 0
        If Not Double.TryParse(s, d) Then
            Console.WriteLine("error: not number!!")
        End If
        Return d
    End Function

End Module