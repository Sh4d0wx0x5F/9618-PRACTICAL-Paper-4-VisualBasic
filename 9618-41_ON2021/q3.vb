' PART_A
Dim ArrayNodes(19, 2) As Integer
Dim RootPointer As Integer = -1
Dim FreeNode As Integer = 0

' PART_B
Sub AddNode(ArrayNodes, RootPointer, FreeNode)
    Console.Write("Enter the Data: ")
    Dim NodeData As Integer = Console.ReadLine()
    If FreeNode <= 19 Then
        ArrayNodes(FreeNode, 0) = -1
        ArrayNodes(FreeNode, 1) = NodeData
        ArrayNodes(FreeNode, 2) = -1
        If RootPointer = -1 Then ' Add to start
            RootPointer = 0
        Else
            Dim Placed As Boolean = False
            Dim CurrentNode As Integer = RootPointer
            While Not Placed
                If NodeData < ArrayNodes(CurrentNode, 1) Then
                    If ArrayNodes(CurrentNode, 0) = -1 Then
                        ArrayNodes(CurrentNode, 0) = FreeNode
                        Placed = True
                    Else
                        CurrentNode = ArrayNodes(CurrentNode, 0)
                    End If
                Else
                    If ArrayNodes(CurrentNode, 2) = -1 Then
                        ArrayNodes(CurrentNode, 2) = FreeNode
                        Placed = True
                    Else
                        CurrentNode = ArrayNodes(CurrentNode, 2)
                    End If
                End If
            End While
        End If
        FreeNode = FreeNode + 1
    Else
        Console.WriteLine("Tree is full")
    End If
End Sub

' PART_C
Sub PrintAll(ArrayNodes)
    For X As Integer = 0 To 19
        Console.WriteLine(ArrayNodes(X, 0) & " " & ArrayNodes(X, 1) & " " & ArrayNodes(X, 2))
    Next
End Sub

' PART_D-1
For X As Integer = 0 To 9
    AddNode(ArrayNodes, RootPointer, FreeNode)
Next
PrintAll(ArrayNodes)

' PART_D-2

' Output:
' 1 10 2
' 9 5 3
' 4 15 6
' 5 8 8
' 7 12 -1
' -1 6 -1
' -1 20 -1
' -1 11 -1
' -1 9 -1
' -1 4 -1
' 0 0 0
' 0 0 0
' 0 0 0
' 0 0 0
' 0 0 0
' 0 0 0
' 0 0 0
' 0 0 0
' 0 0 0
' 0 0 0

' PART_E-1
Sub InOrder(ArrayNodes, RootNode)
    If ArrayNodes(RootNode, 0) <> -1 Then
        InOrder(ArrayNodes, ArrayNodes(RootNode, 0))
        Console.WriteLine(ArrayNodes(RootNode, 1))
        If ArrayNodes(RootNode, 2) <> -1 Then
            InOrder(ArrayNodes, ArrayNodes(RootNode, 2))
        End If
    End If
End Sub

' PART_E-2

' Output:
' Enter the Data: 10
' Enter the Data: 5
' Enter the Data: 15
' Enter the Data: 8
' Enter the Data: 12
' Enter the Data: 6
' Enter the Data: 20
' Enter the Data: 11
' Enter the Data: 9
' Enter the Data: 4
'1   10   2
'9   5   3
'4   15   6
'5   8   8
'7   12   -1
'-1   6   -1
'-1   20   -1
'-1   11   -1
'-1   9   -1
'-1   4   -1
'0   0   0
'0   0   0
'0   0   0
'0   0   0
'0   0   0
'0   0   0
'0   0   0
'0   0   0
'0   0   0
'0   0   0
' 4
' 5
' 6
' 8
' 9
' 10
' 11
' 12
' 15
' 20
