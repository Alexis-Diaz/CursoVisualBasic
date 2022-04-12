Module Module1

    Sub Main()
        'USO DE FINALLY

        'Crear un programa que permita mostrar por consola el descuento
        'de un articulo, teniendo en cuenta que el descuento maximo por
        'articulo es de 400, por lo tanto, si el valor del descuento es 
        'mayor a este valor, lanzar una excepcion de tipo
        'System.Overflow.exception. Para desarrollar este ejercicio se
        'debe realizar un procedimiento que compruebe dicho descuento.

        Console.Write("Ingrese el valor del articulo-->")
        Dim valorArticulo As Double = Console.ReadLine()

        Console.Write("Ingrese el valor de descuento a aplicar-->")
        Dim descuento As Double = Console.ReadLine()

        Try
            compruebaDescuento(valorArticulo, descuento)

        Catch ex As OverflowException

            Console.WriteLine(ex.Message)

        Finally

            Console.WriteLine("El valor del articulo es: " & valorArticulo)

        End Try
    End Sub

    Sub compruebaDescuento(valor As Double, descuento As Double)
        Dim totalDescuento As Double = (valor * descuento) / 100

        If totalDescuento > 400 Then
            Throw New OverflowException
        Else
            Console.WriteLine("El descuento es: " & totalDescuento)
        End If
    End Sub

End Module
