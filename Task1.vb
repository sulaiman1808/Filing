Module Module1

    Sub Main()

        Dim MemberName As String
        Dim ID As Integer
        Dim AddMore As Char

        UCase(AddMore = "N")
        MemberName = ""
        ID = 0
        AddMore = ""

        FileOpen(1, "D:\Assignment.txt", OpenMode.Output)
        Do
            Console.Write("Enter Member Name: ")
            MemberName = Console.ReadLine()

            Console.Write("Enter Member ID: ")
            ID = Console.ReadLine()

            Console.WriteLine()

            WriteLine(1, MemberName)
            WriteLine(1, ID)

            Console.Write("Do you want to add more?(Y/N): ")
            AddMore = Console.ReadLine()

        Loop Until (AddMore = "N" Or AddMore = "n")
        FileClose(1)

    End Sub

End Module