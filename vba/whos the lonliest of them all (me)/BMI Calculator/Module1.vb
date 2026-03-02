Module Module1 'just a bmi calculator. probably to just use more subroutines and functions.

    Sub Main()
        Console.WriteLine("enter weight in kgs")
        Dim weight = Validate(Console.ReadLine())
        Console.WriteLine("enter height in cm")
        Dim height = Validate(Console.ReadLine())
        Dim bmi As Double = Request(weight, height)
        Console.WriteLine(Math.Round(bmi, 1))

        Output(bmi)
        Console.ReadKey()
    End Sub

    Sub Output(ByVal BMI As Double)
        If BMI > 25 Then
            Console.WriteLine("too heavy!!")
        ElseIf BMI < 18.5 Then
            Console.WriteLine("too light!!")
        Else
            Console.WriteLine("just right")
        End If
    End Sub

    Function Request(ByVal weight, height) As Double
        Return weight / (height / 100) ^ 2
    End Function

    Function Validate(ByVal s As String) As Double
        Dim d As Integer = 0
        If Not Double.TryParse(s, d) Then
            Console.WriteLine("error: not number!!")
        End If
        Return d

    End Function
End Module