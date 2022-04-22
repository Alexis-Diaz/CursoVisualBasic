Public Class AireAcondicionado
    Private _marca As String
    Private _modelo As String
    Private _color As String
    Private _voltaje As Integer
    Private _btu As Integer
    Private _temperatura As Integer

    'Para crear un metodo constructor se debe usar la palabra 
    'reservada New, con esto Visual basic.net sabe que se trata
    'de un constructor.
    Public Sub New(marca As String, color As String, voltaje As Integer, btu As Integer)
        _marca = marca
        _color = color
        _voltaje = voltaje
        _btu = btu

        _modelo = marca.Substring(0, 2) & voltaje.ToString() & "ac" & btu.ToString().Substring(0, 2) & "k2020"
        _temperatura = 17

    End Sub

    Public Property marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Public Property modelo As String
        Get
            Return _modelo
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property

    Public Property color As String
        Get
            Return _color
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property

    Public Property voltaje As Integer
        Get
            Return _voltaje
        End Get
        Set(value As Integer)
            _voltaje = value
        End Set
    End Property

    Public Property btu As Integer
        Get
            Return _btu
        End Get
        Set(value As Integer)
            _btu = value
        End Set
    End Property

    Public Property temperatura As Integer
        Get
            Return _temperatura
        End Get
        Set(value As Integer)
            _temperatura = value
        End Set
    End Property

End Class
