Public Class Estudiante
    'SHARED
    'Esta palabra nos permite declarar una variable, propiedad, función o método
    'y asociarlo solo a la clase y no la instancia.

    'Su implementación es la siguiente: 
    ' * En el caso de las variables o atributos de clase que implementen esta palabra clave
    'el valor solo será de la clase y no de la instancia u objeto.

    '* En el caso de los metodos, para utilizarlo no se debe crear una instancia de la clase
    'para acceder a ellos, sino que se coloca el nombnre de la clase seguido del metodo 
    '(esto es equivalente a los metodos o propiedades estaticas de C#)


    Private codigoEstudiante As Integer
    Private nombre As String

    Private Shared codigo As Integer = 1

    Public Sub New(nom As String)
        nombre = nom
        codigoEstudiante = codigo
        codigo += 1
    End Sub

    Public Function getCodigoEstudiante() As Integer
        Return codigoEstudiante
    End Function

    Public Function getNombre() As String
        Return nombre
    End Function
End Class
