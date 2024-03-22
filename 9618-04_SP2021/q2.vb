Public Class HiddenBox
    'PART_A
    ' Private fields
    Private __BoxName As String
    Private __Creator As String
    Private __DateHidden As String
    Private __GameLocation As String
    Private __LastFinds(9, 1) As String
    Private __Active As Boolean

    'PART_B
    ' Constructor
    Public Sub New(NewBoxName As String, NewCreator As String, NewDateHidden As String, NewLocation As String)
        __BoxName = NewBoxName
        __Creator = NewCreator
        __DateHidden = NewDateHidden
        __GameLocation = NewLocation
        ReDim __LastFinds(9, 1)
        __Active = False
    End Sub

    'PART_C
    ' Getters
    Public Function GetBoxName() As String
        Return __BoxName
    End Function

    Public Function GetLocation() As String
        Return __GameLocation
    End Function

    'PART_D-1
    ' Initialize array of HiddenBox objects
    Dim TheBoxes(9999) As HiddenBox

    'PART_D-2
    Dim NumBoxes As Integer = 0

    Public Function NewBox() As Integer
        Dim BoxName As String = Console.ReadLine()
        Dim Creator As String = Console.ReadLine()
        Dim DateHidden As String = Console.ReadLine()
        Dim Location As String = Console.ReadLine()
        TheBoxes(NumBoxes) = New HiddenBox(BoxName, Creator, DateHidden, Location)
        Return NumBoxes + 1
    End Function

    'PART_D-3
    NumBoxes = NewBox()

End Class

'PART_E
Public Class PuzzleBox
    Inherits HiddenBox
    ' Private fields
    Private __PuzzleText As String
    Private __Solution As String

    ' Constructor
    Public Sub New(NewBoxName As String, NewCreator As String, NewDateHidden As String, NewLocation As String, NewPuzzleText As String, NewSolution As String)
        MyBase.New(NewBoxName, NewCreator, NewDateHidden, NewLocation)
        __PuzzleText = NewPuzzleText
        __Solution = NewSolution
    End Sub
End Class
