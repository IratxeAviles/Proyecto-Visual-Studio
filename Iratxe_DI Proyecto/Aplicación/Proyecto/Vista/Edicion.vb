Public Class Edicion
    Public juego As Juego
    Shared ventana As Edicion
    Private controller As New Controlador()
    Dim InfoTLP = New TableLayoutPanel()



    Shared Function GetInstance() As Edicion
        If ventana Is Nothing Then
            ventana = New Edicion
        End If
        Return ventana
    End Function

    Private Sub Biblioteca_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.None
        CargarDatos()
    End Sub

    Sub New()
        InitializeComponent()

        InfoTLP.AutoScroll = True
        InfoTLP.ColumnCount = 1
        InfoTLP.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0!))
        InfoTLP.Dock = DockStyle.None
        InfoTLP.Size = New Size(600, 600)
        InfoTLP.Anchor = AnchorStyles.None
        InfoTLP.Location = New Point((Me.ClientSize.Width - InfoTLP.Width) / 2, 0)
        InfoTLP.Name = "InfoTLP"
        InfoTLP.TabIndex = 0

        Me.Controls.Add(InfoTLP)
    End Sub

    Function CargarDatos()
        InfoTLP.Controls.Clear
        Me.Controls.Add(InfoTLP)


        Dim editar As New EditarJuego With {
                .nombre = juego.Nombre
            }
        InfoTLP.RowStyles.Add(New RowStyle(AutoSize))
        InfoTLP.Controls.Add(editar, 0, 0)

        AddHandler editar.Guardar, AddressOf Guardar
        AddHandler editar.Cancelar, AddressOf Cancelar

    End Function

    Function AnadirJuego(datos As Juego)
        Dim info = New Juego With {
            .Nombre = datos.Nombre,
            .Genero = datos.Genero,
            .Ano = datos.Ano,
            .Descripcion = datos.Descripcion
            }
        juego = info
    End Function

    Sub Guardar()


    End Sub


    Sub Cancelar()
        BarraHerramienta.MostrarBiblioteca(ventana)

    End Sub
End Class