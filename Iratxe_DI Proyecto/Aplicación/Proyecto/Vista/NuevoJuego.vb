Imports System.ComponentModel
Imports System.Data.SQLite

Public Class NuevoJuego

    Shared ventana As NuevoJuego
    Private controller As New Controlador()

    Shared Function GetInstance() As NuevoJuego
        If ventana Is Nothing Then
            ventana = New NuevoJuego
        End If
        Return ventana
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles GenerosL.Click

    End Sub

    Private Sub NuevoJuego_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub

    Private Sub GuardarB_Click(sender As Object, e As EventArgs) Handles GuardarB.Click
        Dim valorNombre As String = NombreTB.Text
        Dim valorDescripcion As String = DescripcionRTB.Text
        Dim valorGenero As String = GenerosTB.Text
        Dim valorAno As Integer = AnoNUD.Value

        If controller.NuevoJuego(valorNombre, valorGenero, valorAno, valorDescripcion) = True Then
            Me.Close()
        End If

    End Sub

    Private Sub CancelarB_Click(sender As Object, e As EventArgs) Handles CancelarB.Click
        BarraHerramienta.MostrarBiblioteca(Biblioteca)
        Me.Close()
    End Sub

    Private Sub NuevoJuego_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Biblioteca.GetInstance().CargarDatos()
        Biblioteca.GetInstance().Show()
    End Sub
End Class