Module CalcBoard
    Enum CalculatorSize
        Small
        Medium
        Large
    End Enum
    Private size As Calculator.CalcBoard.CalculatorSize = CalculatorSize.Small
    Public Property CalSize As Calculator.CalcBoard.CalculatorSize
        Get
            Return size
        End Get
        Set(value As Calculator.CalcBoard.CalculatorSize)
            size = value
            Select Case value
                Case CalculatorSize.Small
                    Calculator.ConsoleHelper.SetCurrentFont("Consolas", 15)
                Case CalculatorSize.Medium
                    Calculator.ConsoleHelper.SetCurrentFont("Consolas", 20)
                Case CalculatorSize.Large
                    Calculator.ConsoleHelper.SetCurrentFont("Consolas", 30)
            End Select
        End Set
    End Property

    Public Sub Draw()
        Console.WriteLine("   ╔═══════════════╗")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ║═══════════════║")
        Console.WriteLine("   ║ 0             ║")
        Console.WriteLine("   ║═══════════════║")
        Console.WriteLine("   ║  C  CE  <  =  ║")
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



End Module
