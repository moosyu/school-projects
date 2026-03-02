Module Module1 'iirc this was some example code that was in a textbook we got. feels a bit needlessly complicated but who knows i might just be dumb.
    'stole from sir just seeing how it works
    Sub Main()
        Dim n() As Integer = {3, 4}
        Console.WriteLine("{0} / {1} = {2}", n(0), n(1), Math.Round(n(0) / n(1), 2))
        Threading.Thread.Sleep(30000)
    End Sub

End Module