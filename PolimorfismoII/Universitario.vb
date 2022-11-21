Public Class Universitario
    Inherits Estudiante

    Private _programa As String

    Public Sub New(nom As String, noI As String, dir As String, tel As String, car As Boolean, pr As String)

        MyBase.New(nom, noI, dir, tel, car)
        _programa = pr

    End Sub

    Public Property Programa As String
        Get
            Return _programa
        End Get
        Set(value As String)
            _programa = value
        End Set
    End Property

    Public Overrides Sub darDescripcionEstudiante()
        Console.WriteLine("*************************************")
        Console.WriteLine("")
        Console.WriteLine("Datos del estudiante: ")
        Console.WriteLine("Nombre: " & NombrePersona)
        Console.WriteLine("Tipo de identificacion: " & TipoIdPersona)
        Console.WriteLine("Numero de identificacion: " & NoIdentificacionPersona)
        Console.WriteLine("Codigo estudiantil: " & CodigoEstudiante)
        Console.WriteLine("Carnet estudiantil: " & CarnetEstudiantil)
        Console.WriteLine("Progrma de Pregrado: " & Programa)
        Console.WriteLine("Edad: " & EdadPersona)
        Console.WriteLine("Direccion: " & DireccionPersona)
        Console.WriteLine("Telefono: " & TelfonoPersona)
    End Sub
End Class
