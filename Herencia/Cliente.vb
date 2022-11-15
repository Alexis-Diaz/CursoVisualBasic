Public Class Cliente
    Inherits Persona

    'Constructores
    Public Sub New()
        'Hacemos el llamado al constructor de la clase padre vacio
        MyBase.New()

    End Sub

    Public Sub New(nom As String, ce As String, dir As String, tel As String)
        'Hacemos el llamado al constructor de la clase padre sobrecargado
        MyBase.New(nom, ce, dir, tel)
    End Sub
End Class
