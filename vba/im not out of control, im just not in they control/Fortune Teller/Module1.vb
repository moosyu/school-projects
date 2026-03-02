Imports System.IO 'the text files are in the folder and you just gotta put them in a file location your pc has and change the inputdata filepath bit 
Module Module1
    Dim rand As New Random()
    Sub Main()
        Dim carrers As List(Of String) = importData("K:\careers.txt")
        Dim location As List(Of String) = importData("K:\cities.txt") 'gonna have to change this to make it work
        Dim house() As String = {"sidewalk", "shack", "appartment", "house", "mansion"}
        Dim marry() As String = {"single", "dating", "married", "Divorced"}
        Console.Write($"Your job will be as a {pickrandom(carrers)}, you will live in a {house(rand.Next(0, house.Length - 1))}, you will be {marry(rand.Next(0, marry.Length - 1))}, your annual income will be {rand.Next(0, 1000000000):C}, you will have {rand.Next(1, 70)} kids, you will live in {pickrandom(location)}.")
        Console.ReadKey()
    End Sub

    Function pickrandom(ByVal sList As List(Of String)) As String
        Return sList(rand.Next(0, sList.Count - 1))
    End Function

    Function importData(ByVal filePath As String) As List(Of String)
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

End Module