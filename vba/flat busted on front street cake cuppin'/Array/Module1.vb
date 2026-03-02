Module Module1 'probably me using vba arrays for the first time (spoiler: they are like other languages' arrays but more annoying)

    Sub Main()
        'Dim sArray(8) As Integer ' size is 9
        'For index = 0 To sArray.Length - 1
        '    sArray(index) = sArray(index) + index
        '    Console.WriteLine(sArray(index) + 1)
        'Next

        Dim animals() As String = {"cat", "dog", "pig", "cow"}

        For Each animal In animals
            Console.WriteLine(animal)
        Next

        Console.ReadKey()
    End Sub

End Module
