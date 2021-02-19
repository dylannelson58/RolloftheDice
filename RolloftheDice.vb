Option Strict On
Option Explicit On

'Dylan Nelson
'RCET0265
'Spring 2021
'Roll of the Dice
'https://github.com/dylannelson58/RolloftheDice

Module RolloftheDice

    Sub Main()
        Dim randomNumbers(10) As Integer                                                            '2-12 is ten integers this is the range used for the dice rolls
        Dim header As Integer                                                                       'header is formatting to show the "roll of the dice" name
        Dim result As Integer                                                                       'result is the variable of the sum of the two random numbers

        For i = 0 To 1000                                                                           'executes 1000 rolls of the two dice
            result = GetRandomNumber(5) + GetSecondRandomNumber(5)                                  'adds the two functions into a variable that can be called later
            randomNumbers(result) += 1                                                              'adds 1 to the formatting ensuring that 0-1 is never recorded
        Next

        header = CInt((77 - 16) / 2)                                                                '77 because that is the amount of "-"s used 16 is the length of "roll of the dice" phrase /2 to center the header
        Console.WriteLine(StrDup(header, " ") & "Roll of the Dice" & StrDup(header, " "))           'Applying the header variable to the "roll of the dice"
        Console.WriteLine(StrDup(77, "-"))                                                          'Adding dashes to format

        For i = 2 To 12                                                                             '2-12 is the combinations of possible dice sum outcomes 
            Console.Write(Str(i).PadLeft(6) & "|")                                                  'More formatting
        Next                                                                                        'ends the for loop
        Console.WriteLine()                                                                         'ends the line

        Console.WriteLine(StrDup(77, "-"))                                                          'more formatting

        For i = 0 To UBound(randomNumbers)                                                          'sets the values to be between 0 and the upper end value of randomNumbers
            Console.Write(CStr(randomNumbers(i)).PadLeft(6) & "|")                                  'Formatting
        Next                                                                                        'leaves for loop
        Console.Read()                                                                              'reads out all the code that has been written to the console
    End Sub
    Private Function GetRandomNumber(maxNumber As Integer) As Integer                               'function to get a random number for 2-12
        Randomize(DateTime.Now.Millisecond)                                                         'randomizes the number down to the current milisecond
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))                                            'returns a random number equal to or less than the maxNumber + 1
    End Function                                                                                    'ends function

    Private Function GetSecondRandomNumber(maxNumber As Integer) As Integer                         'function to get a random number for 2-12
        Randomize(DateTime.Now.Millisecond)                                                         'randomizes the number down to the current milisecond
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))                                            'returns a random number equal to or less than the maxNumber + 1
    End Function                                                                                    'ends Function
End Module                                                                                          'end of whole code
