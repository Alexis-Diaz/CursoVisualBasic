Module Module1

    Sub Main()

        'Aplicacion de polimorfismo utilizando la herencia
        'En este ejemplo la herencia se da en el siguiente orden
        'Persona -> Estudiante -> Universitario -> EstudiantePosgrado
        'Estudiante contiene un método que puede anularse y es heredado
        'a las demas clases quienes lo sobreescriben segun la necesidad.
        '
        'Ejemplo de como la clase Estudiante se comporta
        'de diferentes formas:

        'Array de estudiantes
        Dim estudiantes(2) As Estudiante

        estudiantes(0) = New Estudiante("Jhon", "CC", "calle tal numero tal", "22222222", False)
        estudiantes(1) = New Universitario("Maria", "CC", "calle tal numero tal", "22222222", False, "Medicina")
        estudiantes(2) = New EstudiantePosgrado("Pedro", "CC", "calle tal numero tal", "22222222", False, "Especialista en desarrollo de software")

        'recorrido del array
        For Each estudiante In estudiantes
            estudiante.darDescripcionEstudiante()
        Next

        Console.ReadKey()
    End Sub

End Module
