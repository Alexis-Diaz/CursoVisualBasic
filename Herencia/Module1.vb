Module Module1

    Sub Main()
        Dim cuenta1 As New CuentaAhorros(New Cliente("Alexis", "126", "Calle tal, ciudad tal", "12345678"), 500)
        Dim cuenta2 As New CuentaAhorros(New Cliente("Alexis", "126", "Calle tal, ciudad tal", "12345678"), 500)

        Console.WriteLine(cuenta1.getSaldo)
        cuenta1.depositarDinero(500)
        Console.WriteLine(cuenta1.getSaldo)
        cuenta1.retirarDinero(300)
        Console.WriteLine(cuenta1.getSaldo)
        Console.WriteLine("-----------numeros de cuentas-------------")
        Console.WriteLine(cuenta1.getNumeroCuentaAhorros)
        Console.WriteLine(cuenta2.getNumeroCuentaAhorros)
    End Sub

End Module
