Imports System.IO
Module Module1
    Sub Main()
        'minutes away from running out of time so i'll just leave this here instead of fixing it -> if you put spaces in the responses.txt file it just doesnt pick it up.
        'its because of how text is split (eg: if you write "i play table tennis" it becomes ->
        'i -> (cant be found)
        'play -> (cant be found)
        'table -> (cant be found)
        'tennis -> (found in response.txt)
        'idk how i could fix this while having the same text checking operation going on short of asking people to but dashes in between words which would be insane
        'to run this you need to put the text files (questions.txt and responses.txt) in the same folder as the exe file
        Dim responseOptions As List(Of String) = ImportData("responses.txt")
        Dim questions As List(Of String) = ImportData("questions.txt")
        Dim forever As Boolean = True
        Dim counting As Integer = 0
        Dim splitSports As New List(Of String())
        Console.WriteLine("what is your name?")
        Dim name As String = Console.ReadLine()

        While forever = True

            If counting <= questions.Count - 1 Then
                Console.WriteLine($"{questions(counting)} {name}?")
            Else
                Console.WriteLine("thank you for chatting with me!!")
                forever = False
            End If

            Dim input As String = Console.ReadLine
            Dim linput As String = input.ToLower

            Dim sent = RunThrough("responses.txt", linput)
            QAndA(linput, sent)

            counting += 1

        End While
    End Sub

    Function ImportData(ByVal filePath As String) As List(Of String)
        Dim sList As New List(Of String)
        Using sr As New StreamReader(filePath)
            Dim line As String = sr.ReadLine
            While line IsNot Nothing
                sList.Add(line)
                line = sr.ReadLine()
            End While
            Return sList
        End Using
    End Function

    Sub QAndA(ByVal linput As String, ByVal sent As Boolean)
        If sent = False Then
            If linput.Contains("you") And linput.Contains("Like") Or linput.Contains("dislike") Then
                Console.WriteLine("I am a cold unfeeling machine, i don't like or dislike anything.")
            Else
                Console.WriteLine("thats interesting")
            End If
        End If
    End Sub

    Function RunThrough(ByVal importing As String, ByVal linput As String)
        Dim sent As Boolean = False
        Dim responseOptions As List(Of String) = ImportData(importing)
        Dim locationArr As Integer
        Dim temp As New List(Of String)

        If linput.Trim IsNot "" Then
            For x = 0 To responseOptions.Count - 1
                Dim splitted As String = Split(responseOptions(x), "-")(0)
                Dim inputsplitted() As String = linput.Split(" ")
                'Console.WriteLine(splitted.Trim)
                For y = 0 To inputsplitted.Length - 1
                    If RTrim(splitted) = inputsplitted(y) Then
                        locationArr = x
                        sent = True
                        If importing = "responses.txt" And locationArr > -1 Then
                            Console.WriteLine(responseOptions(locationArr).Replace("-", " "))
                        End If
                    End If
                Next
            Next
        Else
            sent = True
        End If
        Return sent
    End Function
End Module