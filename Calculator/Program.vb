Module Program
    Private equal As Boolean = False
    Dim keyInfo As ConsoleKeyInfo
    Public equalNumber As Double = 0
    Public OneNumber As Double = 0
    Public TwoNumber As Double = 0
    Public cursor As Byte = 5

    Sub Main()
        Console.WriteLine("Microsoft android ios windows phone")
        Dim x As Char = Calculator.ReadCharacterAt.ReadCharacterAt(3, 0)
        Console.WriteLine(x.ToString())
        'Console.SetWindowSize(60, 18)
        'Calculator.CalcBoard.CalSize = CalculatorSize.Medium
        'Draw()
        'GetKey()
        Console.ReadKey()
    End Sub

    Sub GetKey()
        While equal = False
            Console.SetCursorPosition(cursor, 3)
            cursor = cursor + 1
            keyInfo = Console.ReadKey()
            If keyInfo.Key >= ConsoleKey.D0 AndAlso keyInfo.Key <= ConsoleKey.D9 Or keyInfo.Key = ConsoleKey.Backspace Or keyInfo.Key = ConsoleKey.Delete Then
                Select Case keyInfo.Key
                    Case ConsoleKey.Delete
                        Clear()
                    Case ConsoleKey.Backspace
                        Backspace()
                    Case ConsoleKey.OemPlus
                        Console.SetCursorPosition(9, 11)
                    Case ConsoleKey.OemMinus
                        Console.SetCursorPosition(13, 11)
                    Case ConsoleKey.Multiply
                        Console.SetCursorPosition(5, 9)
                    Case ConsoleKey.Divide
                        Console.SetCursorPosition(9, 9)
                    Case ConsoleKey.Enter
                End Select
            Else
                Clear()
            End If

        End While
    End Sub





End Module
