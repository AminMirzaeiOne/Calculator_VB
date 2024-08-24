Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Drawing
Public Module ConsoleHelper

    Private Const FixedWidthTrueType As Integer = 54
    Private Const StandardOutputHandle As Integer = -11

    <DllImport("kernel32.dll", SetLastError:=True)>
    Friend Function GetStdHandle(nStdHandle As Integer) As IntPtr
    End Function


    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Friend Function SetCurrentConsoleFontEx(hConsoleOutput As IntPtr, MaximumWindow As Boolean, ByRef ConsoleCurrentFontEx As FontInfo) As Boolean
    End Function


    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)>
    Friend Function GetCurrentConsoleFontEx(hConsoleOutput As IntPtr, MaximumWindow As Boolean, ByRef ConsoleCurrentFontEx As FontInfo) As Boolean
    End Function


    Private ReadOnly ConsoleOutputHandle As IntPtr = GetStdHandle(StandardOutputHandle)

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure FontInfo
        Friend cbSize As Integer
        Friend FontIndex As Integer
        Friend FontWidth As Short
        Public FontSize As Short
        Public FontFamily As Integer
        Public FontWeight As Integer
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public FontName As String
    End Structure

    Public Function SetCurrentFont(font As String, Optional fontSize As Short = 0) As FontInfo()
        Console.WriteLine("Set Current Font: " & font)

        Dim before As FontInfo = New FontInfo With {
        .cbSize = Marshal.SizeOf(Of FontInfo)()
    }

        If GetCurrentConsoleFontEx(ConsoleOutputHandle, False, before) Then

            Dim [set] As FontInfo = New FontInfo With {
        .cbSize = Marshal.SizeOf(Of FontInfo)(),
        .FontIndex = 0,
        .FontFamily = FixedWidthTrueType,
        .FontName = font,
        .FontWeight = 400,
        .FontSize = If(fontSize > 0, fontSize, before.FontSize)
    }

            ' Get some settings from current font.
            If Not SetCurrentConsoleFontEx(ConsoleOutputHandle, False, [set]) Then
                Dim ex = Marshal.GetLastWin32Error()
                Console.WriteLine("Set error " & ex.ToString())
                Throw New ComponentModel.Win32Exception(ex)
            End If

            Dim after As FontInfo = New FontInfo With {
        .cbSize = Marshal.SizeOf(Of FontInfo)()
    }
            GetCurrentConsoleFontEx(ConsoleOutputHandle, False, after)

            Return {before, [set], after}
        Else
            Dim er = Marshal.GetLastWin32Error()
            Console.WriteLine("Get error " & er.ToString())
            Throw New ComponentModel.Win32Exception(er)
        End If
    End Function
End Module