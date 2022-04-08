Module Module1

    'FUNCIONES O METODOS SUB
    'Los procedimientos sub no tienen valor de retorno
    'pero pueden recibir parametros
    'El llamado se realiza como cualquier otro metodo C#

    Sub Main()
        Console.WriteLine("Procedimiento principal")

        'Llamadas a otros metodos
        mostrarMensaje()
        saludo("Alexis")

    End Sub

    'FUNCIONES SIN PARAMETROS
    Sub mostrarMensaje()
        Console.WriteLine("Estamos dentro del procedimiento sub")
    End Sub


    'FUNCIONES CON PARAMETROS
    Sub saludo(nom As String)

        Console.WriteLine("Hola " & nom & " bienvenido(a) al mejor curso de visual basic.NET")

    End Sub


End Module
