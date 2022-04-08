Module Module1

    'Los procedimientos sub no tienen valor de retorno
    'pero pueden recibir parametros
    'El llamado se realiza como cualquier otro metodo C#

    Sub Main()
        Console.WriteLine("Procedimiento principal")
        mostrarMensaje()
    End Sub

    Sub mostrarMensaje()
        Console.WriteLine("Estamos dentro del procedimiento sub")
    End Sub

End Module
