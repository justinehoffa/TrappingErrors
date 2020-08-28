Option Strict On
Option Explicit On
Option Compare Binary


Module TrappingErrors

    Sub Main()

        Dim userInput As String
        Dim userNumber As Integer
        Console.WriteLine("Type a number and press enter.  Enter Q to quit.")

        Do

            userInput$ = Console.ReadLine()

            Try
                'convert user input from string to integer
                userNumber% = CInt(userInput$)
                Console.WriteLine(userInput & " + 5 =")
                Console.WriteLine(userNumber% + 5)
            Catch ex As InvalidCastException
                Console.WriteLine("I asked for a number...You entered: " & userInput)
            Catch ex As Exception
                Console.WriteLine("You broke it!!!")
                Console.WriteLine(ex.Message)
            Finally
                'always runs 
            End Try

        Loop Until userInput$ = "Q" Or userInput$ = "q"



        'Console.ReadLine()


    End Sub

End Module
