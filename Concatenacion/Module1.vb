Module Module1

    Sub Main()
        'Para realizar una concatenacion de cadenas se usa el simbolo "&"
        'pero tambien se puede usar el operador "+". Ejemplo:

        Console.WriteLine("Escribe tu mascota favorita:")
        Dim mascota As String = Console.ReadLine()

        'Usando "&"
        Console.WriteLine("Tu mascota favorita es: " & mascota)

        'Usando "+"
        Console.WriteLine("El tipo de mascota preferida es: " + mascota)

    End Sub

End Module
