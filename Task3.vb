Module Module1

    Sub Main()
        Dim MemberName, MemberID, SearchName As String
        Dim isFound As Boolean

        MemberName = ""
        MemberID = ""
        SearchName = ""
        isFound = True

        Console.Write("Enter Member Name to search for: ")
        SearchName = Console.ReadLine()

        FileOpen(1, "C:\Users\MSA\Desktop\Muhammad Sulaiman\A Levels\Computer Science\ABC.txt", OpenMode.Input)

        While Not EOF(1)
            MemberName = LineInput(1)
            Input(1, MemberID)

            If MemberName = SearchName Then
                isFound = True
                Console.WriteLine("Enter MemberID: " & MemberID)
                Console.WriteLine()
            End If
        End While
        FileClose(1)

        If Not isFound Then
            Console.WriteLine("Record couldn't be found...")
        End If
        Console.ReadKey()
    End Sub

End Module
