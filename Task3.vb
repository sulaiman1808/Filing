Module Module1

    Sub Main()

        Dim MemberName As String
        Dim ID As Integer
        Dim SearchName As String
        Dim Found As Boolean

        MemberName = ""
        ID = 0
        SearchName = ""
        Found = False

        Console.Write("Enter Member Name To Search For: ")
        SearchName = Console.ReadLine()

        FileOpen(1, "D:\Assignment.txt", OpenMode.Input)

        While Not EOF(1)

            Input(1, MemberName)
            Input(1, ID)

            If UCase(SearchName) = UCase(MemberName) Then
                Found = True
                Console.WriteLine("Member Name:" & MemberName)
                Console.WriteLine("Member ID: " & ID)
                Exit While
            End If
        End While

        FileClose(1)

        If Found = False Then
            Console.Write("RECORD NOT FOUND!!")
        End If

        Console.ReadKey()
    End Sub

End Module