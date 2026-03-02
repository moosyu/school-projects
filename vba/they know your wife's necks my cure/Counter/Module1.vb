Module Module1 'counts up with spaces in between and uses sleep instead of readline for some reason
    Sub Main()
        For c = 1 To 10
            Console.Write(" " & c)
        Next
        Threading.Thread.Sleep(3000)
    End Sub
End Module