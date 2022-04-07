Imports System.Windows.Forms

Module Module1

    Sub Main()
        'Visual Basic NO es case sensitive

        'VARIABLES
        'Para crear variables se usa la palabra reservada Dim
        'El tipo se escribe despues del nombre de la variable con la palabra reservadas As
        Dim Numero As Integer = 12
        MessageBox.Show(Numero)

        'CONSTANTES
        'Para crear constantes se usa la palabra reservada Const, estas
        'no se pueden modificar mas adelante.
        'En visual basic es buena practica escribir en mayusculas las constantes
        Const PULGADA As Double = 2.54
        MessageBox.Show(PULGADA)


        'TIPOS DE DATOS
        Dim numeroEntero As Integer = 12
        Dim numeroDecimal As Double = 12
        Dim letra As Char = "a"
        Dim cadena As String = "Esto es una cadena"
        Dim booleano As Boolean = True

    End Sub

End Module
