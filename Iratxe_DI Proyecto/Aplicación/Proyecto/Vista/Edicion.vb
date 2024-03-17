Public Class Edicion
    Public juego As Juego
    Shared ventana As Edicion
    Private controller As New Controlador()



    Shared Function GetInstance(juego As Juego) As Edicion
        If ventana Is Nothing Then
            ventana = New Edicion
        End If
        ventana.CargarDatos(juego)
        Return ventana
    End Function

    Shared Function GetInstance() As Edicion
        If ventana Is Nothing Then
            ventana = New Edicion
        End If

        Return ventana
    End Function

    Function CargarDatos(juego)
        editando.nombre = juego.Nombre
        editando.genero = juego.Genero
        editando.ano = juego.Ano.ToString
        editando.descripcion = juego.Descripcion


        AddHandler editando.Guardar, AddressOf Guardar
        AddHandler editando.Cancelar, AddressOf Cancelar

    End Function

    Sub CargarDatos()
        editando.nombre = juego.Nombre
        editando.genero = juego.Genero
        editando.ano = juego.Ano
        editando.descripcion = juego.Descripcion


        AddHandler editando.Guardar, AddressOf Guardar
        AddHandler editando.Cancelar, AddressOf Cancelar

    End Sub

    Sub Guardar()
        Dim numeroInt As Integer
        If Integer.TryParse(editando.AnoTB.Text, numeroInt) Then
            If numeroInt < 1950 Or numeroInt > 2024 Then
                MsgBox("El campo año tiene que estar entre 1950 y 2024", MsgBoxStyle.Critical, "Error")
            Else
                controller.EditarJuego(editando.nombre, editando.genero, editando.ano, editando.descripcion)
                Me.Close()
            End If

        Else
            MsgBox("El campo año tiene que ser un numero", MsgBoxStyle.Critical, "Error")

        End If

    End Sub


    Sub Cancelar()
        Me.Close()
    End Sub

    Private Sub editando_Load(sender As Object, e As EventArgs) Handles editando.Load

    End Sub
End Class