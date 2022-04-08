Module Module1

    'PARAMETROS POR VALOR Y POR REFERENCIA
    Sub Main()

        'Como se nota, el valor de la variable NO ha cambiado
        Dim NumeroA As Integer = 5
        noCambiarValorVariable(NumeroA)
        Console.WriteLine(NumeroA)


        'Como se nota, el valor de la variable SI ha cambiado
        Dim numeroB As Integer = 5
        cambiarValorVariable(numeroB)
        Console.WriteLine(numeroB)

    End Sub

    'POR VALOR
    'Los parametros por valor son aquellos que pasan a la funcion el
    'una copia del contenido del parametro recibido.
    'Para pasar los parametros por valor se usan la palabra reservada
    'ByVal. En general no es necesario escribir esta palabra ya que 
    'Visual Basic.Net por defecto pasa los parametros por valor.

    Sub noCambiarValorVariable(ByVal num As Integer)

        num = 24
        Console.WriteLine(num)


    End Sub





    'POR REFERENCIA
    'Los parametros por referencia son aquellos que permiten a la funcion
    'apuntar directamente al espacio en memoria donde se guarda el valor de
    'la varibale. Esto significa que al cambiar el valor de la variable desde
    'dentro de la funcion, esta cambiara desde todos los lugares que es utilizada.
    'Para pasar los parametros por valor se usan la palabra reservada
    'ByRef. 

    Sub cambiarValorVariable(ByRef num As Integer)

        Console.WriteLine()

        num = 24
        Console.WriteLine(num)


    End Sub

End Module
