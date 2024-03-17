Imports System.Data.SQLite
Imports Microsoft.VisualBasic.Devices

Public Class BBDD

    Public Function BuscarUsuario(valorUsuario) As Usuario
        Dim usuario As New Usuario
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
            Dim consulta As String = "SELECT USUARIO FROM USUARIOS WHERE USUARIO = @usuario"
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@usuario", valorUsuario)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()
            Dim resultado As String = ""

            While lector.Read()
                usuario.usuario = lector("Usuario").ToString()
                usuario.contrasena = lector("Contrasena").ToString()
            End While

            lector.Close()
            conexion.Close()


            Return usuario

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function GuardarUsuario(valorUsuario, valorContrasena)
        Try
            Dim sql As String = "INSERT INTO USUARIOS (USUARIO, CONTRASENA) VALUES (@usuario, @contrasena);"
            Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
            con.Open()
            Dim cmd2 As New SQLiteCommand(sql, con)
            cmd2.Parameters.Add("@usuario", DbType.String).Value = valorUsuario
            cmd2.Parameters.Add("@contrasena", DbType.String).Value = valorContrasena
            cmd2.ExecuteNonQuery()

            MsgBox("Usuario guardado correctamente")

            con.Close()
            Dim Aplicacion As New BarraHerramienta
            Aplicacion.Show()

        Catch ex As Exception
            MsgBox("Error al guardar usuario", MsgBoxStyle.Critical, "Error")
        End Try
    End Function
    Public Function ListaJuegos() As List(Of Juego)
        Dim lista As New List(Of Juego)()
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
            Dim consulta As String = String.Format("SELECT NOMBRE, GENERO, ANO, DESCRIPCION FROM JUEGOS”)
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()

            While lector.Read()
                Dim juego As New Juego()
                juego.Nombre = lector("Nombre").ToString()
                juego.Genero = lector("Genero").ToString()
                juego.Ano = Convert.ToInt32(lector("Ano"))
                juego.Descripcion = lector("Descripcion").ToString()
                lista.Add(juego)
            End While

            Return lista
            lector.Close()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function NuevoJuego(nombre, genero, ano, descripcion)
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
            Dim consulta As String = "SELECT NOMBRE FROM JUEGOS WHERE NOMBRE = @nombre"
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()
            Dim resultado As String = ""

            While lector.Read()
                resultado &= lector.GetString(0) & " ya existe en la base de datos." & vbLf
            End While

            lector.Close()
            conexion.Close()
            If resultado <> "" Then
                MsgBox(resultado)
            Else
                Try
                    Dim sql As String = "INSERT INTO JUEGOS (NOMBRE, GENERO, ANO, DESCRIPCION) VALUES (@nombre, @genero, @ano, @descripcion);"
                    Dim con As New SQLiteConnection(My.Settings.conexion)
                    con.Open()
                    Dim cmd2 As New SQLiteCommand(sql, con)

                    cmd2.Parameters.Add("@nombre", DbType.String).Value = nombre
                    cmd2.Parameters.Add("@genero", DbType.String).Value = genero
                    cmd2.Parameters.Add("@ano", DbType.Int32).Value = ano
                    cmd2.Parameters.Add("@descripcion", DbType.String).Value = descripcion
                    cmd2.ExecuteNonQuery()
                    lector.Close()
                    conexion.Close()
                    MsgBox("Juego guardado correctamente")

                Catch ex As Exception
                    MsgBox(ex.Message & " No se inserta el juego")
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function BuscarJuego(nombre) As Juego
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
            Dim consulta As String = "SELECT NOMBRE, GENERO, ANO, DESCRIPCION FROM JUEGOS WHERE NOMBRE = @nombre"
            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()

            Dim juego As New Juego()
            While lector.Read()
                juego.Nombre = lector("Nombre").ToString()
                juego.Genero = lector("Genero").ToString()
                juego.Ano = Convert.ToInt32(lector("Ano"))
                juego.Descripcion = lector("Descripcion").ToString()
            End While

            Return juego
            lector.Close()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function EditarJuego(nombre, genero, ano, descripcion)
        Try
            Dim sql As String = "UPDATE JUEGOS SET GENERO = @genero, ANO = @ano, DESCRIPCION = @descripcion WHERE NOMBRE = @nombre;"
            Dim con As New SQLiteConnection(My.Settings.conexion)
            con.Open()

            Dim cmd As New SQLiteCommand(sql, con)
            cmd.Parameters.Add("@nombre", DbType.String).Value = nombre
            cmd.Parameters.Add("@genero", DbType.String).Value = genero
            cmd.Parameters.Add("@ano", DbType.Int32).Value = ano
            cmd.Parameters.Add("@descripcion", DbType.String).Value = descripcion
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Juego editado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message & " No se pudo editar el juego")
        End Try
    End Function

    Public Function BorrarJuego(nombre)
        Try
            Dim conexion As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
            conexion.Open()
            Dim sql As String = "DELETE FROM JUEGOS WHERE NOMBRE = @nombre"
            Dim cmd As New SQLiteCommand(sql, conexion)
            cmd.Parameters.Add("@nombre", DbType.String).Value = nombre

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & " No se pudo borrar el juego")
        End Try
    End Function
End Class
