Module Module1 'this works fine, just checks if a number is between 0 and 40

    Sub Main()
        Dim n As Integer
        Const MIN As Integer = 0
        Const MAX As Integer = 40
        Console.Write("enter a valid number!! ")
        While Not Integer.TryParse(Console.ReadLine(), n) Or n < MIN Or n > MAX
            Console.Write($"enter valid number between {MIN} and {MAX}: ")
        End While
        Console.WriteLine("your valid number was " & n)
        Console.ReadKey()
    End Sub

End Module

'Console.WriteLine("enter a number: ")
'If Integer.TryParse(Console.ReadLine(), n) Then
'    Console.Write("your number is " & n & " and it is ")
'    If n < 0 Or n > 100 Then
'        Console.Write("out of range")
'    Else
'        Console.Write("in range")
'    End If
'Else
'    Console.WriteLine("input error!! you have to enter a number!!")
'End If
'Console.ReadKey() ' pause