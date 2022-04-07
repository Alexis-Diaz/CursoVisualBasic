Module Module1

    Sub Main()
        'BUCLES ANIDADOS
        'Se usan mas con los bucles for aunque se puede usar con otros bucles

        For i = 1 To 2 Step 1
            Console.WriteLine("Este es el mensaje del primer for")
            For j = 1 To 3 Step 1
                Console.WriteLine("Este es el mensaje del segundo for")

            Next
        Next


    End Sub

End Module
