Module Module1
    Private equal As Boolean = False
    Dim keyInfo As ConsoleKeyInfo
    Sub Main()
        Console.SetWindowSize(60, 18)
        Draw()
        GetKey()
        Console.ReadKey()
    End Sub

    Sub GetKey()
        Dim x As Byte = 5
        While equal = False
            Console.SetCursorPosition(x, 3)
            x = x + 1
            keyInfo = Console.ReadKey()
            Select Case keyInfo.Key
                Case ConsoleKey.Delete
                    Clear()
                Case ConsoleKey.Backspace
                    Console.SetCursorPosition(9, 13)
                Case ConsoleKey.OemPlus
                    Console.SetCursorPosition(9, 11)
                Case ConsoleKey.OemMinus
                    Console.SetCursorPosition(13, 11)
                Case ConsoleKey.Multiply
                    Console.SetCursorPosition(5, 9)
                Case ConsoleKey.Divide
                    Console.SetCursorPosition(9, 9)
                Case ConsoleKey.Enter

                Case Else
                    Exit While
            End Select
        End While
    End Sub





End Module
