Module Module1
'looks like its finding perfect squares. sadly it doesnt work (at least in the shitty online compiler im using rn) 
    Sub Main()
        Console.WriteLine("enter number")
        Dim x As Integer = Console.ReadLine
        If x = Int(x) Then
            Console.WriteLine("perfect")
        Else
            Console.WriteLine("not perfect")
        End If
        Console.ReadLine()
    End Sub

End Module
