Module Module1
    ' PART_A
    Dim arrayData() As Integer = {10, 5, 6, 7, 1, 12, 13, 15, 21, 8}

    ' PART_B-1
    Function LinearSearch(searchValue As Integer) As Boolean
        For x As Integer = 0 To 9
            If arrayData(x) = searchValue Then
                Return True
            End If
        Next
        Return False
    End Function

    ' PART_B-2
    Sub Main()
        Dim searchValue As Integer
        Console.Write("Enter the number to search for: ")
        searchValue = Integer.Parse(Console.ReadLine())
        Dim returnValue As Boolean = LinearSearch(searchValue)
        If returnValue Then
            Console.WriteLine("It was found")
        Else
            Console.WriteLine("It was not found")
        End If
    End Sub

    ' PART_B-3
    ' Output:
    ' Enter the number to search for: 8
    ' It was found
    ' Enter the number to search for: 99
    ' It was not found

    ' PART_C
    Sub BubbleSort()
        For x As Integer = 0 To 9
            For y As Integer = 0 To 8
                If arrayData(y) < arrayData(y + 1) Then
                    Dim temp As Integer = arrayData(y)
                    arrayData(y) = arrayData(y + 1)
                    arrayData(y + 1) = temp
                End If
            Next
        Next
    End Sub
End Module
