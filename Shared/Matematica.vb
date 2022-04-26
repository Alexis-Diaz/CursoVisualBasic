Public Class Matematica

    'Tambien se pueden crear metodos estáticos utilizando la 
    'palabra shared

    Public Shared Function potenciacion(base As Double, exponente As Double) As Double

        Dim total As Double = 1
        For i = 1 To exponente Step 1

            total = total * base

        Next

        Return total

    End Function
End Class
