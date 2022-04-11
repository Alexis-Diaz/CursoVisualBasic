Module Module1

    Sub Main()

        'Creacion de un lista
        Console.WriteLine("Creacion de una lista")
        Dim miLista As New List(Of Integer)

        'Se agregan elementos a la lista con el metodo Add
        miLista.Add(48)
        miLista.Add(30)
        miLista.Add(120)
        miLista.Add(92)

        'Recorrido de la lista con el bucle For
        For i = 0 To miLista.Count - 1 Step 1
            Console.WriteLine(miLista(i))
        Next

        Console.WriteLine()

        'Recorrido de la lista con el bucle For Each
        For Each item As Integer In miLista
            Console.WriteLine(item)
        Next



        'Copia de una lista a un Array
        Console.WriteLine()
        Console.WriteLine("Copia de lista en Array")

        Dim copiaLista() As Integer = miLista.ToArray

        For Each item As Integer In copiaLista

            Console.WriteLine(item)
        Next

        'Eliminacion de todos los elementos de la lista
        Console.WriteLine("Se eliminan los elementos de la lista")
        miLista.Clear()

        For i = 0 To miLista.Count - 1 Step 1
            Console.WriteLine(miLista(i))
        Next


    End Sub

End Module
