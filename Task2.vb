Module Module1

    Sub Main()

        Dim MemberName As String = ""
        Dim MemberID As String = ""

        FileOpen(1, "C:\Users\MSA\Desktop\Muhammad Sulaiman\A Levels\Computer Science\ABC.txt", OpenMode.Input)

        While Not EOF(1)

            Input(1, MemberName)
            Input(1, MemberID)

            Console.WriteLine("Member Name:" & MemberName)
            Console.WriteLine("Member ID:" & MemberID)

        End While
        Console.ReadKey()
        FileClose(1)


    End Sub

End Module
