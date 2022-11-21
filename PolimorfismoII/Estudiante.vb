Public Class Estudiante
    Inherits Persona

    Private _codigoEstudiante As String
    Private _carnetEstudiantil As Boolean

    'Public Sub New()
    '    MyBase.New()

    'End Sub

    Public Sub New(nom As String, noI As String, dir As String, tel As String, car As Boolean)
        MyBase.New(nom, noI, dir, tel)
        _carnetEstudiantil = car
    End Sub

    Public Property CodigoEstudiante As String
        Get
            Return _codigoEstudiante
        End Get
        Set(value As String)
            _codigoEstudiante = value
        End Set
    End Property

    Public Property CarnetEstudiantil As Boolean
        Get
            Return _carnetEstudiantil
        End Get
        Set(value As Boolean)
            _carnetEstudiantil = value
        End Set
    End Property

    ''Metodos 
    Public Overridable Sub darDescripcionEstudiante()
        Console.WriteLine("*************************************")
        Console.WriteLine("")
        Console.WriteLine("Datos del estudiante: ")
        Console.WriteLine("Nombre: " & NombrePersona)
        Console.WriteLine("Tipo de identificacion: " & TipoIdPersona)
        Console.WriteLine("Numero de identificacion: " & NoIdentificacionPersona)
        Console.WriteLine("Codigo estudiantil: " & CodigoEstudiante)
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Direccion: " & DireccionPersona)
        Console.WriteLine("Telefono: " & TelfonoPersona)
    End Sub
End Class
