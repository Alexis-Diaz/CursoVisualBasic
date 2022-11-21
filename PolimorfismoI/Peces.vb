Public Class Peces
    Inherits Animal

    Public Sub New()
        MyBase.New()

    End Sub

    'La palabra reservada Overrides (anula) indica que este metodo
    'se esta sobreescribiendo

    Public Overrides Function moverse() As String
        Return "El " & grupoAnimal & " nada"
    End Function

    Public Function Comer() As String
        Return "El " & grupoAnimal & " se fué a comer"
    End Function

End Class
