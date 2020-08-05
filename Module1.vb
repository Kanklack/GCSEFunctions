Module Module1

    Function addTwoInts(number1 As Integer, number2 As Integer)

        Dim Result As Integer = number1 + number2

        Return Result

    End Function

    Function minusTwoInts(number1 As Integer, number2 As Integer)

        Dim Result As Integer = number1 - number2

        Return Result

    End Function

    Function averageThreeInts(number1 As Integer, number2 As Integer, number3 As Integer)

        Dim Result As Integer = number1 + number2 + number3

        Result = Result / 3

        Return Result

    End Function


    Function divideTwoInts(number1 As Integer, number2 As Integer)

        Dim Result As Integer = number1 + number2

        Result = Result / 2

        Return Result
    End Function

    Function multiplyTwoInts(number1 As Integer, number2 As Integer)

        Dim Result As Integer = number1 + number2

        Result = Result * 2

        Return Result
    End Function

    Function cms2inches(metric As Decimal)

        Dim conversionFactor As Decimal = 2.54

        Dim inches As Decimal = metric / conversionFactor

        Return inches

    End Function

    Sub Menu()

        Dim Choice As String

        Console.WriteLine("Please select a menu choice from 1 to 4 or type 'Q' to quit the program.")

        Choice = Console.ReadLine()

        While Choice <> "Q"

            Select Case Choice

                Case "1"

                    MenuChoice1()

                Case "2"

                    MenuChoice2()

                Case "3"

                    MenuChoice3()

                Case "4"

                    MenuChoice4()

                Case Else

                    Console.WriteLine("Invalid input.....")

                    Menu()

            End Select

        End While

    End Sub



    Sub MenuChoice1()

        Console.WriteLine("You have chosen menu choice 1... Press return to return to the main menu.")

        Console.ReadLine()

        Menu()

    End Sub



    Sub MenuChoice2()

        Console.WriteLine("You have chosen menu choice 2... Press return to return to the main menu.")

        Console.ReadLine()

        Menu()

    End Sub



    Sub MenuChoice3()

        Console.WriteLine("You have chosen menu choice 3... Press return to return to the main menu.")

        Console.ReadLine()

        Menu()

    End Sub



    Sub MenuChoice4()

        Console.WriteLine("You have chosen menu choice 4... Press return to return to the main menu.")

        Console.ReadLine()

        Menu()



    End Sub
    Sub welcome()

        Console.WriteLine("Welcome...")

    End Sub

    Sub Main()

        'Calls Menu and outputs menu

        Menu()

        ' Calls welcome() and outputs the welcome message

        welcome()

        ' Collects user input, calls addTwoInts passing in the two numbers to addTwoInts() then outputs the result

        Console.WriteLine("----------------------")
        Console.WriteLine("addTwoInts")
        Console.WriteLine("----------------------")
        Console.WriteLine("Please enter your first number...")

        Dim userNumber1 As Integer = Console.ReadLine()

        Console.WriteLine("Please enter your second number...")

        Dim userNumber2 As Integer = Console.ReadLine()

        Dim answer As Integer = addTwoInts(userNumber1, userNumber2)

        Console.WriteLine("Your answer is: " & answer)

        ' --------------

        ' Collects three numbers from the user passing in to the averageThreeInts function gets the result back and then outputs them to the screen

        Console.WriteLine("----------------------")
        Console.WriteLine("averageThreeInts")
        Console.WriteLine("----------------------")
        Console.WriteLine("Please enter your first number...")

        userNumber1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Please enter your second number...")

        userNumber2 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Please enter your third number...")

        Dim userNumber3 As Integer = Console.ReadLine()

        answer = averageThreeInts(userNumber1, userNumber2, userNumber3)

        Console.WriteLine("Your answer is: " & answer)

        ' ---------------
        'Collects  two numbers from the user passing in to the minusTwoInts function gets the result back and then outputs them to the screen

        Console.WriteLine("----------------------")
        Console.WriteLine("minusTwoInts")
        Console.WriteLine("----------------------")
        Console.WriteLine("Please enter your first number...")

        userNumber1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Please enter your second number...")

        userNumber2 = Convert.ToInt32(Console.ReadLine())

        answer = minusTwoInts(userNumber1, userNumber2)

        Console.WriteLine("Your answer is: " & answer)

        ' --------------
        ' Collects  two numbers from the user passing in to the divideTwoInts function gets the result back and then outputs them to the screen

        Console.WriteLine("----------------------")
        Console.WriteLine("divideTwoInts")
        Console.WriteLine("----------------------")
        Console.WriteLine("Please enter your first number...")

        userNumber1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Please enter your second number...")

        userNumber2 = Convert.ToInt32(Console.ReadLine())

        answer = divideTwoInts(userNumber1, userNumber2)

        Console.WriteLine("Your answer is: " & answer)

        ' --------------
        ' Collects  two numbers from the user passing in to the multiplyTwoInts function gets the result back and then outputs them to the screen

        Console.WriteLine("----------------------")
        Console.WriteLine("multiplyTwoInts")
        Console.WriteLine("----------------------")
        Console.WriteLine("Please enter your first number...")

        userNumber1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Please enter your second number...")

        userNumber2 = Convert.ToInt32(Console.ReadLine())

        answer = multiplyTwoInts(userNumber1, userNumber2)

        Console.WriteLine("Your answer is: " & answer)

        ' --------------
        ' Taking an integer representing centimeters and converting to inches before returning the value.
        Console.WriteLine("----------------------")
        Console.WriteLine("cms2inches")
        Console.WriteLine("----------------------")

        Console.WriteLine("Enter your height in centimetres: ")
        Dim height1 As Decimal = Console.ReadLine
        Dim heightanswer As Decimal = cms2inches(height1)
        Console.WriteLine("Your height in inches is: " & cms2inches(height1))

        Console.Read()

    End Sub

End Module
