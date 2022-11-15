Public Class CuentaAhorros

    'Campos
    Private numeroCuentaAhorros As Integer
    Private saldo As Double
    Private cte As Cliente

    Private Shared estableceNumeroCuenta As Integer = 1

    'Constructores
    Public Sub New()
        numeroCuentaAhorros = estableceNumeroCuenta
        saldo = 0
        cte = Nothing

        estableceNumeroCuenta += 1
    End Sub

    Public Sub New(cl As Cliente, sa As Double)
        numeroCuentaAhorros = estableceNumeroCuenta
        saldo = sa
        cte = cl

        estableceNumeroCuenta += 1
    End Sub

    'Propiedades
    Public Property clienteCuenta() As Cliente
        Get
            Return cte
        End Get
        Set(value As Cliente)
            If (cte Is Nothing) Then
                cte = value
            Else
                Console.WriteLine("El cliente ya esta asignado a la cuenta")
            End If

        End Set
    End Property

    'Metodos
    Public Function getNumeroCuentaAhorros() As Integer
        Return numeroCuentaAhorros
    End Function

    Public Function getSaldo() As Double
        Return saldo
    End Function

    Public Sub depositarDinero(va As Double)
        saldo = saldo + va
    End Sub

    Public Sub retirarDinero(va As Double)
        If (saldo >= va) Then
            saldo = saldo - va
        Else
            Console.WriteLine("El saldo disponible es menor al valor a retirar")
        End If

    End Sub
End Class
