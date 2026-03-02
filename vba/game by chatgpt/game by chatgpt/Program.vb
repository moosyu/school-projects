'massive epilepsy warning, if you have epilepsy youll probably die if you play this
'this game was almost fully made by chatgpt, putting it online because hopefully i cna do my part in chatgpt being poisioned by itself !!

Module AdventureGame
    ' Define the size of the map
    Const MAP_WIDTH As Integer = 10
    Const MAP_HEIGHT As Integer = 10

    ' Define map symbols
    Const PLAYER_SYMBOL As Char = "☺"c
    Const EMPTY_SYMBOL As Char = "."c
    Const TREASURE_SYMBOL As Char = "♦"c

    ' Define colors
    Const PLAYER_COLOR As ConsoleColor = ConsoleColor.Green
    Const TREASURE_COLOR As ConsoleColor = ConsoleColor.Yellow
    Const EMPTY_COLOR As ConsoleColor = ConsoleColor.Gray

    ' Player position
    Dim playerX As Integer = 0
    Dim playerY As Integer = 0

    ' Treasure position
    Dim treasureX As Integer
    Dim treasureY As Integer

    ' Game map
    Dim gameMap(MAP_WIDTH - 1, MAP_HEIGHT - 1) As Char

    ' Player score
    Dim score As Integer = 0

    ' Time limit in seconds
    Const TIME_LIMIT As Integer = 7
    Dim startTime As DateTime

    Sub Main()
        Do
            InitializeGame()
            GameLoop()
        Loop While AskToRestart()
    End Sub

    ' Initialize game settings
    Sub InitializeGame()
        Dim rand As New Random()

        ' Initialize the map with empty symbols
        For x As Integer = 0 To MAP_WIDTH - 1
            For y As Integer = 0 To MAP_HEIGHT - 1
                gameMap(x, y) = EMPTY_SYMBOL
            Next
        Next

        ' Place player at starting position
        playerX = rand.Next(0, MAP_WIDTH)
        playerY = rand.Next(0, MAP_HEIGHT)
        gameMap(playerX, playerY) = PLAYER_SYMBOL

        ' Place the first treasure at a random position
        PlaceNewTreasure()

        ' Set the start time
        startTime = DateTime.Now
        score = 0 ' Reset score
    End Sub

    ' Main game loop
    Sub GameLoop()
        Dim gameRunning As Boolean = True
        Dim lastUpdate As DateTime = DateTime.Now
        Dim rand As New Random()

        While gameRunning
            ' Check if time has run out or score has reached 5
            Dim elapsedTime As TimeSpan = DateTime.Now - startTime
            If elapsedTime.TotalSeconds >= TIME_LIMIT OrElse score >= 5 Then
                gameRunning = False
            End If

            ' Only update the display if a significant amount of time has passed
            If (DateTime.Now - lastUpdate).TotalMilliseconds >= 100 Then
                ' Set a random background color
                Dim backgroundColors() As ConsoleColor = {ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow}
                Dim randomBackgroundColor As ConsoleColor = backgroundColors(rand.Next(backgroundColors.Length))
                Console.BackgroundColor = randomBackgroundColor

                Console.Clear()
                DrawMap()
                Console.WriteLine($"Score: {score}")
                Console.WriteLine($"Time Remaining: {TIME_LIMIT - CInt(elapsedTime.TotalSeconds)} seconds")
                Console.WriteLine("Use W/A/S/D to move. Q to quit.")
                Console.Write("Enter your move: ")
                lastUpdate = DateTime.Now
            End If

            If Console.KeyAvailable Then
                Dim input As ConsoleKeyInfo = Console.ReadKey(True)

                Select Case input.Key
                    Case ConsoleKey.W
                        MovePlayer(0, -1)
                    Case ConsoleKey.S
                        MovePlayer(0, 1)
                    Case ConsoleKey.A
                        MovePlayer(-1, 0)
                    Case ConsoleKey.D
                        MovePlayer(1, 0)
                    Case ConsoleKey.Q
                        gameRunning = False
                    Case Else
                        Console.WriteLine("Invalid input! Use W/A/S/D to move.")
                End Select
            End If
        End While

        Console.Clear()
        DrawMap()
        Console.ForegroundColor = ConsoleColor.Gray
        Console.BackgroundColor = ConsoleColor.Black ' Reset background color to default
        If score >= 5 Then
            Console.WriteLine("Congratulations! You won with a score of 5!")
        Else
            Console.WriteLine($"Game Over! Your final score is: {score}")
        End If
    End Sub


    ' Method to move the player
    Sub MovePlayer(deltaX As Integer, deltaY As Integer)
        Dim newX As Integer = playerX + deltaX
        Dim newY As Integer = playerY + deltaY

        ' Check boundaries
        If newX >= 0 AndAlso newX < MAP_WIDTH AndAlso newY >= 0 AndAlso newY < MAP_HEIGHT Then
            ' Update map positions
            gameMap(playerX, playerY) = EMPTY_SYMBOL
            playerX = newX
            playerY = newY

            If playerX = treasureX AndAlso playerY = treasureY Then
                ' Player found the treasure
                score += 1
                PlaceNewTreasure()
            End If

            gameMap(playerX, playerY) = PLAYER_SYMBOL
        Else
            Console.WriteLine("You can't move outside the map boundaries!")
            System.Threading.Thread.Sleep(500)
        End If
    End Sub

    ' Method to place a new treasure at a random position
    Sub PlaceNewTreasure()
        Dim rand As New Random()

        ' Place treasure at random position different from player position
        Do
            treasureX = rand.Next(0, MAP_WIDTH)
            treasureY = rand.Next(0, MAP_HEIGHT)
        Loop While treasureX = playerX AndAlso treasureY = playerY
        gameMap(treasureX, treasureY) = TREASURE_SYMBOL
    End Sub

    ' Method to draw the map on console
    Sub DrawMap()
        Dim rand As New Random()

        ' Set a random background color
        Dim backgroundColors() As ConsoleColor = {ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow}
        Dim randomBackgroundColor As ConsoleColor = backgroundColors(rand.Next(backgroundColors.Length))
        Console.BackgroundColor = randomBackgroundColor

        ' Set a random color for EMPTY_SYMBOL
        Dim emptyColors() As ConsoleColor = {ConsoleColor.Gray, ConsoleColor.DarkGray, ConsoleColor.White, ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.Yellow}
        Dim randomEmptyColor As ConsoleColor = emptyColors(rand.Next(emptyColors.Length))

        For y As Integer = 0 To MAP_HEIGHT - 1
            For x As Integer = 0 To MAP_WIDTH - 1
                Select Case gameMap(x, y)
                    Case PLAYER_SYMBOL
                        Console.ForegroundColor = PLAYER_COLOR
                    Case TREASURE_SYMBOL
                        Console.ForegroundColor = TREASURE_COLOR
                    Case EMPTY_SYMBOL
                        Console.ForegroundColor = randomEmptyColor
                End Select
                Console.Write(gameMap(x, y) & " ")
            Next
            Console.WriteLine()
        Next

        ' Reset color to default
        Console.ForegroundColor = ConsoleColor.Gray
        Console.BackgroundColor = ConsoleColor.Black
    End Sub


    ' Method to ask the player if they want to restart the game
    Function AskToRestart() As Boolean
        Console.ReadLine()
        Console.WriteLine("Do you want to play again? (Y/N)")
        Dim input As ConsoleKeyInfo = Console.ReadKey(True)
        Return input.Key = ConsoleKey.Y
    End Function
End Module
