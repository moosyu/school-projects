Module Module1 'just another calcuator thingy. used to figure out how functions work ig.

    Sub Main()
        Console.WriteLine(Add(Validate(3), Validate("r")))
        Console.ReadKey()
    End Sub

    Function Add(ByVal n1 As Integer, ByVal n2 As Integer) As Integer

        Return n1 + n2
    End Function
    Function Multiply(ByVal n1 As Integer, ByVal n2 As Integer) As Integer

        Return n1 * n2
    End Function
    Function Validate(ByVal s As String)
        Dim i As Integer = 0
        If Not Integer.TryParse(s, i) Then
            Console.WriteLine($"{s} is not a number")
        End If
        Return i
    End Function
End Module
