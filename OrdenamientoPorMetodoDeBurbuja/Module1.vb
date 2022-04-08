Module Module1

    Sub Main()

        Dim numeros = New Integer() {233, 301, 192, 169, 215}

        For i = 0 To numeros.Length - 1 Step 1
            For j = 0 To numeros.Length - 2 Step 1

                If numeros(j) > numeros(j + 1) Then

                    Dim aux As Integer = numeros(j)
                    numeros(j) = numeros(j + 1)
                    numeros(j + 1) = aux

                End If
            Next
        Next

        For Each num As Integer In numeros

            Console.Write(num & " ")

        Next
    End Sub

End Module
