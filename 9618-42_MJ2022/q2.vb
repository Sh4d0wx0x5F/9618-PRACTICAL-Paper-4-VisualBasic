Module Main
    ' PART_A: Initializing ArrayData with random integer values
    Dim ArrayData(9, 9) As Integer
    Dim rand As New Random()
    For x As Integer = 0 To 9
        For y As Integer = 0 To 9
            ArrayData(x, y) = rand.Next(1, 101)
        Next
    Next

    ' PART_B-2: Function to print the array
    Sub PrintArray(ArrayData As Integer(,))
        For x As Integer = 0 To 9
            For y As Integer = 0 To 9
                Console.Write(ArrayData(x, y) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    ' Printing array before sorting
    Console.WriteLine("Before")
    PrintArray(ArrayData)

    ' PART_B-1: Sorting ArrayData using Bubble Sort
    For X As Integer = 0 To 9
        For Y As Integer = 0 To 8
            For Z As Integer = 0 To 8 - Y
                If ArrayData(X, Z) > ArrayData(X, Z + 1) Then
                    Dim TempNumber As Integer = ArrayData(X, Z)
                    ArrayData(X, Z) = ArrayData(X, Z + 1)
                    ArrayData(X, Z + 1) = TempNumber
                End If
            Next
        Next
    Next

    ' Printing array after sorting
    Console.WriteLine("After")
    PrintArray(ArrayData)

    ' PART_B-3
    '''
    Before
    61 36 26 9 17 10 100 91 56 16
    71 68 63 46 9 51 32 5 20 57
    78 52 79 52 20 17 13 7 34 74
    68 74 94 78 52 68 75 28 63 9
    37 59 36 29 42 36 53 36 94 44
    80 25 1 14 84 8 96 71 6 89
    37 35 45 58 46 1 54 15 5 64
    19 64 52 8 92 97 22 8 14 44
    32 63 53 15 18 19 20 41 43 51
    32 56 91 63 15 38 58 64 71 6
    After
    9 10 16 17 26 36 56 61 91 100
    5 9 20 32 46 51 57 63 68 71
    7 13 17 20 34 52 52 74 78 79
    9 28 52 63 68 68 74 75 78 94
    29 36 36 36 37 42 44 53 59 94
    1 6 8 14 25 71 80 84 89 96
    1 5 15 35 37 45 46 54 58 64
    8 8 14 19 22 44 52 64 92 97
    15 18 19 20 32 41 43 51 53 63
    6 15 32 38 56 58 63 64 71 91
    '''

    ' PART_C-1: Function to perform binary search on a sorted array
    Function BinarySearch(SearchArray As Integer(,), Lower As Integer, Upper As Integer, SearchValue As Integer) As Integer
        If Upper >= 0 Then
            Dim Mid As Integer = CInt((Lower + (Upper - 1)) / 2)
            If SearchArray(0, Mid) = SearchValue Then
                Return Mid
            ElseIf SearchArray(0, Mid) > SearchValue Then
                Return BinarySearch(SearchArray, Lower, Mid - 1, SearchValue)
            Else
                Return BinarySearch(SearchArray, Mid + 1, Upper, SearchValue)
            End If
        End If
        Return -1
    End Function

    ' PART_C-2: Performing binary search on ArrayData
    Dim val As Integer
    val = Integer.Parse(Console.ReadLine())
    Console.WriteLine(BinarySearch(ArrayData, 0, 10, val))

    val = Integer.Parse(Console.ReadLine())
    Console.WriteLine(BinarySearch(ArrayData, 0, 10, val))

    ' Expected output provided in the comment
End Module
