Public Class Aves
    Inherits Animal

    Public Sub New()
        MyBase.New()

    End Sub

    Public Overrides Function moverse() As String
        Return "El " & grupoAnimal & " vuela"
    End Function

End Class
