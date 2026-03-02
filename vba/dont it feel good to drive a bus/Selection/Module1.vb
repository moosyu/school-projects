'say hey kid say hey kid say hey kid HEY KID! (come play dead)
'incredible stuff with this one. i think this was just to figure out how case works??
Module Module1

    Sub Main()
        Console.Write("enter your year!! ")
        Dim year As Integer = Console.ReadLine()

        Select Case year
            Case 0 To 6
                Console.WriteLine("your child is dumb, and stupid!!")
            Case 7 To 8
                Console.WriteLine("your child is the reason soap has instructions!!")
            Case 9 To 13
                Console.WriteLine("your child will be crushed by the pressure of an impending adulthood!!")
            Case Else
                Console.WriteLine("your child is capible of building a miniature trampoline!!")
        End Select

        Console.ReadLine() 'pause!!
    End Sub

End Module