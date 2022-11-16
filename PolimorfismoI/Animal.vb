Public Class Animal
    Private grupo As String

    Public Sub New()

    End Sub

    Public Property grupoAnimal()
        Get
            Return grupo
        End Get
        Set(value)
            grupo = value
        End Set
    End Property

    'La palabra reservada Overridable indica que este metodo se
    'puede sobreescribir desde una clase hija

    Public Overridable Function moverse() As String
        Return "El " & grupo & " ha empezado a moverse"
    End Function
End Class
