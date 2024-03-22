Module Main
    ' PART_A: Initialize the queue and pointers
    Dim Queue(99) As Integer
    Dim HeadPointer As Integer = -1
    Dim TailPointer As Integer = 0

    ' PART_B: Enqueue function to add data to the queue
    Function Enqueue(Data As Integer) As Boolean
        If TailPointer < 100 Then
            If HeadPointer = -1 Then
                HeadPointer = 0
            End If
            Queue(TailPointer) = Data
            TailPointer += 1
            Return True
        End If
        Return False
    End Function

    ' PART_C: Enqueue data from 1 to 20
    Dim Success As Boolean = False
    For Count As Integer = 1 To 20
        Success = Enqueue(Count)
    Next
    If Success = False Then
        Console.WriteLine("Unsuccessful")
    Else
        Console.WriteLine("Successful")
    End If

    ' PART_D: Recursive function to output data from the queue
    Function RecursiveOutput(Start As Integer) As Integer
        If Start = 0 Then
            Return Queue(Start)
        Else
            Return Queue(Start) + RecursiveOutput(Start - 1)
        End If
    End Function

    ' PART_E-1: Print the sum of all elements in the queue
    Console.WriteLine(RecursiveOutput(TailPointer - 1))

    ' PART_E-2: Example usage
    '''
    Successful
    210
    '''
End Module
