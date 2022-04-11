Public Class Persona
    Private nombres As String

    Private numId As String

    'Metodo constructor
    Public Sub New(nom As String, ni As String)
        nombres = nom
        numId = ni
    End Sub

    Public Function getNombres() As String
        Return nombres

    End Function

    Public Function getNumId() As String
        Return numId

    End Function

End Class
