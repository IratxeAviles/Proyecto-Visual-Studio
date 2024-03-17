Public Class Edicion
    Public juego As Juego
    Shared ventana As Edicion
    Private controller As New Controlador()



    Shared Function GetInstance(juego) As Edicion
        If ventana Is Nothing Then
            ventana = New Edicion
        End If
        ventana.CargarDatos(juego)
        Return ventana
    End Function


    Function CargarDatos(juego)
        editando.nombre = juego.Nombre
        editando.genero = juego.Genero
        editando.ano = juego.Ano
        editando.descripcion = juego.Descripcion


        AddHandler editando.Guardar, AddressOf Guardar
        AddHandler editando.Cancelar, AddressOf Cancelar

    End Function

    Sub Guardar()


    End Sub


    Sub Cancelar()
        BarraHerramienta.MostrarBiblioteca(ventana)

    End Sub
End Class