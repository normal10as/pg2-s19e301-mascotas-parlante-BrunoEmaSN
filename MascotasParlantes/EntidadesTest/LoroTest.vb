Imports Entidades

Module LoroTest
    Sub Loro()
        Dim loro1 As New Loro()
        Console.WriteLine("Nombre: " & loro1.Nombre)
        Console.WriteLine("Edad: " & loro1.Edad)
        Console.WriteLine("Fecha de Nacimiente: " & loro1.FechaNacimiento)
        loro1.Nombre = "PEPE"
        loro1.FechaNacimiento = Date.Today
        Console.WriteLine("Nombre: " & loro1.Nombre)
        Console.WriteLine("Edad: " & loro1.Edad)
        Console.WriteLine("Fecha de Nacimiente: " & loro1.FechaNacimiento)
        loro1.Escuchar("Papita")
        loro1.Escuchar("pa el loro ")
        loro1.Escuchar("Juan")
        For index = 1 To 4
            Console.WriteLine(loro1.Hablar)
        Next
    End Sub
End Module
