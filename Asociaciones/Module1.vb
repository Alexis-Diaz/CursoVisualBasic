Module Module1

    Sub Main()
        'La asociación se da cuando una clase es un campo en otra clase. En este ejemplo
        'la clase Cliente es un campo en la clase CuentaAhorro

        Dim cuenta1 As New CuentaAhorros(New Cliente("Alexis", "123", "calle tal, ciudad tal", "12345678"), 250)
        Dim cuenta2 As New CuentaAhorros(New Cliente("Osmin", "123", "calle tal, ciudad tal", "12345678"), 250)

        Console.WriteLine(cuenta1.getSaldo())
        cuenta1.depositarDinero(600)
        Console.WriteLine(cuenta1.getSaldo())
        cuenta1.retirarDinero(400)
        Console.WriteLine(cuenta1.getSaldo)

        Console.WriteLine(cuenta1.clienteCuenta.NombreCliente)
        Console.WriteLine(cuenta1.getNumeroCuentaAhorros)
        Console.WriteLine(cuenta2.getNumeroCuentaAhorros)
    End Sub

End Module
