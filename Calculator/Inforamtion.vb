Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices

Module Inforamtion
    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Function GetConsoleWindow() As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Function CreateFile(lpFileName As String, dwDesiredAccess As Integer, dwShareMode As Integer, lpSecurityAttributes As IntPtr, dwCreationDisposition As Integer, dwFlagsAndAttributes As Integer, hTemplateFile As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Function GetCurrentConsoleFont(hConsoleOutput As IntPtr, bMaximumWindow As Boolean,
        <Out>
        <MarshalAs(UnmanagedType.LPStruct)> lpConsoleCurrentFont As ConsoleFontInfo) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)>
    Friend Class ConsoleFontInfo
        Friend nFont As Integer
        Friend dwFontSize As Coord
    End Class

    <StructLayout(LayoutKind.Explicit)>
    Friend Structure Coord
        <FieldOffset(0)>
        Friend X As Short
        <FieldOffset(2)>
        Friend Y As Short
    End Structure

    Private Const GENERIC_READ As Integer = &H8000000UI
    Private Const GENERIC_WRITE As Integer = &H40000000
    Private Const FILE_SHARE_READ As Integer = 1
    Private Const FILE_SHARE_WRITE As Integer = 2
    Private Const INVALID_HANDLE_VALUE As Integer = -1
    Private Const OPEN_EXISTING As Integer = 3

    Public Sub DrawInfo()
        Console.Clear()
        System.Console.ForegroundColor = ConsoleColor.DarkCyan
        Console.WriteLine("   ╔═══════════════════════════════════╗")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ║     Programmer : Amin Mirzaei     ║ Amin Mirzaei, programmer and developer of this software project ")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ╚═══════════════════════════════════╝")
        System.Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("   --------------------------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("   ╔═══════════════════════════════════╗")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ║ Github(Username) : AminMirzaeiOne ║ You can follow me on GitHub and see all my software projects ")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ╚═══════════════════════════════════╝")
        System.Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("   --------------------------------------")
        System.Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("   ╔═══════════════════════════════════╗")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ║     Instagram : amin.reals        ║ You can follow me on Instagram ")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ║                                   ║")
        Console.WriteLine("   ╚═══════════════════════════════════╝")
        System.Console.ResetColor()
    End Sub



End Module
