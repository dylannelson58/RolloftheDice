Module RolloftheDice

    Sub Main()
        Dim randomNumbers(10) As Integer
        Dim header As Integer
        Dim result As Integer

        For i = 0 To 1000
            result = GetRandomNumber(5) + GetSecondRandomNumber(5)
            randomNumbers(result) += 1

            'does not work
        Next

        header = CInt((77 - 16) / 2)
        Console.WriteLine(StrDup(header, " ") & "Roll of the Dice" & StrDup(header, " "))
        Console.WriteLine(StrDup(77, "-"))

        For i = 2 To 12
            Console.Write(Str(i).PadLeft(6) & "|")
        Next
        Console.WriteLine()

        Console.WriteLine(StrDup(77, "-"))

        For i = 0 To UBound(randomNumbers)
            Console.Write(CStr(randomNumbers(i)).PadLeft(6) & "|")
        Next
        Console.Read()
    End Sub
    Private Function GetRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function

    Private Function GetSecondRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function
End Module
