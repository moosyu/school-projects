Imports System.IO 'i never figured out why this one broke sometimes. pretty sure it was something to do with visual studio not vb but i might have also been stupid. another one where youll need to change the file path if you want it to work without a k drive
Module Module1
    'doesnt work for some reason :despair:
    'except sometimes when it works idk
    Sub Main()
        Dim FilePath As String = "K:\Shopping_List.txt"
        Dim ShoppingList As New List(Of String)
        Dim items As String = "."

        Console.WriteLine("Add item to the shopping list!! (Write blank to end list)")
        While items <> ""
            items = Console.ReadLine
            ShoppingList.Add(items)
        End While

        Try
            'breaks the code sometimes idk bc the file gets automatically made (great design guys)

            'If Not File.Exists(FilePath) Then
            '    File.Create(FilePath)
            'End Ifw

            'Threading.Thread.Sleep(3000) did not solve my problem [😔(pensive)]
            Using w As StreamWriter = New StreamWriter(FilePath)
                For Each item In ShoppingList
                    w.WriteLine(item)
                Next
            End Using
            Console.Write($"Your data has been saved at {FilePath}")
        Catch ex As Exception
            Console.WriteLine($"error {ex}")
        End Try
        Console.ReadLine()
    End Sub

End Module