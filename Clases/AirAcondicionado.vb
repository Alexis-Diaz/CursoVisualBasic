Public Class AirAcondicionado

    'Las clases tienen propiedades o atributos. Estas son las caracteristicas 
    'de los objetos que se creen a partir de esta clase
    Public marca As String
    Public modelo As String
    Public color As String
    Public voltaje As Integer
    Public btu As Integer
    Public temperatura As Integer

    'Metodos de la clase. Las dos primeras no retornan nada
    Public Sub subirTemperatura()
        temperatura += 1
    End Sub

    Public Sub bajarTemperatura()
        temperatura -= 1
    End Sub

    Public Function temperaturaActual() As Integer

        Return temperatura

    End Function
End Class
