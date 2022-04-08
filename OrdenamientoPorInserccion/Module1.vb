Module Module1

    Sub Main()
        'El siguiente codigo ordena el array de menor a mayor. Basicamente lo que hace es recorrer el array
        'y comparar cada elemento con su anterior, si resulta que es menor cambian de posicion hasta que 
        'el array queda completamente ordenado.

        Dim numeros = New Integer() {233, 301, 192, 169, 215}

        For i = 1 To numeros.Length - 1 Step 1
            For j = i To 1 Step -1
                If numeros(j) < numeros(j - 1) Then

                    Dim aux As Integer = numeros(j)
                    numeros(j) = numeros(j - 1)
                    numeros(j - 1) = aux

                End If
            Next

        Next
        For Each num As Integer In numeros
            Console.Write(num & " ")
        Next
    End Sub

End Module
