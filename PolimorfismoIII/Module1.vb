Module Module1
    'POLIMORFISMO
    'Significa que puede tener múltiples clases que se pueden usar de manera
    'intercambiable, aunque cada clase implementa las mismas propiedades o
    'los mismos métodos de manera diferentes.
    '
    'Hay dos maneras de aplicar Polimorfismo: uno por medio de la herencia de
    'una clase o mediante la implementación de una interfaz.
    '
    'A continuación veremos un ejemplo sencillo que explica el uso del poli-
    'morfismo en acción. En este ejemplo se explica la primer forma de lograr-
    'lo, por medio de la herencia.
    '
    'Veamos como una clase Persona puede llegar a comportarse como un Estu-
    'diante, un Profesor o un Director dependiendo del caso.
    '
    'Primero se crea la clase Persona con dos propiedades y un método para
    'obtener la información de la persona. Esta será la clase BASE o Padre.
    'Algo importante a tener en cuenta es que si deseamos personalizar los
    'métodos que la clase padre herede en las clases hijas, tenemos que usar
    'la palabra reservada Overridable (anulable).
    Class Persona

        Private _nombre As String
        Private _edad As Integer

        Public Sub New(nombre As String, edad As Integer)
            _nombre = nombre
            _edad = edad
        End Sub

        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property Edad() As Integer
            Get
                Return _edad
            End Get
            Set(value As Integer)
                _edad = value
            End Set
        End Property

        Public Overridable Function DarInformacion() As String

            Return "El nombre de la persona es: " & _nombre & " con edad de: " & _edad & " años."

        End Function
    End Class

    'Ahora se crean las tres clases hijas que heredarán de la clase padre. En cada constructor se
    'llama al constructor de la clase padre. Cada clase hija tiene su propio atributo personalizado
    'y sobreescribe el método de la clase padre para usarlo como se desee. Para indicar que se trata
    'de una sobreescritura de método se usa la palabra reservada Overrides
    Class Estudiante
        Inherits Persona

        Private _codigoEstudiante As String

        Public Sub New(nombre As String, edad As Integer, codEstdiante As String)
            MyBase.New(nombre, edad)
            _codigoEstudiante = codEstdiante
        End Sub

        Public Overrides Function DarInformacion() As String
            metodoPropio()
            Return "El nombre del estudiante es: " & Nombre & " con edad de: " & Edad & " años, y su código de estudiante es: " & _codigoEstudiante
        End Function

        'Este método es propio de la clase hija Estudiante
        Public Sub metodoPropio()
            Console.WriteLine("ESTUDIANTE")
        End Sub

    End Class

    Class Profesor
        Inherits Persona

        Private _especialidad As String

        Public Sub New(nombre As String, edad As Integer, especialida As String)
            MyBase.New(nombre, edad)
            _especialidad = especialida
        End Sub

        Public Property Especialidad() As String
            Get
                Return _especialidad
            End Get
            Set(value As String)
                _especialidad = value
            End Set
        End Property

        Public Overrides Function DarInformacion() As String
            metodoPropio()
            Return "El nombre del profesor es: " & Nombre & " con edad de: " & Edad & " años, y su especialidad es: " & _especialidad
        End Function

        'Este método es propio de la clase hija Profesor
        Public Sub metodoPropio()
            Console.WriteLine("PROFESOR")
        End Sub

    End Class

    Class Director
        Inherits Persona

        Private _nombreInstitucion As String

        Public Sub New(nombre As String, edad As Integer, nomEscuela As String)
            MyBase.New(nombre, edad)

            _nombreInstitucion = nomEscuela

        End Sub

        Public Overrides Function DarInformacion() As String
            metodoPropio()
            Return "El nombre del director es: " & Nombre & " con edad de: " & Edad & " años, y dirige la escuela: " & _nombreInstitucion
        End Function

        'Este método es propio de la clase hija Profesor
        Public Sub metodoPropio()
            Console.WriteLine("DIRECTOR")
        End Sub
    End Class

    'Ya que tenemos creadas las tres clases hijas veremos su funcionamiento.
    'Ahora crearemos tres objetos de tipo persona y almacenaremos en ellos a
    'un estudiante, un profesor y un director

    Sub Main()
        Dim persona1 As Persona
        Dim persona2 As Persona
        Dim persona3 As Persona

        'Como podemos observar, gracias a la herencia la clase persona puede
        'comportarse como un estudiante, un profesor o un director.
        persona1 = New Estudiante("Alexis", 17, "000023")
        persona2 = New Profesor("Roberto", 26, "Desarrollo de Software")
        persona3 = New Director("Jorge", 57, "República de China")

        'Tambien se puede crear una lista de Persona y guardar dentro de ella
        'estudiantes, profesores y directores.

        Dim personas As List(Of Persona) = New List(Of Persona) From {
           New Estudiante("Alexis", 17, "000023"),
           New Profesor("Roberto", 26, "Desarrollo de Software"),
           New Director("Jorge", 57, "República de China")
        }


        'Ahora crearemos un método para imprimir los valores de cada
        'objeto creado. Observar que el método recibe como parámetro
        'una Persona pero gracias al polimorfismo esto no será problema.
        ImprimirValores(persona1)
        ImprimirValores(persona2)
        ImprimirValores(persona3)

        'Output
        'ESTUDIANTE
        'El nombre del estudiante es: Alexis con edad de:   17 años, y su código de estudiante es: 000023
        'PROFESOR
        'El nombre del profesor es: Roberto con edad de:   26 años, y su especialidad es: Desarrollo de Software
        'DIRECTOR
        'El nombre del director es: Jorge con edad de:  57 años, y dirige la escuela: República de China

        'Observación importante: visual basic de forma dinámica accede a los métodos sobreescritos por las
        'clases hijas, para este caso al método sobreescrito DarInformacion(). Si dentro de un método sobreescrito se
        'utiliza un campo o un método que pertenece exclusivamente a la clase hija visual basic podrá utilizarlo
        'sin problemas; pero si deseamos usarlos directamente desde el objeto creado no se podrá, pues no lo
        'reconocerá como un miembro de la clase.

        Console.ReadKey()

    End Sub

    Public Sub ImprimirValores(persona As Persona)
        Console.WriteLine(persona.DarInformacion())
    End Sub

End Module
