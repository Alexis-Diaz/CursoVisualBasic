Module Module1

    Sub Main()
        'REDIMENSIONAR ARRAY

        'Puede que en ciertos momentos sea necesario volver a utilizar un array que contenga
        'valores almacenados, como en estos casos el array ya tiene programado un numero 
        'especificos de elementos que contendra no podra ser usado para crear un nuevo array
        'con mas elementos. Sin embargo, esto se puede resolver si utilizamos dos palabras 
        'claves ReDim y Preserve.

        Dim numerosA = New Integer() {1, 2, 3, 4}

        For Each num As Integer In numerosA

            Console.Write(num & " ")

        Next

        Console.WriteLine(" ")

        'Con la palabra reservada ReDim redimensionamos el tamaño del array
        'Se debe tener en cuenta que la redimension borra los datos existentes
        'y vuelve a incrementar o decrementar su capacidad. Esto es asi porque
        'se trata de liberar espacio en memoria. En este caso particular, como 
        'el array es de tipo Integer los valores que se mostraran seran ceros

        ReDim numerosA(5)
        numerosA(4) = 5
        numerosA(5) = 6

        For Each num As Integer In numerosA

            Console.Write(num & " ")

        Next

        Console.WriteLine("")
        Console.WriteLine("")






        'Si no deseamos que la memoria se libere debemos utilizar otra palabra
        'reservada Preserve junto a ReDim
        'Ejemplo:
        Dim numerosB = New Integer() {1, 2, 3, 4}

        For Each num As Integer In numerosB

            Console.Write(num & " ")

        Next

        Console.WriteLine(" ")


        ReDim Preserve numerosB(5)
        numerosB(4) = 5
        numerosB(5) = 6

        For Each num As Integer In numerosB

            Console.Write(num & " ")

        Next

        Console.WriteLine()
        Console.WriteLine("============Matricez===================")

        Metodo()
    End Sub

End Module
