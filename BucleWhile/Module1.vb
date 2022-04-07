Module Module1

    Sub Main()
        'Crear un programa que lea un numero N entero positivo de cualquier numero de digitos,
        'Calcule la suma de sus digitos y que imprima en pantalla el numero leido y la suma de
        'sus digitos. Ejemplos: N=89563 SUMA=31


        'Sintaxis
        Dim numero As Integer = 1
        While numero <> 0
            Console.WriteLine("Estamos en el bucle while")
            Console.WriteLine("Ingrese un numero para la variable. Ingrese 0 para cerrar.")
            numero = Console.ReadLine()

        End While

        'Resolucion del ejercicio anterior

        Console.WriteLine("Ingrese el digito")
        Dim digito As Integer = Console.ReadLine()

        Dim sumaDigito As Integer = 0

        While digito > 0
            Dim valor As Double
            valor = digito Mod 10

            sumaDigito = sumaDigito + (digito Mod 10)

            'si no se usa Math.Truncate da error de calculos ja jaj es extraño
            'al parecer el error lo da al dividir un valor de la varible y dicho
            'valor se le asigna a la misma

            digito = Math.Truncate(digito / 10)

        End While

        Console.WriteLine("La suma de los digitos es: " & sumaDigito)
    End Sub

End Module
