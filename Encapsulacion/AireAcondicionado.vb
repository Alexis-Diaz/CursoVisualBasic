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
    'se debe hacer uso de los metodos set y get, los cuales sirven para asignar valores
    'y obtener el valor de la propiedad. Para ello se hace uso de funciones sub y function
    'Ejemplo:

    Public Sub setMarca(value As String)
        _marca = value
    End Sub

    Public Function getMarca() As String
        Return _marca
    End Function

    Public Sub setModelo(value As String)
        _modelo = value
    End Sub

    Public Function getModelo() As String
        Return _modelo
    End Function

    Public Sub setColor(value As String)
        _color = value
    End Sub

    Public Function getColor() As String
        Return _color
    End Function

    Public Sub setVoltaje(value As Integer)
        _voltaje = value
    End Sub
    Public Function getVoltaje() As Integer
        Return _voltaje
    End Function

    Public Sub setBtu(value As String)
        _btu = value
    End Sub

    Public Function getBtu() As String
        Return _btu
    End Function

    Public Sub setTemperatura(value As Integer)
        _temperatura = value
    End Sub

    Public Function getTemperatura() As Integer
        Return _temperatura
    End Function

    'Metodos de la clase
    Public Sub subirTemperatura()
        _temperatura += 1
    End Sub

    Public Sub bajarTemperatura()
        _temperatura -= 1
    End Sub

End Class
