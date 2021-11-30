Module Module1

    Sub Main()
        'El bucle do loop siempre se repetirá minimo una vez
        'existen dos formas: con while y con until

        'el while repite mientras condicion sea true
        'el until repite mientras condicion sea false
        Dim numero As Integer
        Do
            Console.WriteLine("Do Loop While entra si evalua true")
            Console.WriteLine("Ingrese un numero-->")
            numero = Console.ReadLine()

        Loop While (numero <> 0)

        Do
            Console.WriteLine("Do Loop Until entra si evalua false")

            Console.WriteLine("Ingrese un numero-->")
            numero = Console.ReadLine()
        Loop Until (numero <> 0)



    End Sub

End Module
