Imports Entidades
Module JaulaTest
    Sub Jaula()
        Dim jaula1 As New Jaula()
        Dim loro1 As New Loro()
        Dim cotorra1 As New Cotorra()
        Dim cotorra2 As New Cotorra()
        Dim cotorra3 As New Cotorra()
        Dim cotorra4 As New Cotorra()
        jaula1.Nombre = "Spira"

        loro1.Nombre = "Tidos"

        loro1.FechaNacimiento = #07-19-2001#

        jaula1.Loro = loro1

        Console.WriteLine(jaula1.ToString())
        Console.WriteLine("Loro: " & jaula1.Loro.ToString)

        cotorra1.Nombre = "Rikku"
        cotorra2.Nombre = "Wakka"
        cotorra3.Nombre = "Lulu"
        cotorra4.Nombre = "Yuna"

        jaula1.AddCotorra(cotorra1)
        jaula1.AddCotorra(cotorra2)
        jaula1.AddCotorra(cotorra3)
        jaula1.AddCotorra(cotorra4)
        mostrarCotorras(jaula1)
    End Sub

    Sub mostrarCotorras(jaula As Jaula)
        For Each item In jaula.GetAllCotorras()
            Console.Write("Cotorra: ")
            Console.WriteLine(item)
        Next
    End Sub
End Module
