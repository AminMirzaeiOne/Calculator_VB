Imports System.Runtime.InteropServices
Imports System.Text

Module ReadCharacter
    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Function GetStdHandle(nStdHandle As Integer) As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Function ReadConsoleOutputCharacter(hConsoleOutput As IntPtr,
                    <Out> lpCharacter As StringBuilder, length As UInteger, bufferCoord As COORD, <Out> ByRef lpNumberOfCharactersRead As UInteger) As Boolean


    End Function

    <StructLayout(LayoutKind.Sequential)>
    Public Structure COORD
        Public X As Short
        Public Y As Short
    End Structure

    Public Function ReadCharacterAt(left As Integer, top As Integer) As Char
        left -= 1
        Dim consoleHandle As IntPtr = GetStdHandle(-11)
        If consoleHandle = IntPtr.Zero Then
            Return ChrW(0)
        End If
        Dim position As COORD = New COORD With {
        .X = left,
        .Y = top
    }
        Dim result As StringBuilder = New StringBuilder(1)
        Dim read As UInteger = 0
        If ReadConsoleOutputCharacter(consoleHandle, result, 1, position, read) Then
            Return result(0)
        Else
            Return ChrW(0)
        End If
    End Function

End Module
