Module Ejercicio3
    Sub main()
        Dim compra As Double
        Dim descuento As Double
        Dim pagar As Double
        Dim salida As String
        While (True)
            Console.Write("Ingrese el total de su compra $ ")
            compra = Console.ReadLine()
            If compra >= 1000 Then
                descuento = compra * 0.3
            ElseIf compra >= 500 Then
                descuento = compra * 0.2
            ElseIf compra >= 250 Then
                descuento = compra * 0.1
            Else
                descuento = compra * 0.05
            End If
            pagar = compra - descuento
            Console.WriteLine("El total de su descuento es $" + descuento.ToString)
            Console.WriteLine("El total a pagar es $" + pagar.ToString)
            Console.WriteLine("Muchas gracias por su compra!!")
            Console.Write("Desea salir de la aplicacion.  S ?")
            salida = Console.ReadLine()
            If salida.ToLower = "s" Then
                Exit While
            End If
        End While



    End Sub

End Module
