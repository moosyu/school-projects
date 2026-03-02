Option Compare Text 'makes comparing lower and upper case work
'this code just gives you a random(ish) animal name. to make this work youve gotta change the file location of animals.txt and where output.txt goes (idk if output.txt even does anything though so it probably would work fine without it)
Imports System.IO

Module Module1
    Const FILE_OUT As String = "K:\output.txt"
    Const QUESTIONS As Integer = 10
    Sub Main()
        Const PAUSE_SEC As Integer = 3
        Dim rand As New Random()
        Dim animalList As New List(Of String)
        Dim f As String = "K:\animals.txt"
        Dim animal As String
        Dim answer, guess As String
        Dim score As Integer = 0
        Using r As New StreamReader(f)
            Do
                animal = r.ReadLine()
                If animal <> "" Then
                    animalList.Add(animal)
                End If
            Loop Until animal Is Nothing
        End Using
        'For Each animal In animalList 'animal not same as other animal
        '    Console.Write($"|{animal}")
        'Next
        For n = 1 To QUESTIONS
            answer = animalList(rand.Next(0, animalList.Count))
            Output($"{answer}", PAUSE_SEC * 1000)
            Console.Clear()
            Console.WriteLine("What was that animal?")
            guess = Console.ReadLine()
            If guess = answer Then
                score += 1
                Output($"Correct!! score is now {score}", PAUSE_SEC * 1000)
            Else
                score -= 1
                Output($"WRONG❗❗❗ the correct answer was {answer} you wrote {guess}. score is now {score}", PAUSE_SEC * 1000)
            End If
        Next
        Using w As New StreamWriter(FILE_OUT, True)
            w.WriteLine($"{score}")
        End Using
        Console.ReadLine()
    End Sub

    Sub Output(ByVal s As String, ByVal pause As Integer) 'very cool that outputs not reserved
        Console.Write(s)
        Threading.Thread.Sleep(pause)
        Console.Clear()
    End Sub
End Module

'just prints the file
'Dim animalList As New List(Of String)
'Dim f As String = "K:\animals.txt"
'Dim animal As String
'Using r As New StreamReader(f)
'    animal = r.ReadLine()
'    Console.WriteLine(animal)
'    While animal IsNot Nothing
'        animal = r.ReadLine()
'        Console.WriteLine(animal)
'    End While
'End Using