Module Module1

    Sub Main()
        'El tippo string es una clase, los objetos creados con esta clase
        'tienen metodos que resultan utilies al programar
        Dim cadena1 = "Hola mi nombre es Alexis"
        Dim cadena2 = "hola mi nombre es alexis"


        'La clase String tiene funciones. Algunas de ellas son:

        'ToUpper
        Console.WriteLine(cadena1.ToUpper)

        'ToLower
        Console.WriteLine(cadena1.ToLower)

        'SubString
        Console.WriteLine(cadena1.Substring(0, 4)) 'output: Hola

        'Length
        Console.WriteLine(cadena1.Length)

        'Equals
        Console.WriteLine(cadena1.Equals(cadena2)) 'output: false
    End Sub

End Module
