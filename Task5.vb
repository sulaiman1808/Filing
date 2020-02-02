Module Module1

    Sub Main()
        Dim MemberName As String = ""
        Dim ID As String = ""
        Dim TelephoneNumber As String = ""
        Dim Address As String = ""

        FileOpen(1, "D:\Assignment.txt", OpenMode.Input)
        FileOpen(2, "D:\SecondFile.txt", OpenMode.Append)

        While Not EOF(1)
            Input(1, MemberName)
            Input(1, ID)

            Console.WriteLine("Member Name: " & MemberName)
            Console.WriteLine("Member ID: " & ID)

            Console.Write("Enter Telephone Number: ")
            TelephoneNumber = Console.ReadLine()

            Console.Write("Enter Address: ")
            Address = Console.ReadLine
            Console.WriteLine()

            WriteLine(2, MemberName)
            WriteLine(2, ID)
            WriteLine(2, TelephoneNumber)
            WriteLine(2, Address)

        End While
        FileClose(1)
        FileClose(2)
    End Sub

End Module
