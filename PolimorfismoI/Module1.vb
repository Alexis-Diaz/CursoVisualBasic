Module Module1

    Sub Main()

        Dim caballo As Animal = New Mamiferos()
        caballo.grupoAnimal = "mamifero"
        IniciarJuego(caballo)

        Dim perico As Animal = New Aves()
        perico.grupoAnimal = "ave"
        IniciarJuego(perico)

        Dim chimbolo As Peces = New Peces()
        chimbolo.grupoAnimal = "pez"
        IniciarJuego(chimbolo)
        Console.WriteLine(chimbolo.moverse())
        Console.WriteLine(chimbolo.Comer())

        Console.ReadKey()

    End Sub

    Private Sub IniciarJuego(ByVal animal As Animal)
        Console.WriteLine(animal.moverse())
        'Console.WriteLine(animal.comer())
        Console.WriteLine()
    End Sub

End Module
