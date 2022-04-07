Module Module1

    Sub Main()
        'Realizar un programa que muestre por consola si un estudiante con el dinero que tiene ahorrado
        'puede pagar la universidad y estudiar, teniendo en cuenta que el semestre del programa que 
        'estudia tiene un valor de 600 dolares

        Dim estudia As Boolean = False
        Console.WriteLine("Ingrese el dinero ahorrado")

        Dim dineroAhorrado As Double = Console.ReadLine()

        If dineroAhorrado >= 600 Then
            estudia = True
        End If

        If estudia = True Then
            Console.WriteLine("El dinero ahorrado sirve para pagar la universidad, por lo tando puedes estudiar")
        Else
            Console.WriteLine("El dinero ahorrado no sirve para pagar la universidad, por la tanto no puedes estudiar")

        End If

    End Sub

End Module
