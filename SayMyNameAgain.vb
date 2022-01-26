Option Strict On
Option Explicit On
Option Compare Text

Module SayMyNameAgain

    Sub Main()
        Dim userName As String
        Dim userResponse As String
        Do
            Console.WriteLine("What's your name?")
            userName = Console.ReadLine()

            Select Case userName
                Case = "Emily"
                    Console.WriteLine("Wait, like Emily from 2nd grade??? ")
                    userResponse = Console.ReadLine
                    Select Case userResponse
                        Case "Yes"
                            Console.WriteLine("OMG I HAVEN'T SEEN YOU IN FOREVER!!! I dont like you so I'm ending this conversation before I have to code more")
                        Case "No"
                            Console.WriteLine("OOPS sorry I thought you were someone else.")
                        Case Else
                            Console.WriteLine("That's not an answer to my question, but I guess I'll just ask your name again")
                    End Select

                Case = "Joe"
                    Console.WriteLine("Oh hey Joe")

                Case = "Morgan"
                    Console.WriteLine("Now that is a nice name!!!")

                Case Else
                    Console.WriteLine("Finally a different name, I'm so sick of Emily and Joe, don't even get me started on Morgan")
            End Select
            Console.WriteLine("Now before I forget...")
        Loop Until userName = "Q"

    End Sub

End Module
