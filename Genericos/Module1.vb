Module Module1

    Sub Main()
        'Creacion de un variable de tipo object, que es la clase base de los
        'objetos.

        Dim general As Object = "osmin alexis"

        Console.WriteLine(general)



        'Cuando usamos object es que si almacenamos otro objeto derivado de una
        'clase que hayamos creado, no podremos usar sus metodos pues primero 
        'tendremos que realizar un casting. Ejemplo:

        'Nota: al realizar la prueba me entero que si funciona sin necesidad de un casting, de lo que
        'me doy cuenta es que el asistente intelligent no detecta los metodos que tiene el objeto. Por 
        'lo que es dificil detectar si existen un error ya que se mostrará en tiempo de ejecución.

        Dim person As Object = New Persona("Alexis", "8383")
        Console.WriteLine(person.getNombres)

        'Realizando casting

        Dim personCasting As Persona = TryCast(person, Persona)
        Console.WriteLine(personCasting.getNombres)



        'La ventaja de los genericos es que podremos detectar los errores en tiempo de ejecucion
        Dim general2 As New ObjetosGenericos(Of Persona)
        general2.ElObjeto = New Persona("Osmin", "934")
        Console.WriteLine(general2.ElObjeto.getNombres)

    End Sub

End Module
