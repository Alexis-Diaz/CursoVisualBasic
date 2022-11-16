﻿Public Class Cuenta

    'Campos
    Protected numcuenta As Integer
    Protected saldo As Double
    Protected cliente As Cliente
    Protected Shared Id As Integer = 1

    'Constructores
    Public Sub New()
        numcuenta = Id
        cliente = Nothing
        saldo = 0
        Id += 1
    End Sub

    Public Sub New(cl As Cliente, sa As Double)
        numcuenta = Id
        cliente = cl
        saldo = sa
        Id += 1
    End Sub

    'Propiedades
    Public Property clienteCuenta() As Cliente
        Get
            Return cliente
        End Get
        Set(value As Cliente)
            If (cliente Is Nothing) Then
                cliente = value
            Else
                Console.WriteLine("El cliente ya esta asignado a la cuenta")
            End If

        End Set
    End Property

    'Metodos
    Public Function getNumeroCuentaAhorros() As Integer
        Return numcuenta
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