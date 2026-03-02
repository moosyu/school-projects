Module Module1 'this was meant to be a discount calculator but seems to be kind of overusing if and elseif

    Sub Main()
        Dim costPrice As Integer = Console.ReadLine()
        Dim discount As Double
        If costPrice >= 10 Then
            discount = 0.15
        ElseIf costPrice > 7 Then
            discount = 0.1
        ElseIf costPrice >= 5 Then
            discount = 0.05
        Else
            discount = 0
        End If
        Console.WriteLine($"Your discount is {discount * 100}%. Your cost is {costPrice * (1 - discount)}")
        Console.ReadLine()
    End Sub

End Module
