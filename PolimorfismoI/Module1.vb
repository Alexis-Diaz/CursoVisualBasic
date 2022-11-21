Module Module1

    Sub Main()
        'Ejemplo de como un objeto de tipo Animal puede
        'comportarse como un Mamifero, Ave o
        'Pez
        Dim caballo As Animal = New Mamiferos()
        caballo.grupoAnimal = "mamifero"
        imprimirValores(caballo)

        Dim perico As Animal = New Aves()
        perico.grupoAnimal = "ave"
        imprimirValores(perico)

        Dim chimbolo As Peces = New Peces()
        chimbolo.grupoAnimal = "pez"
        imprimirValores(chimbolo)
        Console.WriteLine(chimbolo.Comer())

        Console.ReadKey()

    End Sub

    Private Sub imprimirValores(ByVal animal As Animal)
        Console.WriteLine(animal.moverse())
        'Console.WriteLine(animal.comer())
        Console.WriteLine()
    End Sub

End Module
