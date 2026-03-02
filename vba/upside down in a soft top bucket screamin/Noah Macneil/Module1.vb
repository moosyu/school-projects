Module Module1 'pretty sure i was following some vba api tutorial. didnt work.

    Sub Main()

    End Sub


    Sub CallAPI()
        Dim xhr As Object
    Set xhr = CreateObject("MSXML2.XMLHTTP")

    xhr.Open "GET", "https://api.example.com/data", False
    xhr.send

        MsgBox xhr.responseText
End Sub
End Module
