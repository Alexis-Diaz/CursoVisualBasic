Module Module1

    Sub Main()
        Console.WriteLine(suma(4, 6))

        Dim array() = New Integer() {1, 2, 3, 4, 5, 6, 7}
        Console.WriteLine(realizarBusqueda(8, array))
    End Sub



    'Realizar un procedimiento que permita retornar la suma entre dos numeros enteros
    Function suma(num1 As Integer, num2 As Integer) As Integer
        Return num1 + num2
    End Function



    'Realizar un procedimiento que permita buscar un numero en concreto dentro de un array
    'retornando la posicion donde encontro el elemento buscado.
    Function realizarBusqueda(num As Integer, array() As Integer) As Integer

        Dim indice As Integer = -1

        For i = 0 To array.Length - 1 Step 1
            If array(i) = num Then
                indice = i
                Exit For
            End If
        Next

        Return indice
    End Function


End Module
