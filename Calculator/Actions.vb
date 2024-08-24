Module Actions
    Public Sub Clear()
        Calculator.Program.OneNumber = 0
        Calculator.Program.TwoNumber = 0
        Calculator.Program.equalNumber = 0
        For index = 5 To cursor
            Calculator.Program.cursor -= 1
            Console.SetCursorPosition(cursor, 3)
            Console.Write(" ")
        Next
        Console.SetCursorPosition(5, 3)
        Console.Write("0")

    End Sub

    Public Sub Backspace()
        If Calculator.Program.cursor > 5 Then
            Calculator.Program.cursor -= 2
            Console.SetCursorPosition(cursor, 3)
            Console.Write(" ")
        Else
            Console.SetCursorPosition(5, 3)
            Console.Write("0")
        End If

    End Sub

End Module
