Imports Entidades

Module CotorraTest
    Sub Cotorra()
        Dim cotorra1 As New Cotorra()
        Console.WriteLine("Nombre: " & cotorra1.Nombre)
        Console.WriteLine("Edad: " & cotorra1.EdadHumana)
        Console.WriteLine("Fecha de Nacimiente: " & cotorra1.FechaNacimiento)
        cotorra1.Nombre = "PEPE"
        cotorra1.FechaNacimiento = Date.Today
        Console.WriteLine("Nombre: " & cotorra1.Nombre)
        Console.WriteLine("Edad: " & cotorra1.EdadHumana)
        Console.WriteLine("Fecha de Nacimiente: " & cotorra1.FechaNacimiento)
        cotorra1.Escuchar("Papita ")
        cotorra1.Escuchar("pa el loro ")
        cotorra1.Escuchar("Juan ")
        cotorra1.Escuchar("Juan")
        For index = 1 To 4
            Console.WriteLine(cotorra1.Hablar)
        Next
    End Sub
End Module
