Module Module1 'you see number, you write it down. if you get correct you get a point. tricky stuff. i feel like i did this somewhere else with animals
    Const total As Integer = 10
    Sub Main()
        Dim rand As New Random()
        Dim ans As Integer
        Dim x As Integer
        Dim score As Integer
        Dim numbers As New List(Of Integer)
        For y As Integer = 1 To total
            ans = rand.Next(1, 10000)
            Console.WriteLine(ans)
            Threading.Thread.Sleep(1000)
            Console.Clear()
            x = Console.ReadLine()
            numbers.Add(ans)
            If x = ans Then
                Console.WriteLine("yes")
                score += 1
            Else
                Console.WriteLine("no")
            End If
            Threading.Thread.Sleep(2000)
            Console.Clear()
        Next
        ShowScore(score, numbers)
        Console.ReadKey()
    End Sub

    Sub ShowScore(ByVal score As Integer, ByVal correct As List(Of Integer))
        Console.WriteLine($"You got {score} out of {total}")
        Console.WriteLine("The list of correct answers was:")
        For i As Integer = 0 To (total - 1)
            Console.Write($"{correct(i)} ")
        Next

    End Sub


    ' forgot how to do this whoops
    'Function Errors(ByVal s As String) As Double 
    '    Dim i As Double = 0
    '    If Not Double.TryParse(s, i) Then
    '        Console.WriteLine("test")
    '    Else
    '        Return i
    '    End If
    'End Function


End Module