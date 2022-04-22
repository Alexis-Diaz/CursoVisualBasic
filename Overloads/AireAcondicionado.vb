Public Class AireAcondicionado
    'Propiedades
    Private _marca As String
    Private _modelo As String
    Private _color As String
    Private _voltaje As Integer
    Private _btu As Integer
    Private _temperatura As Integer

    'Metodos get y set
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

    'Metodos

    'Sobrecarga de metodos: Sobrecargar se refiere a utilizar
    'el mismo nombre de metodo pero con distinto numero de parametros.
    'Esto permite utilizar el mismo nombre de metodo y bajo este
    'agregar nuevas funciones. Para sobrecargar se usa la palabra
    'reservada Overloads despues del tipo de acceso.

    Public Overloads Sub subirTemperatura()
        If _temperatura < 30 Then
            _temperatura += 1
        End If
    End Sub

    Public Overloads Sub subirTemperatura(grados As Integer)
        Dim tem As Integer = _temperatura + grados
        If tem > 30 Then
            _temperatura = 30

        Else
            _temperatura = tem
        End If

    End Sub


    Public Overloads Sub bajarTemperatura()
        If _temperatura < 30 Then
            _temperatura -= 1
        End If
    End Sub

    Public Overloads Sub bajarTemperatura(grados As Integer)
        Dim tem As Integer = _temperatura - grados
        If tem < 0 Then
            _temperatura = 0

        Else
            _temperatura = tem
        End If

    End Sub

    Public Function temperaturaActual() As Integer

        Return temperatura

    End Function
End Class
