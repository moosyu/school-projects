Module Module1

    Sub Main() ' this code is bad and doesnt work. ran out of time
        Dim negTot, letIndent, counter As Integer
        Dim negTotA, negTotB, negTotC, negTotD, negTotE, negTotF As List(Of Integer)

        Dim negTots As Array = {negTotA, negTotB, negTotC, negTotD, negTotE, negTotF}
        Dim BusA As Array = {0, 0, 0, 2, 2, 4, 0, 3, 4, -2, -5, 0, 0, 3, 4, -1, 8, 1, 1, -2}
        Dim BusB As Array = {0, 1, 0, 0, 1, 2, 0, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 1, 0, 0}
        Dim BusC As Array = {2, 0, -1, -1, -2, -2, -3, -1, 0, 0, -2, 0, 1, 1, 1, 1, -1, -1, 2, -2}
        Dim letters As Array = {BusA, BusB, BusC}
        Dim x = BusA.Length * letters.Length + 1
        Dim BusCount = letters(letIndent)
        If counter < x Then
            For i = 1 To BusA.Length
                If letters(letIndent) Then
                    negTotA.Add(letters(BusCount(i)))
                    negTot += 1
                End If
                counter += 1
            Next
            letIndent += 1
        End If
        Console.WriteLine(negTotA)

    End Sub

End Module
