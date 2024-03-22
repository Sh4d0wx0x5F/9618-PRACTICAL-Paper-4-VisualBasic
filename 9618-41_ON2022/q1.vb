Module Main
    ' PART_A: Initializing the DataArray
    Dim DataArray(99) As Integer

    ' PART_B: Function to read data from file into DataArray
    Sub ReadFile()
        Try
            Dim TextFile As String = "IntegerData.txt"
            Dim File As New System.IO.StreamReader(TextFile)
            For X As Integer = 0 To 99
                DataArray(X) = Integer.Parse(File.ReadLine())
            Next
            File.Close()
        Catch ex As Exception
            Console.WriteLine("Count not find file")
        End Try
    End Sub

    ' PART_C: Function to find the number of occurrences of a value in DataArray
    Function FindValues() As Integer
        Dim Total As Integer = 0
        Dim DataToFind As Integer = -1
        While (DataToFind < 1 Or DataToFind > 100)
            Console.Write("Enter a number between 1 and 100: ")
            DataToFind = Integer.Parse(Console.ReadLine())
            For X As Integer = 0 To 98
                If DataArray(X) = DataToFind Then
                    Total = Total + 1
                End If
            Next
        End While
        Return Total
    End Function

    ' PART_D-1: Reading file and finding the number of occurrences
    Sub Main()
        ReadFile()
        Console.WriteLine("The number appears " & FindValues() & " times")
    End Sub

    ' PART_D-2: Provided code for user input and displaying the result
    '''
    Enter a number between 1 and 100: 61
    The number appears 2 times
    '''

    ' PART_E: Function to perform bubble sort on DataArray
    Sub BubbleSort()
        Dim N As Integer = 100
        For I As Integer = 0 To N - 2
            For J As Integer = 0 To N - I - 2
                If DataArray(J) > DataArray(J + 1) Then
                    Dim temp As Integer = DataArray(J)
                    DataArray(J) = DataArray(J + 1)
                    DataArray(J + 1) = temp
                End If
            Next
        Next
    End Sub

    ' Main function to call BubbleSort and display sorted array
    Sub Main()
        BubbleSort()
        For Each num As Integer In DataArray
            Console.Write(num & " ")
        Next
    End Sub
End Module
