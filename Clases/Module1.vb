Module Module1

    Sub Main()
        Dim objeto As AirAcondicionado = New AirAcondicionado()

        objeto.marca = "Hyu"
        objeto.modelo = "MH-92"
        objeto.color = "color"
        objeto.voltaje = "110"
        objeto.btu = 18000
        objeto.temperatura = 0

        Console.WriteLine(objeto.marca)
        Console.WriteLine(objeto.modelo)
        Console.WriteLine(objeto.color)
        Console.WriteLine(objeto.voltaje)
        Console.WriteLine(objeto.btu)
        Console.WriteLine(objeto.temperatura)

        'Uso del metodo de temperatura
        Console.WriteLine()
        Console.WriteLine("Subiendo temperatura")
        objeto.subirTemperatura()
        objeto.subirTemperatura()
        objeto.subirTemperatura()
        Console.WriteLine(objeto.temperatura)
    End Sub

End Module
