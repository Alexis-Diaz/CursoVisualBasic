Public Class Persona
    Private nombre As String
    Private tipoId As String
    Private noIdentificacion As String
    Private edad As Integer
    Private direccion As String
    Private telefono As String

    'Constructores
    'Public Sub New()

    'End Sub

    Public Sub New(nom As String, noI As String, dir As String, tel As String)
        nombre = nom
        noIdentificacion = noI
        direccion = dir
        telefono = tel
    End Sub

    Public Property NombrePersona As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property NoIdentificacionPersona As String
        Get
            Return noIdentificacion
        End Get
        Set(value As String)
            noIdentificacion = value
        End Set
    End Property

    Public Property EdadPersona As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Public Property DireccionPersona As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelfonoPersona As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property TipoIdPersona As String
        Get
            Return tipoId
        End Get
        Set(value As String)
            tipoId = value
        End Set
    End Property
End Class
