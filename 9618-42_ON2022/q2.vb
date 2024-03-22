Imports System.IO

Public Class Character
    ' PART_A: Private fields to store character details
    Private __Name As String
    Private __XCoordiante As Integer
    Private __YCoordinate As Integer

    ' Constructor to initialize character details
    Public Sub New(Namep As String, Xcoord As Integer, Ycoord As Integer)
        Me.__Name = Namep
        Me.__XCoordiante = Xcoord
        Me.__YCoordinate = Ycoord
    End Sub

    ' PART_B: Getter methods for character details
    Public Function GetName() As String
        Return Me.__Name
    End Function

    Public Function GetX() As Integer
        Return Me.__XCoordiante
    End Function

    Public Function GetY() As Integer
        Return Me.__YCoordinate
    End Function

    ' PART_C: Method to change character position
    Public Sub ChangePosition(XChange As Integer, YChange As Integer)
        Me.__XCoordiante += XChange
        Me.__YCoordinate += YChange
    End Sub
End Class

Module Main
    ' PART_D: Load characters from file into Characters list
    Dim Characters As New List(Of Character)()
    Dim TextFile As String = "Characters.txt"

    Try
        Dim FileLines() As String = File.ReadAllLines(TextFile)
        For X As Integer = 0 To 9 Step 3
            Dim Name As String = FileLines(X).Trim()
            Dim XCoord As Integer = Integer.Parse(FileLines(X + 1).Trim())
            Dim YCoord As Integer = Integer.Parse(FileLines(X + 2).Trim())
            Characters.Add(New Character(Name, XCoord, YCoord))
        Next
    Catch
        Console.WriteLine("File not found")
    End Try

    ' PART_E: Prompt user to enter the character to move
    Dim Position As Integer = -1
    Dim CharacterName As String = ""
    While Position = -1
        CharacterName = InputBox("Enter the Character to move: ").Trim().ToLower()
        For Count As Integer = 0 To 9
            Dim Temp As String = Characters(Count).GetName().Trim().ToLower()
            If Temp = CharacterName Then
                Position = Count
                Exit For
            End If
        Next
    End While

    ' PART_F: Prompt user for movement and update character position
    Dim IsValid As Boolean = False
    While Not IsValid
        Dim Move As String = InputBox("Enter A for left, W for up, S for down, or D for right: ").ToUpper()
        If Move = "A" Then
            Characters(Position).ChangePosition(-1, 0)
            IsValid = True
        ElseIf Move = "W" Then
            Characters(Position).ChangePosition(0, 1)
            IsValid = True
        ElseIf Move = "S" Then
            Characters(Position).ChangePosition(0, -1)
            IsValid = True
        ElseIf Move = "D" Then
            Characters(Position).ChangePosition(1, 0)
            IsValid = True
        End If
    End While

    ' PART_G-1: Print the updated character coordinates
    Console.WriteLine(CharacterName & " has changed coordinate to X = " & Characters(Position).GetX() & " Y = " & Characters(Position).GetY())

    #PART_G-2

'''
Enter the Character to move: THOMAS
Enter the Character to move: qui
Enter A for left, W for up, S for down, or D for right: X
Enter A for left, W for up, S for down, or D for right: A
  has changed coordinate to X =  83  Y =  9
'''


End Module




