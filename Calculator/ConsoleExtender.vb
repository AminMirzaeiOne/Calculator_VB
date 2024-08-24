Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Drawing
Namespace ConsoleExtender

    <StructLayout(LayoutKind.Sequential, Pack:=1)>
    Public Structure ConsoleFont
        Public Index As UInteger
        Public SizeX, SizeY As Short
    End Structure

    Public Module ConsoleHelper
        <DllImport("kernel32")>
        Public Function SetConsoleIcon(hIcon As IntPtr) As Boolean
        End Function

        Public Function SetConsoleIcon(icon As Icon) As Boolean
            Return SetConsoleIcon(icon.Handle)
        End Function

        <DllImport("kernel32")>
        Private Function SetConsoleFont(hOutput As IntPtr, index As UInteger) As Boolean
        End Function

        Private Enum StdHandle
            OutputHandle = -11
        End Enum

        <DllImport("kernel32")>
        Private Function GetStdHandle(index As StdHandle) As IntPtr
        End Function

        Public Function SetConsoleFont(index As UInteger) As Boolean
            Return SetConsoleFont(GetStdHandle(StdHandle.OutputHandle), index)
        End Function

        <DllImport("kernel32")>
        Private Function GetConsoleFontInfo(hOutput As IntPtr,
        <MarshalAs(UnmanagedType.Bool)> bMaximize As Boolean, count As UInteger,
<MarshalAs(UnmanagedType.LPArray), Out> fonts As ConsoleFont()) As Boolean
        End Function

        <DllImport("kernel32")>
        Private Function GetNumberOfConsoleFonts() As UInteger
        End Function

        Public ReadOnly Property ConsoleFontsCount As UInteger
            Get
                Return GetNumberOfConsoleFonts()
            End Get
        End Property

        Public ReadOnly Property ConsoleFonts As ConsoleFont()
            Get
                Dim fonts As ConsoleFont() = New ConsoleFont(GetNumberOfConsoleFonts() - 1) {}
                If fonts.Length > 0 Then GetConsoleFontInfo(GetStdHandle(StdHandle.OutputHandle), False, fonts.Length, fonts)
                Return fonts
            End Get
        End Property
    End Module


End Namespace
