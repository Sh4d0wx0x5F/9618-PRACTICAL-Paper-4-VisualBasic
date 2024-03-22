' PART_A
Function Unknown(X As Integer, Y As Integer) As Integer
	If X < Y Then
		Console.WriteLine(X + Y)
		Return Unknown(X + 1, Y) * 2
	ElseIf X = Y Then
		Return 1
	Else
		Console.WriteLine(X + Y)
		Return CInt(Unknown(X - 1, Y) / 2)
	End If
End Function

' PART_B-1

Console.WriteLine("10 and 15")
Console.WriteLine(Unknown(10, 15))
Console.WriteLine("10 and 10")
Console.WriteLine(Unknown(10, 10))
Console.WriteLine("15 and 10")
Console.WriteLine(Unknown(15, 10))

' PART_B-2

' 10 and 15
' 25
' 26
' 27
' 28
' 29
' 32
' 10 and 10
' 1
' 15 and 10
' 25
' 24
' 23
' 22
' 21
' 0

' PART_C

Function IterativeUnknown(X As Integer, Y As Integer) As Integer
	Dim Total As Integer = 1
	While X <> Y
		Console.WriteLine(X + Y)
		If X < Y Then
			X += 1
			Total *= 2
		Else
			X -= 1
			Total = CInt(Total / 2)
		End If
	End While
	Return Total
End Function

' PART_D-1

Console.WriteLine("10 and 15")
Console.WriteLine(IterativeUnknown(10, 15))
Console.WriteLine("10 and 10")
Console.WriteLine(IterativeUnknown(10, 10))
Console.WriteLine("15 and 10")
Console.WriteLine(IterativeUnknown(15, 10))

' PART_D-2

' 10 and 15
' 25
' 26
' 27
' 28
' 29
' 32
' 10 and 10
' 1
' 15 and 10
' 25
' 24
' 23
' 22
' 21
' 0
