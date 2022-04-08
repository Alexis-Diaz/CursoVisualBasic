Module Module1

    Sub Main()

        'COPIAS POR VALORES
        'Tres cosas a tomar en cuenta cuando se copia un array

        '1- La variable destino debe tener el mismo tamaño
        '2- La variable destino debe ser del mismo tipo
        '3- La variable destino debe ser array vacio (esto no es necesario)

        Dim arrayOriginal = New Integer() {14, 28, 56}

        Dim arrayCopia(2) As Integer  'Como el cero se cuenta se se usa 2 en el parentesis para que sean 3 elementos

        'Se crea copia
        For i = 0 To 2 Step 1
            arrayCopia(i) = arrayOriginal(i)
        Next

        'Imprisiones de valores
        Console.WriteLine("Array copia")

        For i = 0 To arrayCopia.Length - 1 Step 1
            Console.Write(arrayCopia(i) & " ")
        Next

        'Este tipo de copias de array no genera mutaciones en el array original
        'ya que se hace una copia del array independiente.
        arrayCopia(0) = 100

        Console.WriteLine()
        Console.WriteLine("Array original")

        For i = 0 To arrayOriginal.Length - 1 Step 1
            Console.Write(arrayOriginal(i) & " ")
        Next



        Console.WriteLine()
        Console.WriteLine()



        'COPIAS POR REFERENCIAS
        Dim otraCopia(2) As Integer
        otraCopia = arrayOriginal

        'Impresion de valores

        Console.WriteLine("Array copia")
        For Each item As Integer In otraCopia
            Console.Write(item & " ")
        Next

        'Este tipo de copias generan mutaciones en el array original ya que 
        'se hace una copia por referencias
        otraCopia(0) = 200

        Console.WriteLine()
        Console.WriteLine("Array original")
        For Each item As Integer In arrayOriginal
            Console.Write(item & " ")
        Next

    End Sub

End Module
