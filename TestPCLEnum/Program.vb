Imports LibraryClass


Module Program

    Sub Main()

        Dim erreur As ErreurEnum = ErreurEnum.IsBlockRight

        Console.WriteLine(erreur)

        Console.WriteLine(erreur.GetEnumDescription())

        Console.ReadKey()

    End Sub

End Module

