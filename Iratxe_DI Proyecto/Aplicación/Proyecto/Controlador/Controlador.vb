Public Class Controlador

    Private basedatos As New BBDD()
    Private listaJuegos As New List(Of Juego)

    Public Function IniciarSesion(valorUsuario, valorContrasena)
        basedatos.BuscarUsuario(valorUsuario)
    End Function
    Public Function GuardarUsuario(valorUsuario, valorContrasena, valorNContrasena)
        If valorContrasena = valorNContrasena Then
            Dim resultado = basedatos.BuscarUsuario(valorUsuario)
            If resultado Is Nothing Then
                MsgBox(resultado.usuario + " ya está creeado")
            Else
                basedatos.GuardarUsuario(valorUsuario, valorContrasena)
            End If
        Else
            MsgBox("Contraseña repetida incorrectamente", MsgBoxStyle.Critical, "Error")
        End If


    End Function
    Public Function ActualizarJuegos() As List(Of Juego)
        Return basedatos.ListaJuegos()
    End Function

    Public Function BuscarJuego(nombre) As Juego
        Return basedatos.BuscarJuego(nombre)
    End Function

    Public Function EditarJuego(nombre, genero, ano, descripcion)
        basedatos.EditarJuego(nombre, genero, ano, descripcion)
    End Function

    Public Function BorrarJuego(nombre) As List(Of Juego)
        basedatos.BorrarJuego(nombre)
        Return ActualizarJuegos()
    End Function
End Class
