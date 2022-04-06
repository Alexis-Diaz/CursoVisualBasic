Module Module1

    Sub Main()


        'OPERADORES ARITMETICOS
        'Suma
        Dim sumando1 As Integer = 2
        Dim sumando2 As Integer = 2
        Dim total As Integer = sumando1 + sumando2
        Console.WriteLine(total)

        'Resta
        Dim minuendo As Integer = 30
        Dim sustraendo As Integer = 2
        Dim diferencia As Integer = minuendo - sustraendo
        Console.WriteLine(diferencia)

        'Multiplicacion
        Dim multiplicando As Integer = 3
        Dim multiplicador As Integer = 4
        Dim producto As Integer = multiplicando * multiplicador
        Console.WriteLine(producto)

        'Division
        Dim dividendo As Integer = 29
        Dim divisor As Integer = 2
        Dim cociente As Double = dividendo / divisor
        Console.WriteLine(cociente)

        'Modulo
        Dim dividendo2 As Integer = 45
        Dim divisor2 As Integer = 2
        Dim residuo As Double = dividendo2 Mod divisor2
        Console.WriteLine(residuo)



        'OPERADORES RELACIONALES
        'Mayor que
        Dim a = 9 > 8
        Console.WriteLine(a)

        'Moyor o igual que
        Dim b As Boolean = 9 >= 9
        Console.WriteLine(b)

        'Menor que
        Dim c As Boolean = 99 < 200
        Console.WriteLine(c)

        'Menor o igual que
        Dim d As Boolean = 98 <= 19
        Console.WriteLine(d)

        'Igual que
        Dim e As Boolean = 9 = 9
        Console.WriteLine(e)

        'Diferente que
        Dim f As Boolean = 9 <> 9
        Console.WriteLine(f)



        'OPERADORES LOGICOS
        'and
        Dim g As Boolean = 7 > 2 And 9 < 2
        Console.WriteLine(g)

        'or
        Dim h As Boolean = 7 > 2 Or 9 < 2
        Console.WriteLine(g)

        'not
        Dim i As Boolean = Not 7 > 2
        Console.WriteLine(h)
        Console.ReadKey()
    End Sub

End Module
