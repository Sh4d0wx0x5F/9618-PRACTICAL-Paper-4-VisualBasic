Module Module1

    Sub Main()
        Dim TheData As Integer() = {20, 3, 4, 8, 12, 99, 4, 26, 4}

        Console.WriteLine("Before")
        PrintArray(TheData)
        InsertionSort(TheData)
        Console.WriteLine("After")
        PrintArray(TheData)

        Search(TheData)
    End Sub

    Sub InsertionSort(ByRef TheData As Integer())
        For Count As Integer = 0 To TheData.Length - 1
            Dim DataToInsert As Integer = TheData(Count)
            Dim Inserted As Integer = 0
            Dim NextValue As Integer = Count - 1

            While NextValue >= 0 AndAlso Inserted <> 1
                If DataToInsert < TheData(NextValue) Then
                    TheData(NextValue + 1) = TheData(NextValue)
                    NextValue = NextValue - 1
                    TheData(NextValue + 1) = DataToInsert
                Else
                    Inserted = 1
                End If
            End While
        Next
    End Sub

    Sub PrintArray(ByVal TheData As Integer())
        For count As Integer = 0 To TheData.Length - 1
            Console.WriteLine(TheData(count))
        Next
    End Sub

    Function Search(ByVal TheData As Integer()) As Boolean
        Console.Write("Enter a whole number: ")
        Dim NumberInput As Integer = Integer.Parse(Console.ReadLine())

        For count As Integer = 0 To TheData.Length - 1
            If TheData(count) = NumberInput Then
                Console.WriteLine("Found")
                Return True
            End If
        Next

        Console.WriteLine("Not found")
        Return False
    End Function

End Module
