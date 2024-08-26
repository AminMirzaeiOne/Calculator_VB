Module Program
    Private equal As Boolean = False
    Dim keyInfo As ConsoleKeyInfo
    Public equalNumber As Double = 0
    Public OneNumber As Double = 0
    Public TwoNumber As Double = 0
    Public cursor As Byte = 5

    Sub Main()
        DrawMenu()
        Console.ReadKey()
    End Sub

    Sub GetKey()
        While equal = False
            Console.SetCursorPosition(cursor, 3)
            cursor = cursor + 1
            keyInfo = Console.ReadKey()
            If keyInfo.Key >= ConsoleKey.D0 AndAlso keyInfo.Key <= ConsoleKey.D9 Or keyInfo.Key = ConsoleKey.Backspace Or keyInfo.Key = ConsoleKey.Delete Or keyInfo.Key = ConsoleKey.A Then
                Select Case keyInfo.Key
                    Case ConsoleKey.Delete
                        Clear()
                    Case ConsoleKey.Backspace
                        Backspace()
                    Case ConsoleKey.A
                        Operations.Plus()
                    Case ConsoleKey.OemMinus

                    Case ConsoleKey.Multiply

                    Case ConsoleKey.Divide

                    Case ConsoleKey.Enter
                End Select
            Else
                Clear()
            End If

        End While
    End Sub





End Module
