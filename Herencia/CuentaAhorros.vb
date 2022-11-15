Public Class CuentaAhorros
    Inherits Cuenta

    'Constructores
    Public Sub New()
        'Hacemos el llamado al constructor de la clase padre vacio
        MyBase.New()

    End Sub

    Public Sub New(cl As Cliente, sa As Double)
        'Hacemos el llamado al constructor de la clase padre sobrecargado
        MyBase.New(cl, sa)

    End Sub

End Class
