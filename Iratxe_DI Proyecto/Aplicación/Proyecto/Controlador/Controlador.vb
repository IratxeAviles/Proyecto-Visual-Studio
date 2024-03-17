Public Class Controlador

    Private basedatos As New BBDD()
    Private listaJuegos As New List(Of Juego)

    Public Function ActualizarJuegos() As List(Of Juego)
        Return basedatos.ListaJuegos()
    End Function

    Public Function BorrarJuego(nombre) As List(Of Juego)
        basedatos.BorrarJuego(nombre)
        Return ActualizarJuegos()
    End Function
End Class
