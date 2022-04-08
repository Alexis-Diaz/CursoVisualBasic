Module Module1

    Sub Main()

        'BUSQUEDA PARCIAL
        'Se realiza la busque de una edad en un array, una vez encontrado ya no
        'se sigue recorriendo el array

        Dim edades = New Integer() {25, 21, 43, 58, 34}
        Dim edad, indice As Integer

        Dim encontrado As Boolean = False

        Console.WriteLine("Ingrese el numero a buscar")
        edad = Console.ReadLine()

        For i = 0 To edades.Length - 1 And encontrado = False Step 1

            If edad = edades(i) Then

                indice = i
                encontrado = True
                Exit For 'Se termina el bucle for

            End If

        Next

        If encontrado Then
            Console.WriteLine("El valor encontrado se ecuentra en la posicion " & indice)
        Else
            Console.WriteLine("No se encontro ningun valor ")

        End If




        Console.WriteLine()
        Console.WriteLine()



        'BUSQUEDA TOTAL
        'Se realiza la busque de edades menores a 50 años se recorre todo el array
        'para realizar la busqueda y mostrar en consola el total de edades.


        Dim contadora As Integer = 0


        For i = 0 To edades.Length - 1 Step 1

            If edades(i) < 50 Then

                contadora += 1

            End If

        Next

        Console.WriteLine("El numero de personas cuya edad es menor a 50 es: " & contadora)


    End Sub

End Module
