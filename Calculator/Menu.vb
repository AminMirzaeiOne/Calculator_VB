Module Menu
    Dim tabIndex As Integer = 0
    Public Sub DrawMenu()
        System.Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine("   ╔═══════════════╗")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ╠               ╣")
        Console.WriteLine("   ║ [Calculator]  ║ Start working directly with the calculator ")
        Console.WriteLine("   ╠               ╣")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ╚═══╩═══╩═══╩═══╝")
        Console.WriteLine()
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("   ╔═══════════════╗")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ╠               ╣")
        Console.WriteLine("   ║   [Settings]  ║ Calculator settings and options ")
        Console.WriteLine("   ╠               ╣")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ╚═══╩═══╩═══╩═══╝")
        Console.WriteLine()
        System.Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("   ╔═══════════════╗")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ╠               ╣")
        Console.WriteLine("   ║ [Appearance]  ║ Calculator user interface and theme ")
        Console.WriteLine("   ╠               ╣")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ╚═══╩═══╩═══╩═══╝")
        Console.WriteLine()
        System.Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("   ╔═══════════════╗")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ╠               ╣")
        Console.WriteLine("   ║ [Information] ║ Information about the calculator programmer ")
        Console.WriteLine("   ╠               ╣")
        Console.WriteLine("   ║               ║")
        Console.WriteLine("   ╚═══╩═══╩═══╩═══╝")
        Console.ResetColor()
        System.Console.SetCursorPosition(90, 3)
        Console.Write("[Select using the (Tab Key)]")
        GetMenuSelected()
    End Sub

    Public Sub GetMenuSelected()
startGet:
        Dim key As System.ConsoleKeyInfo
        key = Console.ReadKey()
        If key.Key = ConsoleKey.Tab Then
            If tabIndex < 4 Then
                tabIndex += 1
            Else
                tabIndex = 0
            End If
            CheckMenuSelectd()
            GoTo startGet
        ElseIf key.Key = ConsoleKey.Enter Then
            Select Case tabIndex
                Case 0
                    System.Console.Clear()
                    Console.SetWindowSize(60, 18)
                    Calculator.CalcBoard.CalSize = CalculatorSize.Medium
                    Draw()
                    GetKey()
                Case 1
                    System.Console.WriteLine("1")
                Case 2
                    System.Console.WriteLine("2")
                Case 3
                    DrawInfo()

            End Select
        End If

    End Sub

    Public Sub CheckMenuSelectd()
        System.Console.SetCursorPosition(90, 4)
        Clear(4, 90)
        Select Case tabIndex
            Case 0
                System.Console.ForegroundColor = ConsoleColor.DarkCyan
                System.Console.Write("Calculator Selected")
            Case 1
                System.Console.ForegroundColor = ConsoleColor.Yellow
                System.Console.Write("Settings Selected")
            Case 2
                System.Console.ForegroundColor = ConsoleColor.Magenta
                System.Console.Write("Appearance Selected")
            Case 3
                System.Console.ForegroundColor = ConsoleColor.Red
                System.Console.Write("Information Selected")
        End Select
        System.Console.ResetColor()
    End Sub



End Module
