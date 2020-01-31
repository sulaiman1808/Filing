Module Module1

    Sub Main()

        Dim MemberName As String = ""
        Dim MemberID As String = ""
        Dim AddMore As Char = "Y"

        FileOpen(1, "ABC.txt", OpenMode.Output)

        While UCase(AddMore) = "Y"

            Console.Write("Enter Member Name: ")
            MemberName = Console.ReadLine

            Console.Write("Enter Member ID: ")
            MemberID = Console.ReadLine

            WriteLine(1, MemberName)
            WriteLine(1, MemberID)

            Console.Write("Do You Want To Add More Records?(Y/N)")
            AddMore = Console.ReadLine

        End While

        Console.ReadKey()
        FileClose(1)

    End Sub

End Module
