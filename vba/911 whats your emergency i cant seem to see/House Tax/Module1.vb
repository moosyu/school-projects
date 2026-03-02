Module Module1
    ' this could break at any moment but i saved two lines so its worth it
    Sub Main()
        Console.WriteLine("enter how much your house is worth")
        Dim price As Double = Console.ReadLine()
        Dim tax As Double = 1.5
        If price > 1000000 Then
            tax = 2
        ElseIf price > 500000 And price < 1000000 Then
            tax = Math.Round(price / 500000, 1)
        End If
        Console.WriteLine($"you have to pay {price * tax / 100} at {tax}% tax")
        Console.ReadKey()
    End Sub
End Module