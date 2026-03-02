Module Module1 ' another shot at the pyramid thing and another miss. makes more of a flipped inverted half pyramid.

    Sub Main()

        Dim n, l As Double
        Console.WriteLine("enter length")
        n = Console.ReadLine()
        l = 1
        For i = 1 To n * n
            l += 1
            If l = n Then
                Console.WriteLine("*")
                l = 1
                n = n - 1
            Else
                Console.Write("-")
            End If
        Next
        Console.ReadKey()

    End Sub

End Module
