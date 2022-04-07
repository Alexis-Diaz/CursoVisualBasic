Module Module1

    Sub Main()
        'Elabora un programa de consola en visual basic que ingrese el valor total por teclado de una compra,
        'se pide se realizar descuento de acuerdo a los siguiente: 

        'Si el valor de compra esta entre 50-100 el descuento es del 5%
        'Si esta entre 101-150 el descuento es del 10%
        'Si la compra es mayor a 150 es del 15%

        'El programa debe mostrar el total de la compra, el total de la compra con el descuento y el descuento.

        Console.WriteLine("Ingrese el valor total de la compra")
        Dim valorCompra As Double = Console.ReadLine()

        Dim descuento As Double = 0

        If valorCompra >= 50 And valorCompra <= 100 Then
            descuento = valorCompra * 0.05
        ElseIf valorCompra > 100 And valorCompra <= 150 Then
            descuento = valorCompra * 0.1

        ElseIf valorCompra > 150 Then
            descuento = valorCompra * 0.15
        End If

        Console.WriteLine("El valor total de la compra si descuento es: " & valorCompra)
        Console.WriteLine("El valor total de la compra con descuento es: " & valorCompra - descuento)
        Console.WriteLine("El valor del descuento es: " & descuento)

    End Sub

End Module
