Public Class Mamiferos
    Inherits Animal

    Public Sub New()
        MyBase.New()

    End Sub

    Public Overrides Function moverse() As String
        Return "El mamifero camina"
    End Function

End Class
