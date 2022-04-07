Module Module1

    Sub Main()
        'ARRAY
        'Algo importante a tomar en cuenta es que cuando creamos un array
        'el numero que le asignamos entre parentesis indica el numero de 
        'elementos que contendra. Ahora bien este numero puede resultar un
        'poco confuso, ya que se debe tomar en cuenta que incluye el cero.
        'Por ejemplo, en este array si queremos guardar tres elementos le
        'pasaremos como numero dos, porque el cero se cuenta. Asi el array
        'alamacenaria el elemento 0, elemento 1 y el elemento 2.
        Dim vector(2) As Integer

        vector(0) = 1
        vector(1) = 2
        vector(2) = 3

        For Each item As Integer In vector

            Console.WriteLine(item)

        Next

        Console.WriteLine()


        'MATRIZ
        'Algo importante a tomar en cuenta es que cuando creamos una matriz
        'el numero que le asignamos entre parentesis indica el numero de 
        'filas y columnas que contendra. Ahora bien este numero puede resultar un
        'poco confuso, ya que se debe tomar en cuenta que incluye el cero.
        'Por ejemplo, en esta matriz si queremos crear 2 filas y dos columnas le
        'pasaremos como numero 1, 1 porque el cero se cuenta. Asi la matriz
        'tendria dos filas (0,0 y 0,1) y dos columnas (1,0 y 1,1).
        Dim matriz(1, 1) As Integer
        matriz(0, 0) = 1
        matriz(0, 1) = 2
        matriz(1, 0) = 3
        matriz(1, 1) = 4


        For Each num As Integer In matriz
            Console.WriteLine(num)
        Next

        Console.WriteLine()


        For fila = 0 To matriz.GetUpperBound(0) Step 1
            For columna = 0 To matriz.GetUpperBound(1) Step 1
                Console.WriteLine(matriz(fila, columna))
            Next
        Next



    End Sub

End Module
