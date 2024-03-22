' PART_A
Public Class Picture
	Public Sub New(DescriptionP As String, WidthSizeP As Integer, HeightSizeP As Integer, FrameColourP As String)
		Me.__Description = DescriptionP
		Me.__Width = WidthSizeP
		Me.__Height = HeightSizeP
		Me.__FrameColour = FrameColourP
	End Sub

	'PART_B
	Public ReadOnly Property Description() As String
		Get
			Return Me.__Description
		End Get
	End Property

	Public ReadOnly Property Width() As Integer
		Get
			Return Me.__Width
		End Get
	End Property

	Public ReadOnly Property Height() As Integer
		Get
			Return Me.__Height
		End Get
	End Property

	Public ReadOnly Property FrameColour() As String
		Get
			Return Me.__FrameColour
		End Get
	End Property

	'PART_C
	Public Sub SetDescription(DescriptionP As String)
		Me.__Description = DescriptionP
	End Sub
End Class

'PART_D

Dim PictureArray(100) As Picture

'PART_E

Function ReadData(PictureArray() As Picture) As Tuple(Of Integer, Picture())
	Dim Filename As String = "Pictures.txt"
	Dim Counter As Integer = 0
	Try
		Using File As New StreamReader(Filename)
			Dim Description As String = File.ReadLine().Trim().ToLower()
			While Description <> ""
				Dim Width As Integer = Integer.Parse(File.ReadLine().Trim())
				Dim Height As Integer = Integer.Parse(File.ReadLine().Trim())
				Dim Frame As String = File.ReadLine().Trim().ToLower()
				PictureArray(Counter) = New Picture(Description, Width, Height, Frame)
				Description = File.ReadLine().Trim().ToLower()
				Counter += 1
			End While
		End Using
	Catch e As IOException
		Console.WriteLine("Could not find File")
	End Try
	Return Tuple.Create(Counter, PictureArray)
End Function

'PART_F

Dim NumberPicturesInArray, i As Integer
Dim PictureArray(100) As Picture
NumberPicturesInArray, PictureArray = ReadData(PictureArray)

'PART_G

Console.Write("Input the Frame colour: ")
Dim FrameColour As String = Console.ReadLine().ToLower()
Console.Write("Input the Maximum Width: ")
Dim MaxWidth As Integer = Integer.Parse(Console.ReadLine())
Console.Write("Input the Maximum Height: ")
Dim MaxHeight As Integer = Integer.Parse(Console.ReadLine())
Console.WriteLine("Matches Frames shown")
For Z As Integer = 0 To NumberPicturesInArray - 1
	If PictureArray(Z).FrameColour = FrameColour Then
		If PictureArray(Z).Width <= MaxWidth Then
			If PictureArray(Z).Height <= MaxHeight Then
				Console.WriteLine(PictureArray(Z).Description & " " & PictureArray(Z).Width & " " & PictureArray(Z).Height)
			End If
		End If
	End If
Next

'PART_H

' Input the Frame colour: BLACK
' Input the Maximum Width: 100
' Input the Maximum Height: 100
' Matches Frames shown
' flowers 45 50
' people 20 20
' landscape 30 45
' landscape 25 37
' people 50 40

' -------------------
' Input the Frame colour: silver
' Input the Maximum Width: 25
' Input the Maximum Height: 25
' Matches Frames shown
