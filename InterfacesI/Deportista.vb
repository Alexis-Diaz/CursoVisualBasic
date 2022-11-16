Public Class Deportista
    'Campos
    Private nombre As String
    Private posicion As String
    Private edad As Integer
    Private estatura As Double

    'Constructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal nom As String, ByVal pos As String, ByVal e As Integer, ByVal est As Double)
        nombre = nom
        posicion = pos
        edad = e
        estatura = est
    End Sub

    'Propiedades
    Public Property NombreDeportista() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property PosicionDeportista() As String
        Get
            Return posicion
        End Get
        Set(value As String)
            posicion = value
        End Set
    End Property

    Public Property EdadDeportista() As Integer
        Get
            Return edad
        End Get
        Set(value As Integer)
            edad = value
        End Set
    End Property

    Public Property EstaturaDeportista() As Double
        Get
            Return estatura
        End Get
        Set(value As Double)
            estatura = value
        End Set
    End Property
End Class
