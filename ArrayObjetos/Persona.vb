Public Class Persona
    Private nombre As String
    Private apellido As String

    Public Property NombrePersona As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property ApellidoPersona As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property
End Class
