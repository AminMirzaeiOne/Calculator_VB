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
        Console.WriteLine("   ║   [Options]   ║ Calculator settings and options ")
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
        Dim key As ConsoleKeyInfo
        key = Console.ReadKey()
        If key.Key = ConsoleKey.Tab Then
            If tabIndex < 4 Then
                tabIndex += 1
            Else
                tabIndex = 0
            End If
        End If
        CheckMenuSelectd()
        GoTo startGet

    End Sub

    Public Sub CheckMenuSelectd()
        Select Case tabIndex
            Case 0
                System.Console.WriteLine("Cal Selected")
            Case 1
                System.Console.WriteLine("Opt Selected")
            Case 2
                System.Console.WriteLine("Appe Selected")
            Case 3
                System.Console.WriteLine("Info Selected")
            Case Else

        End Select
    End Sub

End Module
