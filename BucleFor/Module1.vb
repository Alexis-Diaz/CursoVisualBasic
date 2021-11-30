Module Module1

    Sub Main()
        'Hace un algoritamo que imprima los primeros 20 terminos de la siguiente
        'serie 1,3,6,10,15,21,28...
        Dim suma As Integer = 1

        For i = 2 To 20 Step 1
            If i <> 20 Then
                Console.Write(suma & ", ")
            Else
                Console.Write(suma)
            End If
            suma = suma + i
        Next

        Console.WriteLine()


        'la condicion To dice i<=3, Step es el incremento
        For i = 1 To 3 Step 1
            Console.WriteLine("Alexis es el mejor")
        Next



    End Sub

End Module
