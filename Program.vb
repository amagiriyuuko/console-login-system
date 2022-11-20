Module Program
    Sub Main(args As String())
        Dim username, pin As String
        Dim ctr As Integer

        ctr = 3

        Do

            Console.Write("USERNAME: ")
            username = Console.ReadLine
            Console.Write("PIN: ")
            pin = Console.ReadLine

            If (username.Equals("caguntas")) Or (username.Equals("Caguntas")) Or (username.Equals("CAGUNTAS")) Then
                If (pin.Equals("1234")) Then
                    Console.Clear()
                    Console.WriteLine("Congratulations, " & username & ", you're in!")
                    Console.WriteLine("=============================================")
                    GoTo line2
                Else
                    ctr -= 1
                    Console.Clear()
                    Console.WriteLine("Sorry. Please try again. Attempts remaining: " & ctr)
                    Console.WriteLine("=============================================")
                End If

            ElseIf (username.Equals("pacis")) Or (username.Equals("Pacis")) Or (username.Equals("PACIS")) Then
                If (pin.Equals("4321")) Then
                    Console.Clear()
                    Console.WriteLine("Congratulations, " & username & ", you're in!")
                    Console.WriteLine("=============================================")
                    GoTo line2
                Else
                    ctr -= 1
                    Console.Clear()
                    Console.WriteLine("Sorry. Please try again. Attempts remaining: " & ctr)
                    Console.WriteLine("=============================================")
                End If

            ElseIf (username.Equals("ederlyn")) Or (username.Equals("Ederlyn")) Or (username.Equals("EDERLYN")) Then
                If (pin.Equals("2341")) Then
                    Console.Clear()
                    Console.WriteLine("Congratulations, " & username & ", you're in!")
                    Console.WriteLine("=============================================")
                    GoTo line2
                Else
                    ctr -= 1
                    Console.Clear()
                    Console.WriteLine("Sorry. Please try again. Attempts remaining: " & ctr)
                    Console.WriteLine("=============================================")
                End If

            ElseIf (username.Equals("aleph")) Or (username.Equals("Aleph")) Or (username.Equals("ALEPH")) Then
                If (pin.Equals("2341")) Then
                    Console.Clear()
                    Console.WriteLine("Congratulations, " & username & ", you're in!")
                    Console.WriteLine("=============================================")
                Else
                    ctr -= 1
                    Console.Clear()
                    Console.WriteLine("Sorry. Please try again. Attempts remaining: " & ctr)
                    Console.WriteLine("=============================================")
                End If

            Else
                Console.Clear()
                Console.WriteLine("Sorry. Please try again. Attempts remaining: " & ctr)
                Console.WriteLine("=============================================")
            End If
        Loop Until (ctr = 0)

        If (ctr = 0) Then
            Console.Clear()
            GoTo line1
        End If

line1:
        Console.WriteLine("You've been locked out due to multiple attempts.")
        Console.WriteLine("System is closing...")
        Console.WriteLine()

line2:
        Console.ReadKey()
    End Sub
End Module
