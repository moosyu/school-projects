Module Module1 'tells you sausage profits based on random arbitrary numbers that make a linear graph or smthing.

    Sub Main()
        Dim x As Integer
        Const C As Double = -50
        Const M As Double = 1.5
        Console.WriteLine("enter number of sausages sold: ")
        x = Console.ReadLine()
        Dim y As Double = M * x + C
        Console.WriteLine($"you made ${y} profit")
        Console.ReadKey()
    End Sub

End Module
