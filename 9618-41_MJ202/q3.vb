' PART_A
Public Class TreasureChest
	' Private question As String
	' Private answer As Integer
	' Private points As Integer
	Public Sub New(questionP As String, answerP As Integer, pointsP As Integer)
		Me.__question = questionP
		Me.__answer = answerP
		Me.__points = pointsP
	End Sub

	Public ReadOnly Property Question() As String
		Get
			Return Me.__question
		End Get
	End Property

	Public Function CheckAnswer(answerP As Integer) As Boolean
		Return Me.__answer = answerP
	End Function

	Public Function GetPoints(attempts As Integer) As Integer
		Select Case attempts
			Case 1
				Return Me.__points
			Case 2
				Return Me.__points \ 2
			Case 3, 4
				Return Me.__points \ 4
			Case Else
				Return 0
		End Select
	End Function
End Class

' PART_B

Dim arrayTreasure As New List(Of TreasureChest)

Sub ReadData()
	Dim filename As String = "treasureChestData.txt"
	Try
		Using file As New StreamReader(filename)
			Dim dataFetched As String = file.ReadLine().Trim()
			While dataFetched <> ""
				Dim question As String = dataFetched
				Dim answer As Integer = Integer.Parse(file.ReadLine().Trim())
				Dim points As Integer = Integer.Parse(file.ReadLine().Trim())
				arrayTreasure.Add(New TreasureChest(question, answer, points))
				dataFetched = file.ReadLine().Trim()
			End While
		End Using
	Catch e As IOException
		Console.WriteLine("Could not find file")
	End Try
End Sub

' PART_C-4

ReadData()

Dim choice As Integer = CInt(Console.ReadLine())
If choice > 0 AndAlso choice < 6 Then
	Dim result As Boolean = False
	Dim attempts As Integer = 0
	While Not result
		Dim answer As Integer = CInt(Console.ReadLine(arrayTreasure(choice - 1).Question & ":"))
		result = arrayTreasure(choice - 1).CheckAnswer(answer)
		attempts += 1
	End While
	Console.WriteLine(arrayTreasure(choice - 1).GetPoints(attempts))
End If

' PART_C-5

' Pick a treasure chest to open: 3
' 1000*4: 4000
' 20

'
' Pick a treasure chest to open: 2
' 100/10: 2
' 100/10: 2
' 100/10: 10
' 3
