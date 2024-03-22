Module Main
    ' PART_A: Card class representing a playing card
    Class Card
        ' Number as Integer
        ' Colour as String
        Private __Number As Integer
        Private __Colour As String

        ' Constructor for Card class
        Public Sub New(Numberp As Integer, Colourp As String)
            __Number = Numberp
            __Colour = Colourp
        End Sub

        ' Getter method for card number
        Public Function GetNumber() As Integer
            Return __Number
        End Function

        ' Getter method for card colour
        Public Function GetColour() As String
            Return __Colour
        End Function
    End Class

    ' PART_C: Reading card values from file and storing them in CardArray
    Dim CardArray(29) As Card
    Try
        Dim Filename As String = "CardValues.txt"
        Dim File As New System.IO.StreamReader(Filename)
        For x As Integer = 0 To 29
            Dim NumberRead As Integer = Integer.Parse(File.ReadLine())
            Dim ColourRead As String = File.ReadLine()
            CardArray(x) = New Card(NumberRead, ColourRead)
        Next
        File.Close()
    Catch ex As Exception
        Console.WriteLine("Could not find file")
    End Try

    ' PART_D: Function to choose a card
    Dim NumbersChosen(29) As Boolean ' Global variable to track chosen cards
    Function ChooseCard() As Integer
        Dim flagContinue As Boolean = True
        Dim CardSelected As Integer = 0
        While flagContinue = True
            CardSelected = Integer.Parse(Console.ReadLine())
            If CardSelected < 1 Or CardSelected > 30 Then
                Console.WriteLine("Number must be between 1 and 30")
            ElseIf NumbersChosen(CardSelected - 1) = True Then
                Console.WriteLine("Already taken")
            Else
                Console.WriteLine("Valid")
                flagContinue = False
            End If
            NumbersChosen(CardSelected - 1) = True
        End While
        Return CardSelected - 1
    End Function

    ' PART_E-1: Player1 choosing cards
    Dim Player1(3) As Card
    For x As Integer = 0 To 3
        Dim ReturnNumber As Integer = ChooseCard()
        Player1(x) = CardArray(ReturnNumber)
    Next

    ' Printing chosen cards for Player1
    For x As Integer = 0 To 3
        Console.WriteLine(Player1(x).GetColour().Trim())
        Console.WriteLine(Player1(x).GetNumber())
    Next

    #PART_E-2

'''
Select a Card from 1 to 30: 1
Valid
Select a Card from 1 to 30: 5
Valid
Select a Card from 1 to 30: 9
Valid
Select a Card from 1 to 30: 10
Valid
red
1
green
9
orange
9
red
10


--------------
Select a Card from 1 to 30: 2
Valid
Select a Card from 1 to 30: 2
Already taken
Select a Card from 1 to 30: 3
Valid
Select a Card from 1 to 30: 4
Valid
Select a Card from 1 to 30: 4
Already taken
Select a Card from 1 to 30: 5
Valid
black
5
white
2
red
4
green
9
'''

End Module





