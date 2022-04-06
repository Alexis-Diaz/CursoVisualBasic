Module Module1

    Sub Main()

        'Declaracion de un array
        'Lo que va entre parentesis es el numero de elementos que contendra

        '1 Forma: inicializando el array
        Dim arrayNombres(6) As String

        'ASIGNAR VALORES

        '1 Forma: desde la declaracion
        Dim arrayApellidos = New String() {"Franco", "Lue", "Martinez", "Cordova"}

        '2 Forma: usando un bucle y asignado valores por medio de su indice
        'For i = 0 To arrayNombres.Length - 1 Step 1
        '    Console.WriteLine("Ingrese el valor de la posicion " & i & "==>")
        '    arrayNombres(i) = Console.ReadLine()
        'Next

        '3 Forma: sin usar bucle y asignando valores por medio de su indice
        arrayApellidos(0) = "Rivera"
        arrayApellidos(1) = "Hernandez"
        arrayApellidos(2) = "Samayoa"
        arrayApellidos(3) = "Ortiz"

        'ACCEDER A SUS VALORES
        Console.WriteLine(arrayApellidos(2)) 'salida Samayoa

        Dim apellido As String = arrayApellidos(3) 'almacenamos en una variable el apellido Ortiz
        Console.WriteLine(apellido) 'salida Samayoa



        'RECORRIDO DE ARRAY
        'Usando for
        Console.WriteLine()
        Console.WriteLine("for")

        For i = 0 To arrayApellidos.Length - 1 Step 1
            Console.WriteLine(arrayApellidos(i))
        Next


        'Usando foreach
        Console.WriteLine()
        Console.WriteLine("for each")

        For Each item As String In arrayApellidos
            Console.WriteLine(item)

        Next

    End Sub

End Module
