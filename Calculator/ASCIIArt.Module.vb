Imports System.Drawing
Imports System.IO

Class ASCIIArt
    Private _imageLocation As String

    Sub New(ImageLocation As String)
        _imageLocation = ImageLocation
        Dim font = New Font("Courier New", 9)
        Dim printableChars = New List(Of String)()
        Dim brightness = New List(Of Double)()

        For i = Convert.ToInt32(Char.MinValue) To 100
            Dim c = Convert.ToChar(i)
            If Not Char.IsControl(c) Then
                printableChars.Add(c.ToString())
            End If
        Next
        Dim bmp = New Bitmap(1, 1)
        Dim stringMeasure = Graphics.FromImage(bmp)
        For Each printableChar In printableChars
            Dim foo = stringMeasure.MeasureString(printableChar, font)
            Dim width = foo.ToSize().Width
            Dim height = foo.ToSize().Height
            Dim bitmap = New Bitmap(width, height)
            Dim g = Graphics.FromImage(bitmap)
            g.DrawString(printableChar, font, New SolidBrush(Color.Black), New RectangleF(0, 0, width, height))
            Dim charbrightness As Double = 0
            For x = 0 To width - 1
                For y = 0 To height - 1
                    charbrightness += Me.Brightness(bitmap.GetPixel(x, y))
                Next
            Next
            brightness.Add(Math.Round(charbrightness / (width * height)))
        Next

        Dim orderedZip = printableChars.Zip(brightness, Function(x, y) New With {x, y
                                }).OrderBy(Function(pair) pair.y).ToList()
        Dim sortedchars = orderedZip.[Select](Function(pair) pair.x).ToList()

        _pixels = sortedchars.Aggregate("", Function(current, sortedchar) current & sortedchar)
    End Sub

    Private _pixels As String = " .-+*wGHM#&%"

    Public Sub Go(saveLocation As String)
        Dim img = New Bitmap(_imageLocation)
        Using wrtr = New StreamWriter(saveLocation)
            For y = 0 To img.Height - 1
                For x = 0 To img.Width - 1
                    Dim color = img.GetPixel(x, y)
                    Dim brightness As Double = Me.Brightness(color)
                    Dim idx = brightness / 255 * (_pixels.Length - 1)
                    Dim pxl = _pixels(_pixels.Length - CInt(Math.Round(idx)) - 1)
                    wrtr.Write(pxl)
                    wrtr.Write(pxl)
                Next
                wrtr.WriteLine()
            Next
        End Using
    End Sub

    Public Function Brightness(c As Color) As Double
        Return Math.Sqrt(c.R * c.R * 0.241 + c.G * c.G * 0.691 + c.B * c.B * 0.068)
    End Function
End Class
