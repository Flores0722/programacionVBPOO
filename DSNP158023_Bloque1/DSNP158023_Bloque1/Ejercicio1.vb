Module Ejercicio1
    Sub Main()

        Dim edad As Int16
        Console.Write("Ingresa tu edad por favor: ")
        edad = Console.ReadLine()
        If edad >= 18 Then
            Console.WriteLine("Bienvenido, eres mayor de edad!")
        Else
            Console.WriteLine("No puedes Ingresar al local")
        End If

        Console.WriteLine("Presione cualquier tecla para salir")
        Console.ReadKey(True)

    End Sub

End Module
