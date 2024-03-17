Public Class Controlador

    Private basedatos As New BBDD()
    Private listaJuegos As New List(Of Juego)

    Public Function GuardarUsuario(valorUsuario, valorContrasena, valorNContrasena) As Boolean

        If valorContrasena = valorNContrasena Then
            If basedatos.GuardarUsuario(valorUsuario, valorContrasena) Then
                MsgBox("Usuario añadido correctamente")
                Return True
            Else
                MsgBox("Este usuario ya está registrado", MsgBoxStyle.Critical, "Error")
                Return False
            End If

        Else
            MsgBox("Contraseña repetida incorrectamente", MsgBoxStyle.Critical, "Error")
            Return False
        End If

    End Function

    Public Function IniciarSesion(valorUsuario, valorContrasena) As Boolean

        If basedatos.IniciarSesion(valorUsuario, valorContrasena) Then
            Return True
        Else
            Return False
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
