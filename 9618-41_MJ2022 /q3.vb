' PART_A
Dim QueueArray(9) As String
Dim QueueHeadPointer As Integer = 0
Dim QueueTailPointer As Integer = 0
Dim NumberOfItems As Integer = 0

' PART_B
Function Enqueue(Queue() As String, ByRef Head As Integer, ByRef Tail As Integer, ByRef NumItems As Integer, InputData As String) As Tuple(Of Boolean, String(), Integer, Integer, Integer)
	If NumItems >= 10 Then
		Return New Tuple(Of Boolean, String(), Integer, Integer, Integer)(False, Queue, Head, Tail, NumItems)
	End If
	Queue(Tail) = InputData
	If Tail >= 9 Then
		Tail = 0
	Else
		Tail += 1
	End If
	NumItems += 1
	Return New Tuple(Of Boolean, String(), Integer, Integer, Integer)(True, Queue, Head, Tail, NumItems)
End Function

' PART_C
Function Dequeue(Queue() As String, ByRef Head As Integer, ByRef Tail As Integer, ByRef NumItems As Integer) As Tuple(Of Object, String(), Integer, Integer, Integer)
	If NumItems = 0 Then
		Return New Tuple(Of Object, String(), Integer, Integer, Integer>(False, Queue, Head, Tail, NumItems)
	End If
	Dim ReturnValue As Object = Queue(Head)
	Head += 1
	If Head >= 9 Then
		Head = 0
	End If
	NumItems -= 1
	Return New Tuple(Of Object, String(), Integer, Integer, Integer>(ReturnValue, Queue, Head, Tail, NumItems)
End Function

' PART_D-1
For x As Integer = 0 To 10
	Dim InputString As String = Console.ReadLine("Enter a string: ")
	Dim ReturnValue As Tuple(Of Boolean, String(), Integer, Integer, Integer) = Enqueue(QueueArray, QueueHeadPointer, QueueTailPointer, NumberOfItems, InputString)
	If ReturnValue.Item1 Then
		Console.WriteLine("Successful")
	Else
		Console.WriteLine("Unsuccessful")
	End If
Next

Dim ReturnValue As Tuple(Of Object, String(), Integer, Integer, Integer) = Dequeue(QueueArray, QueueHeadPointer, QueueTailPointer, NumberOfItems)
Console.WriteLine(ReturnValue.Item1)
ReturnValue = Dequeue(QueueArray, QueueHeadPointer, QueueTailPointer, NumberOfItems)
Console.WriteLine(ReturnValue.Item1)

' PART_D-2

' Enter a string: A
' Successful
' Enter a string: B
' Successful
' Enter a string: C
' Successful
' Enter a string: D
' Successful
' Enter a string: E
' Successful
' Enter a string: F
' Successful
' Enter a string: G
' Successful
' Enter a string: H
' Successful
' Enter a string: I
' Successful
' Enter a string: J
' Successful
' Enter a string: K 
' Unsuccessful
' A
' B
