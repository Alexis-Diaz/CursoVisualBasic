Module Module1

    Sub Main()

        'Los array de objetos son como cualquier otros array pero a diferencia de usar
        'datos primitivos usamos objetos. A continuacion Se crea un array de la clase Persona
        'con una cantidad de 3 elementos. Como el cero cuenta, entre paréntesis
        'se escribe 2

        Dim personas(2) As Persona
        Dim nombre As String
        Dim apellido As String
        'Creación de los objetos
        For i = 0 To personas.Length - 1 Step 1

            Console.WriteLine("Ingrese el nombre de la " & i + 1 & "º persona")
            nombre = Console.ReadLine

            Console.WriteLine("Ingrese el apellido de la " & i + 1 & "º persona")
            apellido = Console.ReadLine

            Dim persona As Persona = New Persona()
            persona.NombrePersona = nombre
            persona.ApellidoPersona = apellido
            personas(i) = persona

        Next

        Console.WriteLine()

        'Lectura del array
        For Each persona As Persona In personas
            Console.WriteLine(persona.NombrePersona)
        Next

        Console.ReadKey()

    End Sub

End Module
