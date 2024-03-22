' PART_A
Public Class Balloon
	' Health as integer
	' Colour as string
	' DefenceItem as string
	Public Sub New(PDefenceItem As String, PColour As String)
		Me.__Health = 100
		Me.__Colour = PColour
		Me.__DefenceItem = PDefenceItem
	End Sub

	' PART_B
	Public ReadOnly Property DefenceItem() As String
		Get
			Return Me.__DefenceItem
		End Get
	End Property

	' PART_C
	Public Sub ChangeHealth(Change As Integer)
		Me.__Health += Change
	End Sub

	' PART_D
	Public Function CheckHealth() As Boolean
		Return Me.__Health <= 0
	End Function
End Class

' PART_E

Dim Method As String = Console.ReadLine("Enter balloon defence method: ")
Dim Colour As String = Console.ReadLine("Enter the balloon colour: ")
Dim Balloon1 As New Balloon(Method, Colour)

' PART_F

Sub Defend(MyBalloon As Balloon)
	Dim Strength As Integer = Console.ReadLine("Enter the strength of opponent")
	MyBalloon.ChangeHealth(-Strength)
	Console.WriteLine("You defended with " & MyBalloon.DefenceItem)
	If MyBalloon.CheckHealth() Then
		Console.WriteLine("Defence failed")
	Else
		Console.WriteLine("Defence succeeded")
	End If
End Sub

' PART_G-1
Defend(Balloon1)

' PART_G-2

' Enter balloon defence method: shield
' Enter the balloon colour: red
' Enter the strength of opponent50
' You defended with  shield
' Defence succeeded
