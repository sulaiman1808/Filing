Module Module1

    Sub Main()
        Dim MemberName As String
        Dim ID As Integer

        MemberName = ""
        ID = 0

        FileOpen(1, "D:\Assignment.txt", OpenMode.Input)

        While Not EOF(1)

            Input(1, MemberName)
            Input(1, ID)

            Console.WriteLine(MemberName)
            Console.WriteLine(ID)
            Console.WriteLine()

        End While

        FileClose(1)
        Console.ReadKey()

    End Sub

End Module