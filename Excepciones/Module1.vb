Module Module1

    Sub Main()
        Dim nom, id As String
        Dim edad As Integer

        Try
            Console.Write("Ingrese el nombre de la persona--->")
            nom = Console.ReadLine()

            Console.Write("Ingrese el numero de indentificacion de la persona-->")
            id = Console.ReadLine()

            Console.Write("Ingrese la edad de la persona-->")
            edad = Console.ReadLine()

            Dim p As New Persona(nom, id, edad)
        Catch ex As InvalidCastException

            Console.Write("Ocurruio un error de tipo : " & ex.ToString)
        End Try

    End Sub

End Module

Public Class Persona

    Public Sub New(nombre As String, id As String, edad As Integer)
        _nombre = nombre
        _id = id
        _edad = edad
    End Sub


    Private _nombre As String
    Private _id As String
    Private _edad As Integer

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property edad As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
End Class
