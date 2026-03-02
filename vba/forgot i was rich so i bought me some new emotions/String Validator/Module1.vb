Module Module1
'on a pc that doesnt have vba.net on it now writing this but it looks to be code that removes anything that isnt a letter in the writeline??
    Sub Main()
        Console.WriteLine(Validate("357t14iij5u3i6tfqwpd892nv26471750vm14814m-90836m9v-578257 01 4141n5n715- 8vn815n1-5v790pjiofkalndad89 75n1-47-"))
        Console.ReadKey()
    End Sub
    Function Validate(ByVal input As String) As String
        Dim output As String = ""
        Dim letters() As Char = input.ToCharArray
        For Each letter In letters
            If Char.IsLetter(letter) Then
                output += letter
            End If
        Next
        Return output
    End Function
End Module
