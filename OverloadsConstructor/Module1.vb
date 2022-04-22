Module Module1

    Sub Main()
        'Los metodos constructores sirven para darle un estado inicial
        'al objeto creado. Eso lo logramos cuando realizamos la instancia
        'de una clase.

        'Por la cantidad de parametros se especifica que metodo constructor
        'sobrecargado se utilizara para darle el estado inicial al objeto.

        Dim Sams1 As AireAcondicionado = New AireAcondicionado("Freezer", "blanco", 220, 18000)
        Dim Sams2 As AireAcondicionado = New AireAcondicionado("Freezer", "blanco")

        Console.WriteLine(Sams1.marca)
        Console.WriteLine(Sams1.modelo)
        Console.WriteLine(Sams1.color)
        Console.WriteLine(Sams1.voltaje)
        Console.WriteLine(Sams1.btu)
        Console.WriteLine(Sams1.temperatura)
        Console.WriteLine()
        Console.WriteLine(Sams2.marca)
        Console.WriteLine(Sams2.modelo)
        Console.WriteLine(Sams2.color)
        Console.WriteLine(Sams2.voltaje)
        Console.WriteLine(Sams2.btu)
        Console.WriteLine(Sams2.temperatura)
        Console.ReadKey()
    End Sub

End Module
