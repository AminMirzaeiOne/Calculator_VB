Imports Calculator.ConsoleExtender

Module CalcBoard
    Enum CalculatorSize
        Small
        Medium
        Large
    End Enum
    Public Property Size As Calculator.CalcBoard.CalculatorSize = CalculatorSize.Small
    Public Sub Draw()
        Select Case Size
            Case CalculatorSize.Small
                DrawSmall()
            Case CalculatorSize.Medium
                DrawMedium()
            Case CalculatorSize.Large
                DrawLarge()
        End Select
    End Sub

    Private Sub DrawSmall()
        ConsoleHelper.SetCurrentFont("Consolas", 40)
        Console.WriteLine("   ╔═══════════════╗")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ║═══════════════║")
        Console.WriteLine("   ║ 0             ║")
        Console.WriteLine("   ║═══════════════║")
        Console.WriteLine("   ║  C    CE    < ║")
        Console.WriteLine("   ║═══╦═══╦═══╦═══║")
        Console.WriteLine("   ║ 7 ║ 8 ║ 9 ║ / ║")
        Console.WriteLine("   ╠═══╬═══╬═══╬═══╣")
        Console.WriteLine("   ║ 4 ║ 5 ║ 6 ║ x ║")
        Console.WriteLine("   ╠═══╬═══╬═══╬═══╣")
        Console.WriteLine("   ║ 1 ║ 2 ║ 3 ║ - ║")
        Console.WriteLine("   ╠═══╬═══╬═══╬═══╣")
        Console.WriteLine("   ║ ¬ ║ 0 ║ . ║ + ║")
        Console.WriteLine("   ╚═══╩═══╩═══╩═══╝")
        Console.WriteLine()
    End Sub

    Private Sub DrawMedium()

    End Sub

    Private Sub DrawLarge()

    End Sub
End Module
