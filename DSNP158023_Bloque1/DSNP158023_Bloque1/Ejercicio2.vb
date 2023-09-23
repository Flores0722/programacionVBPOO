Module Ejercicio2
    Sub Main()
        Dim num As Int16
        Dim salida As String
        While (True)
            Console.WriteLine("Por favor ingresa un numero")
            num = Console.ReadLine()
            If num < 0 Then
                Console.WriteLine("El numero que ingreso es negativo")
            Else
                Console.WriteLine("El numero que ingreso es positivo")
            End If
            Console.Write("Desea salir de la aplicacion.  S ?")
            salida = Console.ReadLine()
            If salida.ToLower = "s" Then
                Exit While
            End If
        End While


    End Sub

End Module
