Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices

Public Class Biblioteca
    Shared ventana As Biblioteca
    Dim listaJuegos As New List(Of Juego)
    Dim JuegosTLP = New TableLayoutPanel()
    Private controller As New Controlador()

    Shared Function GetInstance() As Biblioteca
        If ventana Is Nothing Then
            ventana = New Biblioteca
        End If
        Return ventana
    End Function

    Sub New()
        InitializeComponent()

        JuegosTLP.AutoScroll = True
        JuegosTLP.ColumnCount = 1
        JuegosTLP.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0!))

        ' Desactiva el llenado del DockStyle para permitir el centrado horizontal
        JuegosTLP.Dock = DockStyle.None

        ' Ajusta el tamaño de la tabla
        JuegosTLP.Size = New Size(600, 600)

        JuegosTLP.Anchor = AnchorStyles.None
        JuegosTLP.Location = New Point((Me.ClientSize.Width - JuegosTLP.Width) / 2, 0)

        JuegosTLP.Name = "JuegosTLP"
        JuegosTLP.TabIndex = 0

        Me.Controls.Add(JuegosTLP)
    End Sub




    Function CargarDatos() As List(Of Juego)
        listaJuegos = controller.ActualizarJuegos()
        JuegosTLP.Controls.Clear
        Me.Controls.Add(JuegosTLP)

        Dim i As Integer = 0
        For Each juego As Juego In listajuegos
            Dim registroControl As New Registro With {
                .nombre = juego.Nombre
            }
            JuegosTLP.RowStyles.Add(New RowStyle(AutoSize))
            JuegosTLP.Controls.Add(registroControl, 0, i)

            'AddHandler registroControl.Editar, AddressOf Editar
            AddHandler registroControl.Borrar, AddressOf Borrar

            i = i + 1
        Next
    End Function
    Private Sub Biblioteca_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.None
        listaJuegos = CargarDatos()
    End Sub

    'Sub Editar(sender As Object, e As ButtonClickEventArgs)
    '    Dim juego = BBDD.BuscarJuego(e.nombrePulsado)
    '    If listaJuegos.Count() = JuegosTLP.Rows Then
    '        Dim edicion As New EditarJuego
    '        edicion.nombre = juego.Nombre
    '        edicion.genero = juego.Genero
    '        edicion.ano = juego.Ano
    '        edicion.descripcion = juego.Descripcion
    '        JuegosTLP.Controls.Add(edicion, 0, listaJuegos.Count() + 1)
    '    End If
    'End Sub

    Sub Borrar(sender As Object, e As ButtonClickEventArgs)
        controller.BorrarJuego(e.nombrePulsado)
        CargarDatos()
    End Sub

End Class