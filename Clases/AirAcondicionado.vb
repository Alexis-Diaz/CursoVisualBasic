Public Class AirAcondicionado

    'Campos de la clase
    Private _marca As String
    Private _modelo As String
    Private _color As String
    Private _voltaje As Integer
    Private _btu As Integer
    Private _temperatura As Integer

    'Constructor
    Public Sub New()

    End Sub

    Public Sub New(mar As String, mode As String, col As String, vol As Integer, btuaire As Integer, tem As Integer)
        _marca = mar
        _modelo = mode
        _color = col
        _voltaje = vol
        _btu = btuaire
        _temperatura = tem
    End Sub

    'Las clases tienen propiedades o atributos. Estas son las caracteristicas 
    'de los objetos que se creen a partir de esta clase
    Public Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property Modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property

    Public Property Voltaje As Integer
        Get
            Return _voltaje
        End Get
        Set(value As Integer)
            _voltaje = value
        End Set
    End Property

    Public Property Btu As Integer
        Get
            Return _btu
        End Get
        Set(value As Integer)
            _btu = value
        End Set
    End Property

    Public Property Temperatura As Integer
        Get
            Return _temperatura
        End Get
        Set(value As Integer)
            _temperatura = value
        End Set
    End Property



    'Metodos de la clase. Las dos primeras no retornan nada
    Public Sub subirTemperatura()
        temperatura += 1
    End Sub

    Public Sub bajarTemperatura()
        temperatura -= 1
    End Sub

    Public Function temperaturaActual() As Integer

        Return temperatura

    End Function
End Class
