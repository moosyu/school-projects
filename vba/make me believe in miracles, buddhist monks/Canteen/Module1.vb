Module Module1'clearly past me wasnt very happy with this one. not 100% sure if this works but you never know.
    'some of the worst code ever written
    Dim percentage As Double
    Sub Main()
        Dim price, costPrice As Double
        Console.WriteLine("how much did you spend")
        costPrice = Console.ReadLine()
        Console.WriteLine(price)
        Console.WriteLine($"you have to pay ${Math.Round(costPrice * percentage, 2)} which is {15}% off")
        Console.ReadKey()

    End Sub

    Function Discount(ByVal costPrice As Double)
        If costPrice >= 10 Then
            percentage = 0.85
        ElseIf costPrice > 7 Then
            percentage = 0.9
        ElseIf costPrice >= 5 Then
            percentage = 0.95
        Else
            percentage = 0
        End If
        Return percentage
    End Function

End Module