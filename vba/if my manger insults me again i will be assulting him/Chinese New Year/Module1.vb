Module Module1 'just tells you your like chinese animal thing based on your birth year. i was trying to make this as small as possible so thats why its so small. you have to set it to pause on the last line on vs if you want to see your animal. 
    Sub Main()
        Console.WriteLine($"You are a {"Monkey,Rooster,Dog,Pig,Rat,Ox,Tiger,Rabbit,Dragon,Snake,Horse,Goat".Split(",")(Console.ReadLine() Mod 12)}.")
    End Sub
End Module