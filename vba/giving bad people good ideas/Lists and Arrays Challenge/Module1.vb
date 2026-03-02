Module Module1
'calculator program that only doesn addition i guess
    Sub Main()
        Dim x As Integer
        Dim sum As Integer = 1
        Dim iList As New List(Of Integer)
        While sum <> 0
            x = GetNumber(s:="num 1") ' enter first nubmer
            sum = x + GetNumber(s:="num 2") 'sum is num 1 + num 2
            iList.Add(sum) ' adding the sum to the list
        End While

        For Each i In iList
            Console.WriteLine(i)
        Next
        Console.ReadKey() 'end

    End Sub
    Function GetNumber(ByVal s As String) As Integer
        Dim i As Integer = i
        Console.WriteLine(s)
        While Not Integer.TryParse(Console.ReadLine(), i)
            Console.WriteLine("enter number")
        End While
        Return i
    End Function

End Module