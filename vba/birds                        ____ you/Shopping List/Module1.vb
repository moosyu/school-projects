'prints two lines of random numbers forever (unless 0 stops being 0 i guess)
'eg 3.16178607940674                                       3.03405964374542                                       
Module Module1

    Sub Main()
        Dim slist As New List(Of String)
        While 0 = 0
            Dim rand As Double = ((6 * Rnd()) + 1)
            Console.Write(rand)
            Console.Write("                                       ")
            Console.WriteLine(rand)
        End While

        Console.ReadKey()
    End Sub

End Module
