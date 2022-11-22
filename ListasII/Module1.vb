
Module Module1

    Sub Main()

        'LISTAS CON TIPOS COMPLEJOS

        'Crear una lista de tipos complejos es lo mismo
        'como crear una lista de tipos primitivos, con 
        'la diferencia que ahora se usaran clases para
        'la creación de cada uno de los elementos.

        Dim persona1 As New Persona With {
            .NombrePersona = "Alexis",
            .ApellidoPersona = "Diaz",
            .EdadPersona = 28
        }

        Dim persona2 As New Persona With {
            .NombrePersona = "Jonh",
            .ApellidoPersona = "Doe",
            .EdadPersona = 29
        }

        Dim persona3 As New Persona With {
            .NombrePersona = "Ashle",
            .ApellidoPersona = "Phine",
            .EdadPersona = 34
        }







        'Declaracion de una lista de Persona y adición de elementos
        'con el método Add. Se muestra la manera completa y simplificada
        'para realizar la declaración.

        Dim listaPersona1 As List(Of Persona) = New List(Of Persona)
        listaPersona1.Add(persona1)
        listaPersona1.Add(persona2)
        listaPersona1.Add(persona3)

        Dim listaPersona2 As New List(Of Persona)
        listaPersona2.Add(persona1)
        listaPersona2.Add(persona2)
        listaPersona2.Add(persona3)







        'Declaración y asignación de los elementos de la lista. Se 
        'muestra la manera completa y simplificada para realizar
        'la declaración.

        Dim listaPersona3 As List(Of Persona) = New List(Of Persona) From {
            New Persona() With {.NombrePersona = "Alexis", .ApellidoPersona = "Diaz", .EdadPersona = 28},
            New Persona() With {.NombrePersona = "Jonh", .ApellidoPersona = "Doe", .EdadPersona = 29},
            New Persona() With {.NombrePersona = "Ashle", .ApellidoPersona = "Phine", .EdadPersona = 34}
        }

        Dim listaPersona4 As List(Of Persona) = New List(Of Persona) From {
            New Persona("Alexis", "Diaz", 28),
            New Persona("Jonh", "Doe", 29),
            New Persona("Ashle", "Phine", 34)
        }

        Dim listaPersona5 As List(Of Persona) = New List(Of Persona) From {
           persona1,
           persona2,
           persona3
        }


        Dim listaPersona6 As New List(Of Persona) From {
            New Persona() With {.NombrePersona = "Alexis", .ApellidoPersona = "Diaz", .EdadPersona = 28},
            New Persona() With {.NombrePersona = "Jonh", .ApellidoPersona = "Doe", .EdadPersona = 29},
            New Persona() With {.NombrePersona = "Asle", .ApellidoPersona = "Phine", .EdadPersona = 34}
        }

        Dim listaPersona7 As New List(Of Persona) From {
            New Persona("Alexis", "Diaz", 28),
            New Persona("Jonh", "Doe", 29),
            New Persona("Ashle", "Phine", 34)
        }

        Dim listaPersona8 As New List(Of Persona) From {
          persona1,
          persona2,
          persona3
       }

    End Sub

End Module
