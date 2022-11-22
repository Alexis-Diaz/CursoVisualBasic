Class Persona
    Private _nombrePersona As String
    Private _apellidoPersona As String
    Private _edadPersona As Integer

    Public Sub New()

    End Sub

    Public Sub New(nombre As String, apellido As String, edad As Integer)
        _nombrePersona = nombre
        _apellidoPersona = apellido
        _edadPersona = edad
    End Sub

    Public Property NombrePersona As String
        Get
            Return _nombrePersona
        End Get
        Set(value As String)
            _nombrePersona = value
        End Set
    End Property

    Public Property ApellidoPersona As String
        Get
            Return _apellidoPersona
        End Get
        Set(value As String)
            _apellidoPersona = value
        End Set
    End Property

    Public Property EdadPersona As Integer
        Get
            Return _edadPersona
        End Get
        Set(value As Integer)
            _edadPersona = value
        End Set
    End Property
End Class
