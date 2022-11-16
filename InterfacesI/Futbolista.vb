Public Class Futbolista
    Inherits Deportista

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal nom As String, ByVal pos As String, ByVal e As Integer, ByVal est As Double)
        MyBase.New(nom, pos, e, est)
    End Sub
End Class
