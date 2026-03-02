Module Module1 'just a while loop? closes after you enter a number smaller then 1 or bigger then 100

    Sub Main()
        Dim n As Integer = 1
        While n >= 1 And n <= 100
            Console.Write("enter number ")
            n = Console.ReadLine()
        End While
        Console.WriteLine("end")
        Console.ReadLine()
    End Sub

End Module
