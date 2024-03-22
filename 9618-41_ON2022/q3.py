Module Main
    ' PART_A: Initializing ArrayNodes with -1 values
    Dim ArrayNodes As New List(Of Integer())()
    For x As Integer = 0 To 19
        ArrayNodes.Add({-1, -1, -1})
    Next

    ' PART_B: Initializing ArrayNodes with predefined values
    Dim ArrayNodes As Integer()() = {New Integer() {1, 20, 5}, New Integer() {2, 15, -1}, New Integer() {-1, 3, 3}, New Integer() {-1, 9, 4}, New Integer() {-1, 10, -1}, New Integer() {-1, 58, -1}}
    Dim FreeNodes As Integer = 6
    Dim RootPointer As Integer = 0

    ' PART_C: Function to search for a value in ArrayNodes
    Function SearchValue(Root As Integer, ValueToFind As Integer) As Integer
        If Root = -1 Then
            Return -1
        ElseIf ArrayNodes(Root)(1) = ValueToFind Then
            Return Root
        ElseIf ArrayNodes(Root)(1) = -1 Then
            Return -1
        ElseIf ArrayNodes(Root)(1) > ValueToFind Then
            Return SearchValue(ArrayNodes(Root)(0), ValueToFind)
        ElseIf ArrayNodes(Root)(1) < ValueToFind Then
            Return SearchValue(ArrayNodes(Root)(2), ValueToFind)
        End If
    End Function

    ' PART_D: Function to perform post-order traversal of ArrayNodes
    Sub PostOrder(RootNode As Integer())
        If RootNode(0) <> -1 Then
            PostOrder(ArrayNodes(RootNode(0)))
        End If
        If RootNode(2) <> -1 Then
            PostOrder(ArrayNodes(RootNode(2)))
        End If
        Console.WriteLine(RootNode(1).ToString())
    End Sub

    ' PART_E-1: Searching for a value and performing post-order traversal
    Dim ReturnValue As Integer = SearchValue(RootPointer, 15)
    If ReturnValue = -1 Then
        Console.WriteLine("Not found")
    Else
        Console.WriteLine("Found at " & ReturnValue.ToString())
    End If
    PostOrder(ArrayNodes(RootPointer))

    ' PART_E-2: Provided post-order traversal result
    '''
    Found at 1
    10
    9
    3
    15
    58
    20
    '''
End Module
