Module Ejercicio5
    Sub main()
        Dim numero As Int16
        Dim multiplicar As Int64
        Dim salida As String
        While (True)
            Console.Write("Ingrese un numero: ")
        numero = Console.ReadLine()
        For i = 1 To 10
                multiplicar = numero * i
                Console.WriteLine(numero.ToString + " x " + i.ToString + " = " + multiplicar.ToString)
        Next
        Console.WriteLine("---------")
            Console.Write("Desea salir de la aplicacion.  S? ")
            salida = Console.ReadLine()
            If salida.ToLower = "s" Then
                Exit While
            End If
        End While

    End Sub
End Module
