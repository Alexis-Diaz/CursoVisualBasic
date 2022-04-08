Module Module2

    Sub Metodo()
        '                                filas     columnas
        Dim numerosA = New Integer(,) {{1, 2, 3}, {4, 5, 6}}

        For Each item As Integer In numerosA
            Console.Write(item)
        Next
        Console.WriteLine()
        Console.WriteLine("Redimencion")


        'Si deseamos redimensionar esta Matriz, debemos usar la palabra reservada ReDim
        'Eso si, los datos de la matriz se borraran. Ejemplo:

        ReDim numerosA(3, 3)

        For Each item As Integer In numerosA
            Console.Write(item & " ")
        Next


        'En el caso de las matrices a diferencia de los array no se puede
        'conservar los datos que almacenan al momento de redimensionarlos
        'por lo que si queremos utilizar la palabra reservada nos mostrara
        'un error en tiempo de ejecucion.

        numerosA(0, 0) = 10
        numerosA(0, 1) = 11
        numerosA(0, 2) = 12
        numerosA(0, 3) = 13
        numerosA(1, 0) = 14
        numerosA(1, 1) = 15
        numerosA(1, 2) = 16
        numerosA(1, 3) = 17
        numerosA(2, 0) = 18
        numerosA(2, 1) = 19
        numerosA(2, 2) = 20
        numerosA(2, 3) = 21
        numerosA(3, 0) = 22
        numerosA(3, 1) = 23
        numerosA(3, 2) = 24
        numerosA(3, 3) = 25


        Console.WriteLine()

        For Each item As Integer In numerosA
            Console.Write(item & " ")
        Next

    End Sub

End Module
