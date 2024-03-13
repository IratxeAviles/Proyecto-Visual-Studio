Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices
Imports Registro

Public Class Biblioteca
    Shared ventana As Biblioteca
    Dim listaJuegos As New List(Of Juego)
    Dim JuegosTLP = New TableLayoutPanel()
    Private BBDD As New BBDD()

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
        JuegosTLP.Dock = DockStyle.Fill
        JuegosTLP.Name = "JuegosTLP"
        JuegosTLP.TabIndex = 0

        Me.Controls.Add(JuegosTLP)
    End Sub

    Sub CargarDatos()
        Dim listajuegos As List(Of Juego) = BBDD.ListaJuegos()
        JuegosTLP.Controls.Clear
        Me.Controls.Add(JuegosTLP)
    End Sub
    Private Sub Biblioteca_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.None
        CargarDatos()

        Dim i As Integer = 0
        For Each juego As Juego In listaJuegos
            Dim registroControl As New Registro With {
                .nombre = juego.Nombre
            }
            JuegosTLP.RowStyles.Add(New RowStyle(AutoSize))
            JuegosTLP.Controls.Add(juego, 0, i)

            i = i + 1
        Next

    End Sub

    Private Sub Registro1_Load(sender As Object, e As EventArgs)

    End Sub
End Class