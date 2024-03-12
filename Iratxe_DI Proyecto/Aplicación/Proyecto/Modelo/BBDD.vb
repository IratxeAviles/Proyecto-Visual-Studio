Imports System.Data.SQLite

Public Class BBDD

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
    Public Function EditarJuego(nombre, genero, ano, descripcion) As Boolean
        Try
            Dim sql As String = "UPDATE JUEGOS SET GENERO = @genero, ANO = @ano, DESCRIPCION = @descripcion WHERE NOMBRE = @nombre;"
            Using con As New SQLiteConnection(My.Settings.conexion)
                con.Open()
                Using cmd As New SQLiteCommand(sql, con)
                    cmd.Parameters.Add("@nombre", DbType.String).Value = nombre
                    cmd.Parameters.Add("@genero", DbType.String).Value = genero
                    cmd.Parameters.Add("@ano", DbType.Int32).Value = ano
                    cmd.Parameters.Add("@descripcion", DbType.String).Value = descripcion
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & " No se inserta el juego")
        End Try
    End Function
End Class
