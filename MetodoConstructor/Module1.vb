Module Module1

    Sub Main()
        'Los metodos constructores sirven para darle un estado inicial
        'al objeto creado. Eso lo logramos cuando realizamos la instancia
        'de una clase.

        Dim Sams As AireAcondicionado = New AireAcondicionado("Freezer", "blanco", 220, 18000)

        Console.WriteLine(Sams.marca)
        Console.WriteLine(Sams.modelo)
        Console.WriteLine(Sams.color)
        Console.WriteLine(Sams.voltaje)
        Console.WriteLine(Sams.btu)
        Console.WriteLine(Sams.temperatura)
        Console.ReadKey()

    End Sub

End Module
