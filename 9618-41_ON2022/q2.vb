Class Card
    'PART_A-1: Defining the Card class
    Private __Number As Integer
    Private __Colour As String

    Public Sub New(Number1 As Integer, Colour1 As String)
        __Number = Number1
        __Colour = Colour1
    End Sub

    'PART_A-2: Getter methods for Number and Colour
    Public Function GetNumber() As Integer
        Return __Number
    End Function

    Public Function GetColour() As String
        Return __Colour
    End Function
End Class

'PART_B-1: Defining the Hand class
Class Hand
    Private __Cards As List(Of Card)
    Private __FirstCard As Integer
    Private __NumberCards As Integer

    Public Sub New(Card1 As Card, Card2 As Card, Card3 As Card, Card4 As Card, Card5 As Card)
        __Cards = New List(Of Card) From {Card1, Card2, Card3, Card4, Card5}
        __FirstCard = 0
        __NumberCards = 5
    End Sub

    'PART_B-2: Getter method for getting a card at a specific position
    Public Function GetCard(Position As Integer) As Card
        Return __Cards(Position)
    End Function
End Class

'PART_C-1: Function to calculate the value of a player's hand
Function CalculateValue(Player As Hand) As Integer
    Dim Score As Integer = 0
    For Count As Integer = 0 To 3
        Dim CardGot As Card = Player.GetCard(Count)
        Score += CardGot.GetNumber()
        Dim Colour As String = CardGot.GetColour()
        If Colour = "red" Then
            Score += 5
        ElseIf Colour = "blue" Then
            Score += 10
        Else
            Score += 15
        End If
    Next
    Return Score
End Function

'PART_C-2: Calculating scores for Player 1 and Player 2
Dim Player1 As New Hand(New Card(1, "red"), New Card(2, "red"), New Card(3, "red"), New Card(4, "red"), New Card(1, "yellow"))
Dim Player2 As New Hand(New Card(2, "yellow"), New Card(3, "yellow"), New Card(4, "yellow"), New Card(5, "yellow"), New Card(1, "blue"))

Dim Player1score As Integer = CalculateValue(Player1)
Dim Player2score As Integer = CalculateValue(Player2)

If Player1score > Player2score Then
    Console.WriteLine("Player 1 wins")
ElseIf Player1score < Player2score Then
    Console.WriteLine("Player 2 wins")
Else
    Console.WriteLine("It's a draw")
End If
