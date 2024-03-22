Module Module1
    ' PART_A
    Dim FileData(10, 1) As String

    ' PART_B
    Sub ReadHighScores()
        Dim Filename As String = "HighScore.txt"
        Dim File As StreamReader = New StreamReader(Filename)

        For x As Integer = 0 To 9
            FileData(x, 0) = File.ReadLine().Substring(0, 3)
            FileData(x, 1) = File.ReadLine()
        Next

        File.Close()
    End Sub

    ' PART_C
    Sub OutputHighScores()
        For x As Integer = 0 To 10
            Dim Output As String = FileData(x, 0) & " " & FileData(x, 1)
            Console.WriteLine(Output)
        Next
    End Sub

    ' PART_D-1
    Sub Main()
        ReadHighScores()
        OutputHighScores()
    End Sub

    ' PART_D-2
    ' Output:
    ' FYI 10000
    ' ABC 9092
    ' KEL 8500
    ' PAI 8203
    ' BBB 7980
    ' ACE 7246
    ' GKL 7001
    ' JSI 6490
    ' EIF 6003
    ' DIS 2000

    ' PART_E-1
    Sub InputData()
        Dim Username As String = "ABCD"
        While Username.Length <> 3
            Username = Console.ReadLine()
        End While

        Dim Score As Integer = -1
        While Score < 1 OrElse Score > 100000
            Score = Integer.Parse(Console.ReadLine())
        End While

        Arrange(Username, Score)
    End Sub

    ' PART_E-2
    Sub Arrange(Username As String, Score As Integer)
        For x As Integer = 0 To 9
            If Score > Integer.Parse(FileData(x, 1)) Then
                Dim Temp1 As String = FileData(x, 0)
                Dim Temp2 As String = FileData(x, 1)
                FileData(x, 0) = Username
                FileData(x, 1) = Score.ToString()
                Dim Count As Integer = x + 1

                While Count < 10
                    Dim Second1 As String = FileData(Count, 0)
                    Dim Second2 As String = FileData(Count, 1)
                    FileData(Count, 0) = Temp1
                    FileData(Count, 1) = Temp2
                    Temp1 = Second1
                    Temp2 = Second2
                    Count += 1
                End While

                Exit For
            End If
        Next
    End Sub

    ' PART_E-3
    ' Output:
    ' FYI 10000
    ' JKL 9999
    ' ABC 9092
    ' KEL 8500
    ' PAI 8203
    ' BBB 7980
    ' ACE 7246
    ' GKL 7001
    ' JSI 6490
    ' EIF 6003

    ' PART_F
    Sub WriteTopTen()
        Dim Filename As String = "NewHighScore.txt"
        Dim File As StreamWriter = New StreamWriter(Filename)

        For x As Integer = 0 To 9
            File.WriteLine(FileData(x, 0))
            File.WriteLine(FileData(x, 1))
        Next

        File.Close()
    End Sub
End Module
