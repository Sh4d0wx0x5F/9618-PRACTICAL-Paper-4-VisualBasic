Module Main
    ' PART A: Initializing array nodes, root pointer, and free node
    Dim ArrayNodes(19, 2) As Integer
    Dim RootPointer As Integer = -1
    Dim FreeNode As Integer = 0

    ' PART B: Function to add a node to the binary search tree
    Function AddNode(ByRef ArrayNodes As Integer(,), ByRef RootPointer As Integer, ByRef FreeNode As Integer) As (Integer(,), Integer, Integer)
        Dim NodeData As Integer
        Console.Write("Enter the Data: ")
        NodeData = Integer.Parse(Console.ReadLine())

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

        Return (ArrayNodes, RootPointer, FreeNode)
    End Function

    ' PART C: Function to print all nodes in the array
    Sub PrintAll(ArrayNodes As Integer(,))
        For X As Integer = 0 To 19
            Console.WriteLine($"{ArrayNodes(X, 0)} {ArrayNodes(X, 1)} {ArrayNodes(X, 2)}")
        Next
    End Sub

    ' PART D-1: Adding nodes to the binary search tree
    For X As Integer = 0 To 9
        Dim result = AddNode(ArrayNodes, RootPointer, FreeNode)
        ArrayNodes = result.Item1
        RootPointer = result.Item2
        FreeNode = result.Item3
    Next

    PrintAll(ArrayNodes)

    ' PART D-2: Provided code as is
    '''
    Enter the Data10
    Enter the Data5
    Enter the Data15
    Enter the Data8
    Enter the Data12
    Enter the Data6
    Enter the Data20
    Enter the Data11
    Enter the Data9
    Enter the Data4
    1   10   2
    9   5   3
    4   15   6
    5   8   8
    7   12   -1
    -1   6   -1
    -1   20   -1
    -1   11   -1
    -1   9   -1
    -1   4   -1
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    '''

    ' PART E-1: Function to perform in-order traversal of the binary search tree
    Sub InOrder(ArrayNodes As Integer(,), RootNode As Integer)
        If ArrayNodes(RootNode, 0) <> -1 Then
            InOrder(ArrayNodes, ArrayNodes(RootNode, 0))
        End If

        Console.WriteLine(ArrayNodes(RootNode, 1))

        If ArrayNodes(RootNode, 2) <> -1 Then
            InOrder(ArrayNodes, ArrayNodes(RootNode, 2))
        End If
    End Sub

    ' PART E-2: Provided code as is
    '''
    Enter the Data: 10
    Enter the Data: 5
    Enter the Data: 15
    Enter the Data: 8
    Enter the Data: 12
    Enter the Data: 6
    Enter the Data: 20
    Enter the Data: 11
    Enter the Data: 9
    Enter the Data: 4
    1   10   2
    9   5   3
    4   15   6
    5   8   8
    7   12   -1
    -1   6   -1
    -1   20   -1
    -1   11   -1
    -1   9   -1
    -1   4   -1
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    0   0   0
    '''

    'Console.WriteLine("In-Order Traversal:")'
    'InOrder(ArrayNodes, RootPointer)'
End Module
