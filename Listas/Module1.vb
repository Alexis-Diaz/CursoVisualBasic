Module Module1

    Sub Main()

        'LISTAS

        '************Creacion de un lista con tipos primitivos************

        'Declaracion de una lista de string

        Dim _miLista1 As List(Of String) = New List(Of String)

        'Adición de los elementos con el método Add
        _miLista1.Add("Alexis")
        _miLista1.Add("Zapatos")
        _miLista1.Add("Perfume")


        Dim miLista1 As New List(Of String)

        'Adición de los elementos con el método Add
        miLista1.Add("Alexis")
        miLista1.Add("Zapatos")
        miLista1.Add("Perfume")







        'Declaración y asignación de los elementos de la lista
        Dim _miLista2 As List(Of String) = New List(Of String) From {"Ventilador", "Carne", "Cepillo"}

        Dim miLista2 As List(Of String) = New List(Of String) From {
            "Ventilador",
            "Carne",
            "Cepillo"
        }


        'Declaración y asignación de los elementos de la lista abreviado
        Dim _miLista3 As New List(Of Integer) From {23, 34, 56, 67}

        Dim miLista3 As New List(Of Integer) From {
            23,
            34,
            56,
            67
        }


        'Recorridos de las listas

        Dim miLista4 As New List(Of Integer)

        miLista4.Add(48)
        miLista4.Add(30)
        miLista4.Add(120)
        miLista4.Add(92)

        'Recorrido de la lista con el bucle For
        For i = 0 To miLista4.Count - 1 Step 1
            Console.WriteLine(miLista4(i))
        Next

        Console.WriteLine()

        'Recorrido de la lista con el bucle For Each
        For Each item As Integer In miLista4
            Console.WriteLine(item)
        Next




        'Copia de una lista a un Array
        Console.WriteLine()
        Console.WriteLine("Copia de lista en Array")

        Dim copiaLista() As Integer = miLista4.ToArray

        For Each item As Integer In copiaLista

            Console.WriteLine(item)
        Next

        'Eliminacion de todos los elementos de la lista
        Console.WriteLine("Se eliminan los elementos de la lista")
        miLista4.Clear()

        For i = 0 To miLista4.Count - 1 Step 1
            Console.WriteLine(miLista4(i))
        Next


    End Sub

End Module
