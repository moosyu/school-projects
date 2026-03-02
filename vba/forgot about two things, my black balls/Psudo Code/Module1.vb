Module Module1
'pretty sure this was meant to build a triange out of stars, couldnt figure it out in time though :(
    Sub Main()
        '6
        Shell("CommonVideo")
        Dim NoOfStars As Integer
        Const SIZE As Integer = 50
        For Line = 1 To SIZE
            Dim NoOfSpaces As Integer = SIZE - Line
            For Counter = 1 To NoOfSpaces
                Console.Write(" ")
            Next
            NoOfStars = Line * 2 - 1
            For Counter = 1 To NoOfStars
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module

'1
'Dim Name As String = Console.ReadLine()
'Console.WriteLine($"Hello {Name}")

'2
'Dim Num1 As Integer = Console.ReadLine()
'Dim Num2 As Integer = Console.ReadLine()
'Dim Product As Integer = Num1 * Num2
'Console.WriteLine(Product)

'3
'Dim Age As Integer = Console.ReadLine()
'If Age > 12 And Age < 20 Then
'    Console.WriteLine("You are a teenager")
'Else
'    Console.WriteLine("You are not a teenager")
'End If

'4
'For Counter = 1 To 10
'    Console.Write("*")
'Next

'5
'Dim NoOfStars
'Const SIZE As Integer = 4
'For Line = 1 To SIZE
'    NoOfStars = Line * 2 - 1
'    For Counter = 1 To NoOfStars
'        Console.Write(“*”)
'    Next
'    Console.WriteLine()
'Next