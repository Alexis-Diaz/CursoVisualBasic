Public Class AireAcondicionado
    'La encapsulacion consiste en ocultar los atributos o caracteristicas de un objeto
    'para que no sean accedidos desde otro objeto, de modo que, al utilizar el objeto
    'este cumpla con las operaciones para el cual fue creado, pero ocultando el funcio-
    'namiento del mismo a los objetos que interactuan entre si. Se hace necesario ocultar
    'estas propiedades no solo por convencion, sino para evitar que los modifiquen y 
    'pierdan su funcionalidad y seguridad.

    'Para realizar la encapsulacion debemos utilizar la palabra reservada Private

    Private _marca As String
    Private _modelo As String
    Private _color As String
    Private _voltaje As Integer
    Private _btu As Integer
    Private _temperatura As Integer


    'Como ahora las propiedades no pueden ser accedidas desde una instancia de clase
    'se debe hacer uso de funciones de propiedades. Esta es un tipo de funcion que
    'permite incluir de una vez el metodo get y set
    'Ejemplo:

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




    'Metodos de la clase
    Public Sub subirTemperatura()
        _temperatura += 1
    End Sub

    Public Sub bajarTemperatura()
        _temperatura -= 1
    End Sub

End Class
