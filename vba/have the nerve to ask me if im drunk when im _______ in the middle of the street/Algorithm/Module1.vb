Module Module1
'algorithm that orders the numbers in the array. i definitely didnt make the algorithm up myself though.
    Sub Main()
        Dim arr As Integer() = {9, 3, 8, 5, 2, 4, 7, 6, 1, 2016}
        Dim j, i As Integer

        While j < arr.Length - 1
            i = 0
            While i < arr.Length - 1
                If arr(i) > arr(i + 1) Then
                    Dim temp = arr(i + 1)
                    arr(i + 1) = arr(i)
                    arr(i) = temp
                End If
                i += 1
            End While
            j += 1
        End While
        i = 0
        While i < arr.Length
            Console.WriteLine(arr(i))
            i += 1
        End While

        Console.ReadLine()
    End Sub

End Module
