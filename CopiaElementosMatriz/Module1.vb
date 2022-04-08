Module Module1

    Sub Main()

        'COPIAS POR VALORES
        'Para copiar una matriz a otra matriz se debe tener en cuenta tres cosas

        '1- La matriz debe tener el mismo tamaño de filas y columnas
        '2- La matriz debe ser del mismo tipo
        '3- La matriz debe estar vacia (no indispensable)

        Dim matrizOrigen = New Integer(,) {{12, 28}, {56, 70}}

        Dim matrizCopia(1, 1) As Integer

        'Se genera la copia
        For i = 0 To 1 Step 1 'filas

            For j = 0 To 1 Step 1 'columnas

                matrizCopia(i, j) = matrizOrigen(i, j)

            Next
        Next

        'Impresiones de valores
        Console.WriteLine("Matriz Copia")
        For Each item As Integer In matrizCopia
            Console.Write(item & " ")
        Next

        'Este tipo de copia no genera mutaciones en la matriz original ya que se hace
        'una copia aparte de la matriz.

        matrizCopia(0, 0) = 200
        Console.WriteLine()


        Console.WriteLine("Matriz Original")
        For Each item As Integer In matrizOrigen

            Console.Write(item & " ")

        Next



        Console.WriteLine()




        'COPIAS POR REFERENCIAS

        'Otra forma de realizar copia
        'Esta forma de copiar una matriz se debe tener cuidado ya que puede generar
        'mutaciones en la matriz original ya que se hace por referencia.


        Console.WriteLine()
        Console.WriteLine("Copias por referencias")

        Dim otrCopia = matrizOrigen

        Console.WriteLine("Matriz Copia")
        For Each item As Integer In otrCopia
            Console.Write(item & " ")
        Next

        otrCopia(0, 0) = 100
        Console.WriteLine()

        Console.WriteLine("Matriz Original")
        For Each item As Integer In matrizOrigen
            Console.Write(item & " ")
        Next



    End Sub

End Module
