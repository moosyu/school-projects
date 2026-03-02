Imports System.IO 'forgot to save the canteen.csv file so youre just gonna have to believe this works
Module Module1
    Const FILE_IN As String = "K:\canteen.csv"
    Sub Main()
        Dim itemIndex As Integer
        Dim itemDesc As New List(Of String)
        Dim itemCost As New List(Of Double)
        Dim itemQty As New List(Of Integer)
        Using r As New StreamReader(FILE_IN)
            Dim line As String = r.ReadLine()
            Dim sArr() As String
            While line IsNot Nothing
                sArr = line.Split(",")
                If sArr.Length = 2 Then
                    itemDesc.Add(sArr(0))
                    itemCost.Add(sArr(1))
                    itemQty.Add(0)
                End If
                line = r.ReadLine()
            End While
        End Using
        While itemIndex <> -1
            For index = 0 To itemDesc.Count - 1
                Console.WriteLine($"[{index + 1}] {itemDesc(index)} = {itemCost(index):C} x {itemQty(index)}")
            Next
            Console.WriteLine("Which (item no) would you like to order: ")
            itemIndex = Console.ReadLine()
            If itemIndex >= 1 And itemIndex <= itemDesc.Count Then
                itemQty(itemIndex - 1) += 1
            Else
                Console.WriteLine("do it agian!!")
            End If
        End While

        Console.ReadKey()
    End Sub

End Module