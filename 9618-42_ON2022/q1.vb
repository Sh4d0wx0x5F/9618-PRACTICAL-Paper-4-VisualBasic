Module Main
    ' PART_A: Global variables to store jobs
    Dim Jobs(99, 1) As Integer ' 100 by 2 elements array
    Dim NumberOfJobs As Integer ' Number of jobs

    ' PART_B: Function to initialize the Jobs array and NumberOfJobs
    Sub Initialise()
        For x As Integer = 0 To 99
            Jobs(x, 0) = -1
            Jobs(x, 1) = -1
        Next
        NumberOfJobs = 0
    End Sub

    ' PART_C: Function to add a job to the Jobs array
    Sub AddJob(JobNumber As Integer, Priority As Integer)
        If NumberOfJobs = 100 Then
            Console.WriteLine("Not added")
        Else
            Jobs(NumberOfJobs, 0) = JobNumber
            Jobs(NumberOfJobs, 1) = Priority
            Console.WriteLine("Added")
            NumberOfJobs += 1
        End If
    End Sub

    ' PART_D: Initializing and adding jobs
    Initialise()
    AddJob(12, 10)
    AddJob(526, 9)
    AddJob(33, 8)
    AddJob(12, 9)
    AddJob(78, 1)

    ' PART_E: Function to perform insertion sort on Jobs array based on priority
    Sub InsertionSort()
        For I As Integer = 1 To NumberOfJobs - 1
            Dim Current1 As Integer = Jobs(I, 0)
            Dim Current2 As Integer = Jobs(I, 1)
            Dim J As Integer = I
            While J > 0 AndAlso Jobs(J - 1, 1) > Current2
                Jobs(J, 0) = Jobs(J - 1, 0)
                Jobs(J, 1) = Jobs(J - 1, 1)
                J -= 1
            End While
            Jobs(J, 0) = Current1
            Jobs(J, 1) = Current2
        Next
    End Sub

    ' PART_F: Function to print the Jobs array
    Sub PrintArray()
        For X As Integer = 0 To NumberOfJobs - 1
            Console.WriteLine(Jobs(X, 0) & " priority " & Jobs(X, 1))
        Next
    End Sub

    ' PART_G-1: Sorting and printing the Jobs array
    InsertionSort()
    PrintArray()

    ' PART_G-2: Example usage
    '''
    Added
    Added
    Added
    Added
    Added
    78 priority 1
    33 priority 8
    526 priority 9
    12 priority 9
    12 priority 10
    '''
End Module
