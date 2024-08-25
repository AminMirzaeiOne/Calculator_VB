Imports System.Runtime.InteropServices

Module Operations
    Enum OperationStatus
        None
        Plus
        Minus
        Divide
        Multiply
    End Enum


    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode, SetLastError:=True)>
    Private Function GetConsoleScreenBufferInfo(consoleHandle As IntPtr, <Out> ByRef consoleScreenBufferInfo As CONSOLE_SCREEN_) As Boolean
    End Function

    Public Property Status As Calculator.Operations.OperationStatus = OperationStatus.None
    Public Sub Plus()
        Dim oneNumber As String = "0"
        Calculator.Operations.Status = OperationStatus.Plus
        System.Console.SetCursorPosition(5, 3)
        cursor = 5
        For index = 5 To 12
            cursor += 1
            System.Console.SetCursorPosition(cursor, 3)
            oneNumber = Console.inpu
        Next
        Calculator.Program.OneNumber = 
    End Sub

    Public Sub Minus()
        Calculator.Operations.Status = OperationStatus.Minus
    End Sub

    Public Sub Divide()
        Calculator.Operations.Status = OperationStatus.Divide
    End Sub

    Public Sub Multiply()
        Calculator.Operations.Status = OperationStatus.Multiply
    End Sub

End Module
