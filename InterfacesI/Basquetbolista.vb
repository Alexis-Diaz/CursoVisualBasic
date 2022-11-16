Public Class Basquetbolista
    Inherits Deportista
    Implements IBasquetbolista

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal nom As String, ByVal pos As String, ByVal e As Integer, ByVal est As Double)
        MyBase.New(nom, pos, e, est)
    End Sub

    Public Function verificarEstatura() As Boolean Implements IBasquetbolista.verificarEstatura

        If (EstaturaDeportista >= 190) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
