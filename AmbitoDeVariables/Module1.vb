Module Module1
    'El ambito o scope hacer referencia al alcance de la variable

    'Alcance global: este tipo de variables seran alcanzadas desde todos los metodos que pertenecen
    'a la clase Module1
    Dim VariableGlobal As String = "Osmin"


    Sub Main()
        'Alcance local: solo pueden ser accedidas desde dentro del metodo donde han sido declaradas
        Dim VariableLocal As String = "Alexis"

        Console.WriteLine(VariableGlobal)
        Console.WriteLine(VariableLocal)

        Metodo()
        Console.ReadKey()


    End Sub


    Sub Metodo()
        Console.WriteLine(VariableGlobal)
        'Console.WriteLine(VariableLocal)'No es alcanzable
    End Sub
End Module
