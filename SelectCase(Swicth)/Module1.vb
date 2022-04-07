Module Module1

    Sub Main()
        'En visual basic no se usa punto y coma al terminar las instrucciones, tampoco es sensitve case

        'Elaborar un programa de consola en VB que permita realizar una opracion basica matematica
        'entre dos numeros, teniendo en cuenta la opcion del usuario por teclado, sindo 1=suma
        '2=resta, 3=multiplicacion, 3=division y 5=porcentaje.

        Console.WriteLine("Ingrese 1=sumar, 2=resta, 3=multiplicar, 4=dividir y 5=porcentaje")
        Dim opcion As Integer = Console.ReadLine()

        Dim numero1, numero2 As Double

        'swicth
        Select Case opcion
            Case 1 : Console.WriteLine("Ingrese el primer numero a sumar")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese el segundo numero a sumar")
                numero2 = Console.ReadLine()
                Console.WriteLine("La suma de los dos numeros es: " & (numero1 + numero2))
                Console.ReadKey()


            Case 2 : Console.WriteLine("Ingrese el primer numero a restar")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese el segundo numero a restar")
                numero2 = Console.ReadLine()
                Console.WriteLine("La suma de los dos numeros es: " & (numero1 - numero2))
                Console.ReadKey()

            Case 3 : Console.WriteLine("Ingrese el primer numero a multiplicar")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese el segundo numero a multiplicar")
                numero2 = Console.ReadLine()
                Console.WriteLine("La multiplicacion de los dos numeros es: " & (numero1 * numero2))
                Console.ReadKey()

            Case 4 : Console.WriteLine("Ingrese el primer numero a dividir")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese entre cuanto dividir")
                numero2 = Console.ReadLine()
                Console.WriteLine("La division de los dos numeros es: " & (numero1 / numero2))
                Console.ReadKey()

            Case 5 : Console.WriteLine("Ingrese el primer numero a sacar el porcentaje")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese el porcetanje")
                numero2 = Console.ReadLine()
                Console.WriteLine("El porcentaje de " & numero1 & " es: " & (numero1 * numero2) / 100)
                Console.ReadKey()

            Case Else
                Console.WriteLine("La opcion ingresada no es correcta")
                Console.ReadKey()
        End Select

    End Sub

End Module
