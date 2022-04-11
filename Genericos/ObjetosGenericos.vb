'Para crear una clase generica en visual basic .net se usa
'agrega parentesis al final del nombre de la clase, dentro
'de ellos se usa Of y por convencion se usa la letra t 
'minuscula para hacer referencia al tipo generico. La letra
'no necesariamente debe ser la t, puede ser cualquier letra
'o palabra

'El atributo miObjeto sera del tipo que se le pase a la clase
Public Class ObjetosGenericos(Of t)

    Private miObjeto As t

    Public Property ElObjeto As t
        Get
            Return miObjeto
        End Get
        Set(value As t)
            miObjeto = value
        End Set
    End Property

End Class
