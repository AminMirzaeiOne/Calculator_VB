Module Module1
    Private equal As Boolean = False
    Enum Keys
        None
        zero
        one
        two
        three
        four
        five
        six
        seven
        eight
        nine
        plus
        mines
        multiplication
        division
        Clear
        ClearE
        Backspace
    End Enum
    Dim Key As Calculator.Keys = Keys.None
    Sub Main()
        Draw()
        GetKey()
        Console.ReadKey()
    End Sub

    Sub GetKey()
        While equal = False
            Dim keyInfo As ConsoleKeyInfo = Console.ReadKey()
            Select Case keyInfo.Key
                Case ConsoleKey.D0
                    Console.SetCursorPosition(9, 13)
                    Key = Keys.zero
                Case ConsoleKey.D1
                    Console.SetCursorPosition(5, 11)
                    Key = Keys.one
                Case ConsoleKey.D2
                    Console.SetCursorPosition(9, 11)
                    Key = Keys.two
                Case ConsoleKey.D3
                    Console.SetCursorPosition(13, 11)
                    Key = Keys.three
                Case ConsoleKey.D4
                    Console.SetCursorPosition(5, 9)
                    Key = Keys.four
                Case ConsoleKey.D5
                    Console.SetCursorPosition(9, 9)
                    Key = Keys.five
                Case ConsoleKey.D6
                    Console.SetCursorPosition(13, 9)
                    Key = Keys.six
                Case ConsoleKey.D7
                    Console.SetCursorPosition(5, 7)
                    Key = Keys.seven
                Case ConsoleKey.D8
                    Console.SetCursorPosition(9, 7)
                    Key = Keys.eight
                Case ConsoleKey.D9
                    Console.SetCursorPosition(13, 7)
                    Key = Keys.nine
                Case Else
                    Exit While
            End Select
        End While
    End Sub

End Module
