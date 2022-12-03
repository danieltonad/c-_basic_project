Module Module1

    Sub Main()
        Console.WriteLine("Enter Number")
        Dim no As Integer = CInt(Console.ReadLine())
        Console.WriteLine("Reverse of {0} is : ", no)
        While no > 0
            Console.Write(no Mod 10)
            no = Math.Floor(no / 10)
        End While
        Console.ReadKey()


    End Sub

End Module
