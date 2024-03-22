Imports System.IO

Module Module1

    'PART_A
    Dim QueueData(19) As String
    Dim StartPointer As Integer = 0
    Dim EndPointer As Integer = 0

    'PART_B
    Function Enqueue(DataToAdd As String, ByRef QueueData As String(), ByRef EndP As Integer) As Tuple(Of Boolean, Integer)
        If EndP = 20 Then
            Return Tuple.Create(False, EndP)
        Else
            QueueData(EndP) = DataToAdd
            EndP = EndP + 1
            Return Tuple.Create(True, EndP)
        End If
    End Function

    'PART_C
    Function ReadFile(ByRef QueueData As String(), ByVal StartP As Integer, ByRef EndP As Integer) As Tuple(Of Integer, Integer)
        Dim FileName As String = Console.ReadLine()
        If File.Exists(FileName) Then
            Dim Flag As Boolean = True
            Dim f As StreamReader = New StreamReader(FileName)
            Dim DataToInsert As String = f.ReadLine().Trim()
            While Flag AndAlso DataToInsert <> ""
                Dim result = Enqueue(DataToInsert, QueueData, EndP)
                Flag = result.Item1
                EndP = result.Item2
                DataToInsert = f.ReadLine().Trim()
            End While
            f.Close()
            If Not Flag Then
                Return Tuple.Create(1, EndP)
            Else
                Return Tuple.Create(2, EndP)
            End If
        Else
            Return Tuple.Create(-1, EndP)
        End If
    End Function

    'PART_D-1
    Dim ReturnValue As Integer
    Dim result = ReadFile(QueueData, StartPointer, EndPointer)
    ReturnValue = result.Item1
    EndPointer = result.Item2
    If ReturnValue = -1 Then
        Console.WriteLine("The file could not be found")
    ElseIf ReturnValue = 1 Then
        Console.WriteLine("The queue was full, not all items were read")
    Else
        Console.WriteLine("All items successfully added")
    End If

    'PART_E
    Function Remove(ByRef QueueData As String(), ByVal StartP As Integer, ByRef EndP As Integer) As Tuple(Of String, Integer, Integer)
        If EndP - StartP < 2 Then
            Return Tuple.Create("No Items", StartP, EndP)
        Else
            Dim Value1 As String = QueueData(StartP)
            StartP = StartP + 1
            Dim Value2 As String = QueueData(StartP)
            StartP = StartP + 1
            Return Tuple.Create(Value1 & " " & Value2, StartP, EndP)
        End If
    End Function

End Module
