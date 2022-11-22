Module Module1

    Sub Main()
        'CLASES

        'Diferentes formas de crear un objeto

        '1) Instanciandolo y agregando valores a sus propiedades
        '   por medio de punto
        Dim objeto1 As AirAcondicionado = New AirAcondicionado()
        objeto1.marca = "Hyu"
        objeto1.modelo = "MH-92"
        objeto1.color = "color"
        objeto1.voltaje = "110"
        objeto1.btu = 18000
        objeto1.temperatura = 0

        Dim objeto2 As New AirAcondicionado()
        objeto2.marca = "Hyu"
        objeto2.modelo = "MH-92"
        objeto2.color = "color"
        objeto2.voltaje = "110"
        objeto2.btu = 18000
        objeto2.temperatura = 0



        '2) Instanciandolo y agregando valores a sus propiedades
        '   en la misma inicialización
        Dim objeto3 As AirAcondicionado = New AirAcondicionado With {
            .Marca = "Hyu",
            .Modelo = "MH-92",
            .Color = "color",
            .Voltaje = "110",
            .Btu = 18000,
            .Temperatura = 0
        }

        Dim objeto4 As New AirAcondicionado With {
            .marca = "Hyu",
            .modelo = "MH-92",
            .color = "color",
            .voltaje = "110",
            .btu = 18000,
            .temperatura = 0
        }



        '2) Instanciandolo y agregando valores a sus propiedades
        '   por medio del constructor. Falta agregar el ejemplo
        Dim objeto5 As New AirAcondicionado("Hyu", "MH-92", "green", 120, 1922, 10)




        'Lectura de los valores
        Console.WriteLine(objeto1.marca)
        Console.WriteLine(objeto1.modelo)
        Console.WriteLine(objeto1.color)
        Console.WriteLine(objeto1.voltaje)
        Console.WriteLine(objeto1.btu)
        Console.WriteLine(objeto1.temperatura)

        'Uso del metodo de temperatura
        Console.WriteLine()
        Console.WriteLine("Subiendo temperatura")
        objeto1.subirTemperatura()
        objeto1.subirTemperatura()
        objeto1.subirTemperatura()
        Console.WriteLine(objeto1.temperatura)
    End Sub

End Module
