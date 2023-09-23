Module Ejercicio4
    Sub main()
        Dim numero As Int16
        Dim suma As Int64
        Dim acumula As Int64
        Dim salida As String
        While (True)
            suma = 0
            acumula = 0
            Console.Write("Ingrese un numero: ")
            numero = Console.ReadLine()
            For i = 1 To numero
                suma = suma + i
                Console.WriteLine(acumula.ToString + " + " + i.ToString + " = " + suma.ToString)
                acumula = acumula + i
            Next
            Console.WriteLine("---------")
            Console.WriteLine(suma.ToString)
            Console.Write("Desea salir de la aplicacion.  S? ")
            salida = Console.ReadLine()
            If salida.ToLower = "s" Then
                Exit While
            End If
        End While
    End Sub
End Module
