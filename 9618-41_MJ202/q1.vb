'PART_A
Public Class Node
    Public Data As Integer
    Public nextNode As Integer

    Public Sub New(theData As Integer, nextNodeNumber As Integer)
        ' Constructor for Node class
        Data = theData ' Data value of the node
        nextNode = nextNodeNumber ' Pointer to the next node
    End Sub
End Class

Module Module1
    'PART_B
    ' Define the linked list with initial nodes and pointers
    Dim linkedList As Node() = {New Node(1, 1), New Node(5, 4), New Node(6, 7), New Node(7, -1), New Node(2, 2), New Node(0, 6), New Node(0, 8), New Node(56, 3), New Node(0, 9), New Node(0, -1)}
    Dim startPointer As Integer = 0 ' Pointer to the first node in the linked list
    Dim emptyList As Integer = 5 ' Index of the first empty slot in the linked list

    'PART_C-1
    ' Function to output all nodes in the linked list
    Sub OutputNodes(linkedList As Node(), currentPointer As Integer)
        While currentPointer <> -1
            ' Output data of the current node
            Console.WriteLine(linkedList(currentPointer).Data.ToString())
            ' Move to the next node
            currentPointer = linkedList(currentPointer).nextNode
        End While
    End Sub

    'PART_C-2
    Sub Main()
        ' Output all nodes in the linked list
        OutputNodes(linkedList, startPointer)
        Console.WriteLine("")

        'PART_D-1
        ' Add a new node to the linked list
        Dim returnValue As Boolean = AddNode(linkedList, startPointer, emptyList)
        ' Output the result of adding a new node
        If returnValue Then
            Console.WriteLine("Item successfully added")
        Else
            Console.WriteLine("Item not added, list full")
        End If
        ' Output all nodes in the linked list after adding a new node
        OutputNodes(linkedList, startPointer)
    End Sub

    'PART_D-2
    Function AddNode(linkedList As Node(), ByRef currentPointer As Integer, ByRef emptyList As Integer) As Boolean
        ' Prompt user to enter data for the new node
        Console.Write("Enter the data to add: ")
        ' Read the data from user input
        Dim dataToAdd As Integer = Integer.Parse(Console.ReadLine())

        ' Check if there's an available slot in the linked list
        If emptyList < 0 OrElse emptyList > 9 Then
            ' If the list is full, return false
            Return False
        Else
            ' Create a new node with the entered data and -1 as the next node pointer
            Dim newNode As Node = New Node(dataToAdd, -1)
            ' Insert the new node into the linked list at the empty slot
            linkedList(emptyList) = newNode

            ' Traverse the linked list to find the last node
            Dim previousPointer As Integer = 0
            While currentPointer <> -1
                ' Update the previous pointer to the current pointer
                previousPointer = currentPointer
                ' Move to the next node
                currentPointer = linkedList(currentPointer).nextNode
            End While

            ' Update the next node pointer of the previous node to point to the new node
            linkedList(previousPointer).nextNode = emptyList
            ' Update the empty list pointer to the next empty slot in the linked list
            emptyList = linkedList(emptyList).nextNode
            ' Return true to indicate successful addition of the new node
            Return True
        End If
    End Function
End Module

'PART_D-3
'''
1
5
2
6
56
7
Enter the data to add: 5
Item successfully added
1
5
2
6
56
7
5
'''
