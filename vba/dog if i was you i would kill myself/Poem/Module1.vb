Module Module1 'this is what i was meant to make but doesnt make any sense 
    'A sailer went to knee, knee, knee
    'To see what he could knee, knee, knee
    ' yeah ok man

    Sub Main()
        Dim words() As String = {"sea", "knee", "toe"}
        For Each se In words
            Verse(se, 3000)
        Next
        Console.ReadLine()
    End Sub
    Sub Verse(ByVal se As String, ByVal length As Integer)
        Console.WriteLine($"A sailer went to {se}, {se}, {se}")
        Threading.Thread.Sleep(length)
        Console.WriteLine($"To see what he could {se}, {se}, {se}")
        Threading.Thread.Sleep(length)
        Console.WriteLine($"But all that he could {se}, {se}, {se}")
        Threading.Thread.Sleep(length)
        Console.WriteLine($"Was the bottom of the deep blue, {se}, {se}, {se}" & vbNewLine)
        Threading.Thread.Sleep(length)
    End Sub
End Module
