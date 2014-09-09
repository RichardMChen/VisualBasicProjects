Module Module1

    Public Sub FindPrimeNum(ByVal num As Integer)
        Dim i, j As Integer  'Integer 'i' is used for counter of outer loop and 'j' is the counter for inner loop.
        Dim isPrime As Boolean

        For i = 2 To num Step 1  'Starts at the first prime number of 2 and continues by 1 to the user's number
            isPrime = True
            For j = 2 To (i - 1) Step 1  'Starting at 2 then continues by 1 all the way up to the current iteration of the loop

                ' i is modded by j all the way until j equals i. It mods every number starting from 2 all the way up to the current 'i' and
                ' if there is ever a mod that results in a 0 then it is not a prime and the innermost for loop is exited.
                If (i Mod j = 0) Then
                    isPrime = False
                    Exit For
                End If
            Next

            'If (j > (i \ j)) Then
            If (isPrime = True) Then
                Console.WriteLine(j)
            End If
        Next
    End Sub


    Sub Main()
        Dim maxNum As Integer  'Integer to hold the number the user wants to find prime numbers up until.

        'Asks the user to enter their number and then start to display the prime numbers.
        Console.Write("Enter the number you want to find prime number up until: ")
        maxNum = Console.ReadLine()
        Console.WriteLine("Prime numbers up until " & maxNum)

        FindPrimeNum(maxNum)  'Call the sub to find and print the prime numbers.

        Console.ReadLine()
    End Sub

End Module
