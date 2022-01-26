Option Strict On
Option Explicit On
Option Compare Text

Module Module1

    Sub Main()
        Dim userName As String
        Dim userResponse As String
        Console.WriteLine("What's your name?")
        userName = Console.ReadLine()

        Select Case userName
            Case = "Emily"
                Console.WriteLine("Wait, like Emily from 2nd grade??? ")
                userResponse = Console.ReadLine
                Select Case userResponse
                    Case "Yes"
                        Console.WriteLine("OMG I HAVEN'T SEEN YOU IN FOREVER!!! I dont like you so I'm ending this conversation before I have to code more")

                End Select
            Case = "Joe"
                Console.WriteLine("")
        End Select


    End Sub

End Module
