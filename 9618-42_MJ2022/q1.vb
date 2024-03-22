Module Main
    ' PART_A: Initializing StackData and StackPointer
    Dim StackData As Integer() = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim StackPointer As Integer = 0

    ' PART_B: Function to print StackData
    Sub PrintArray()
        Console.WriteLine(StackPointer)
        For x As Integer = 0 To 9
            Console.WriteLine(StackData(x))
        Next
    End Sub

    ' PART_C: Function to push data onto the stack
    Function Push(DataToPush As Integer) As Boolean
        If StackPointer = 10 Then
            Return False
        Else
            StackData(StackPointer) = DataToPush
            StackPointer += 1
            Return True
        End If
    End Function

    ' PART_D-1: Pushing data onto the stack
    For x As Integer = 0 To 10
        Dim TempNumber As Integer = Integer.Parse(Console.ReadLine())
        If Push(TempNumber) Then
            Console.WriteLine("Stored")
        Else
            Console.WriteLine("Stack full")
        End If
    Next
    PrintArray()

    ' PART_D-2: Sample input and output
    '''
    Enter a number: 11
    Stored
    Enter a number: 12
    Stored
    Enter a number: 13
    Stored
    Enter a number: 14
    Stored
    Enter a number: 15
    Stored
    Enter a number: 16
    Stored
    Enter a number: 17
    Stored
    Enter a number: 18
    Stored
    Enter a number: 19
    Stored
    Enter a number: 20
    Stored
    Enter a number: 21
    Stack full
    10
    11
    12
    13
    14
    15
    16
    17
    18
    19
    '''

    ' PART_E-1: Function to pop data from the stack
    Function Pop() As Integer
        If StackPointer = 0 Then
            Return -1
        Else
            Dim ReturnData As Integer = StackData(StackPointer - 1)
            StackPointer -= 1
            Return ReturnData
        End If
    End Function

    ' Testing pop operation
    Console.WriteLine(Pop())
    Console.WriteLine(Pop())
    PrintArray()
End Module
