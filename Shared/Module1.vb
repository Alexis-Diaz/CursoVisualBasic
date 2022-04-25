Module Module1

    Sub Main()
        'Al crear dos instancias de la clase Estudiante, el constructor
        'aumenta en 1 la variable o atributo codigo, como este es una
        'variable estatica su valor se comparte y es el mismo para todas
        'las instancias.

        Dim estudiante1 As Estudiante = New Estudiante("Alexis Diaz")

        Dim estudiante2 As Estudiante = New Estudiante("Osmin Lue")

        Dim estudiante3 As Estudiante = New Estudiante("Adalberto Lue")

        Console.WriteLine(estudiante1.getCodigoEstudiante)
        Console.WriteLine(estudiante2.getCodigoEstudiante)
        Console.WriteLine(estudiante3.getCodigoEstudiante)


        Console.WriteLine(Math.Pow(5, 3))
        Console.WriteLine(Matematica.potenciacion(5, 3))
    End Sub

End Module
