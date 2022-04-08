Module Module1

    Sub Main()

        'Tres cosas a tomar en cuenta cuando se copia un array

        '1- La variable destino debe tener el mismo tamaño
        '2- La variable destino debe ser del mismo tipo
        '3- La variable destino debe ser array vacio (esto no es necesario)


        Dim numeros = New Integer() {14, 28, 56}

        Dim arrayCopia(2) As Integer  'Como el cero se cuenta se se usa 2 en el parentesis para que sean 3 elementos

        For i = 0 To 2 Step 1
            arrayCopia(i) = numeros(i)
        Next

        For i = 0 To arrayCopia.Length - 1 Step 1
            Console.Write(arrayCopia(i) & " ")
        Next

    End Sub

End Module
