Module Module1

    Sub Main()
        'Las matricez guardan la informacion parecido a una tabla que tiene
        'filas y columnas. Para crear matricez se hace lo siguiente:

        '1 Forma: declaracion normal
        '(2,3) dos significa filas y 3 columnas
        Dim numeros(2, 3) As Integer

        '2 Forma: declaracion y asignacion de valores en linea
        'Puesto que de esta forma se asignan los valores en la marcha, no es necesario
        'especificar el numero de filas y columnas, el compilador al momento de correr
        'tomará esa información de acuerdo a los valores indicados. Cada par de llaves
        'conforman una fila, las comas fuera de las filas delimitan las columnas.

        'Nota: esta forma se debe ser cuidadoso para que las filas tengan el mismo
        'numero de elementos.
        Dim matrizNumero = New Integer(,) {{25, 13, 23}, {2, 3, 4}}

        'ASIGNACION DE VALORES

        '1 Forma: usando for

        'For filas = 0 To 1 Step 1
        '    For columna = 0 To 2 Step 1
        '        Console.WriteLine("Ingrese el valor de la posicion " & filas & ", " & columna & " ==> ")
        '        numeros(filas, columna) = Console.ReadLine()
        '    Next
        'Next

        '2 Forma: asignacion manual
        numeros(0, 0) = 25
        numeros(0, 1) = 29
        numeros(0, 2) = 12

        numeros(1, 0) = 26
        numeros(1, 1) = 30
        numeros(1, 2) = 13


        'ACCEDIENDO A SUS VALORES
        Console.WriteLine(numeros(0, 2))


        'usando for
        Console.WriteLine()
        For filas = 0 To 1 Step 1
            For columna = 0 To 2 Step 1
                Console.WriteLine(numeros(filas, columna))
            Next
        Next


        'usando for each
        'No se recomienda su uso en matrices
        'tiene un comportamiento extraño

        Console.WriteLine()
        For Each item As Integer In numeros
            Console.WriteLine(item)
        Next


        'CUANDO NO SE CONOCE FILAS Y COLUMNAS EN MATRICEZ
        'Cuando usamos 0 dentro del metodo GetUpperBound obtenemos el numero total de filas donde la primera fila es 1
        'Cuando le pasamos 1 al metodo nos devuelve el numero total de columnas donde la primera columna es 1
        For i = 0 To numeros.GetUpperBound(0) - 1 Step 1
            For j = 0 To numeros.GetUpperBound(1) - 1 Step 1
                Console.WriteLine(numeros(i, j))
            Next
        Next
    End Sub

End Module
