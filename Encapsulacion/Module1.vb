Module Module1

    Sub Main()

        'La forma en que se establece el valor de la propiedad es por medio
        'de enviar un parametro al metodo set, y para obtener el valor es mediante
        'el llamado del metodo get
        Dim objeto As AireAcondicionado = New AireAcondicionado()


        'Uso del metodo set para establecer el valor de la propiedad 
        'encapsulada.
        objeto.setMarca("Hyu")
        objeto.setModelo("MH-92")
        objeto.setColor("color")
        objeto.setVoltaje("110")
        objeto.setBtu(18000)
        objeto.setTemperatura(0)

        'Uso del metodo get para obtener el valor de la propiedada
        'encapsulada
        Console.WriteLine(objeto.getMarca())
        Console.WriteLine(objeto.getModelo())
        Console.WriteLine(objeto.getColor())
        Console.WriteLine(objeto.getVoltaje())
        Console.WriteLine(objeto.getBtu())
        Console.WriteLine(objeto.getTemperatura())

        'Uso del metodo de temperatura
        Console.WriteLine()
        Console.WriteLine("Subiendo temperatura")
        objeto.subirTemperatura()
        objeto.subirTemperatura()
        objeto.subirTemperatura()
        Console.WriteLine(objeto.getTemperatura)
    End Sub

End Module
