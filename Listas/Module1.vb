Module Module1

    Sub Main()

        'LISTAS CON TIPOS PRIMITIVOS

        'Declaracion de una lista de string y adición de elementos
        'con el método Add. Se muestra la manera completa y simplificada
        'para realizar la declaración.

        Dim _miLista1 As List(Of String) = New List(Of String)
        _miLista1.Add("Peras")
        _miLista1.Add("Zapatos")
        _miLista1.Add("Perfume")


        Dim miLista1 As New List(Of String)
        miLista1.Add("Peras")
        miLista1.Add("Zapatos")
        miLista1.Add("Perfume")







        'Declaración y asignación de los elementos de la lista. Se 
        'muestra la manera completa y simplificada para realizar
        'la declaración.

        Dim _miLista2 As List(Of String) = New List(Of String) From {"Ventilador", "Carne", "Cepillo"}

        Dim miLista2 As List(Of String) = New List(Of String) From {
            "Ventilador",
            "Carne",
            "Cepillo"
        }


        Dim _miLista3 As New List(Of Integer) From {23, 34, 56, 67}

        Dim miLista3 As New List(Of Integer) From {
            23,
            34,
            56,
            67
        }







        'Recorridos de las listas con el bucler For
        'y For Each

        Dim miLista4 As New List(Of Integer)
        miLista4.Add(48)
        miLista4.Add(30)
        miLista4.Add(120)
        miLista4.Add(92)

        For i = 0 To miLista4.Count - 1 Step 1

            Console.WriteLine(miLista4(i))
        Next

        For Each item As Integer In miLista4

            Console.WriteLine(item)
        Next







        'Copia de una Lista de elementos a un Array
        'con la función ToArray
        Console.WriteLine()

        Dim miLista5 As New List(Of Integer) From {
            48,
            30,
            120,
            92
        }

        Dim copiaArray() As Integer = miLista5.ToArray()

        For Each item As Integer In copiaArray

            Console.WriteLine(item)
        Next







        'Eliminacion de todos los elementos de la Lista
        'con el método Clear()
        Console.WriteLine()

        Dim miLista6 As New List(Of String) From {
            "Ventilador",
            "Carne",
            "Cepillo"
        }

        miLista6.Clear()

        Console.WriteLine(miLista6.Count)

    End Sub
End Module
